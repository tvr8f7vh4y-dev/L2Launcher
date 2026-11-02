Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Drawing.Drawing2D

Public Class frmMain

    '###########################################################################
    '#  CONFIGURACAO - EDITE SOMENTE ESTE BLOCO
    '###########################################################################

    ' -- Endereco do servidor de jogo (vai no parametro IP= do L2.bin)
    Public Shared gameServerIP As String = "127.0.0.1"

    ' -- Onde os arquivos de update estao hospedados (precisa da barra no fim)
    Public Shared baseURL As String = "http://127.0.0.1/updater/"

    ' -- Nome do servidor exibido no cartao
    Public Shared serverName As String = "PHOENIX"

    ' -- Frase do cartao
    Public Shared serverTagline As String = "Reborn from ashes!"

    ' -- Endereco da API que devolve players online e uptime (JSON)
    '    Esperado: {"players":531,"uptime":"408d 23h"}
    Public Shared statusAPI As String = "http://127.0.0.1/api/status"

    ' -- Pasta do cliente com o L2.bin (system, system1, systemEU...)
    Public Shared clientFolder As String = "system1"

    ' -- Nome do executavel do jogo
    Public Shared clientExe As String = "L2.bin"

    ' -- Botoes do topo. Deixe vazio ("") para esconder o botao.
    Public Shared btnDownloadsURL As String = ""
    Public Shared btnStreamersURL As String = ""
    Public Shared btnStoreURL As String = ""
    Public Shared btnSupportURL As String = ""
    Public Shared btnForumURL As String = ""

    ' -- Links das redes sociais. Deixe vazio ("") para esconder o icone.
    Public Shared linkDiscord As String = ""
    Public Shared linkWhatsApp As String = ""
    Public Shared linkInstagram As String = ""
    Public Shared linkFacebook As String = ""
    Public Shared linkYouTube As String = ""

    ' -- Banner de noticias dentro do launcher.
    Public Shared enableBrowser As Boolean = False
    Public Shared browserURL As String = "http://127.0.0.1/news/"

    '###########################################################################
    '#  FIM DA CONFIGURACAO
    '###########################################################################

    Dim versionFileURL As String
    Dim fileListURL As String
    Dim downloadFolderName As String = "$Patch$"
    Dim pakFolderName As String = "zips"
    Dim pakExtension As String = ".zip"
    Dim launcherLocalVersion As Integer = 0
    Dim launcherWebVersion As Integer = 0
    Dim myStartupPath As String
    Dim myFileName As String
    Dim progressBarCounter As Integer
    Dim progressBarCounterMax As Integer
    Dim progressText As String
    Dim updating As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versionFileURL = baseURL + "version.txt"
        fileListURL = baseURL + "filelist.txt"

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        myStartupPath = Application.StartupPath + "\"
        myFileName = Path.GetFileName(Application.ExecutablePath)

        'Self-update: arquivo terminando em "_" e a copia de atualizacao
        If myFileName.EndsWith("_") Then
            Threading.Thread.Sleep(2000)
            Dim parentPath As String = Mid(Application.StartupPath, 1, Application.StartupPath.LastIndexOf("\"))
            Dim parentPathFileName As String = Mid(myFileName, 1, myFileName.Length - 1)
            File.Copy(myStartupPath + myFileName, parentPath + "\" + parentPathFileName, True)
            Shell(parentPath + "\" + parentPathFileName, vbNormalFocus)
            End
        End If

        lblServerName.Text = serverName
        lblServerTagline.Text = serverTagline
        lblVersion.Text = "Version: " + My.Application.Info.Version.ToString()

        If linkDiscord.Length = 0 Then picDiscord.Visible = False
        If linkWhatsApp.Length = 0 Then picWhatsApp.Visible = False
        If linkInstagram.Length = 0 Then picInstagram.Visible = False
        If linkFacebook.Length = 0 Then picFacebook.Visible = False
        If linkYouTube.Length = 0 Then picYouTube.Visible = False

        If btnDownloadsURL.Length = 0 Then btnDownloads.Visible = False
        If btnStreamersURL.Length = 0 Then btnStreamers.Visible = False
        If btnStoreURL.Length = 0 Then btnStore.Visible = False
        If btnSupportURL.Length = 0 Then btnSupport.Visible = False
        If btnForumURL.Length = 0 Then btnForum.Visible = False

        If File.Exists("version.ini") Then
            Using fileReader As StreamReader = New StreamReader("version.ini")
                Integer.TryParse(fileReader.ReadLine(), launcherLocalVersion)
            End Using
        End If

        'Status do servidor em segundo plano
        Call New Action(AddressOf loadServerStatus).BeginInvoke(Nothing, Me)

        If Not checkAddress(versionFileURL) Then
            picRepair.Enabled = False
            lblStatus.Text = "Servidor de atualizacao offline."
            Exit Sub
        End If

        Try
            Dim client As WebClient = New WebClient()
            Dim webReader As StreamReader = New StreamReader(client.OpenRead(versionFileURL))
            Dim iVersion As String = webReader.ReadLine()
            If iVersion IsNot Nothing AndAlso iVersion.Length > 0 Then
                Integer.TryParse(iVersion, launcherWebVersion)
            End If
            webReader.Close()
        Catch ex As Exception
            lblStatus.Text = "Nao foi possivel ler a versao do servidor."
            Exit Sub
        End Try

        If (launcherLocalVersion < launcherWebVersion) Then
            picStart.Enabled = False
            picRepair.Enabled = False
            lblFileName.Text = ""
            UpdateTimer.Enabled = True
            Call New Action(AddressOf updateFromWeb).BeginInvoke(Nothing, Me)
        Else
            lblStatus.Text = "Your game is up to date. You can now start the game."
        End If
    End Sub

    ''' <summary>Le players online + uptime da API e atualiza o cartao.</summary>
    Private Sub loadServerStatus()
        Dim playersText As String = "-"
        Dim uptimeText As String = "-"
        Dim isOnline As Boolean = False

        If statusAPI.Length > 0 AndAlso checkAddress(statusAPI) Then
            Try
                Dim client As WebClient = New WebClient()
                Dim json As String = client.DownloadString(statusAPI)

                Dim mP As Match = Regex.Match(json, """players""\s*:\s*(\d+)")
                If mP.Success Then
                    playersText = mP.Groups(1).Value
                    isOnline = True
                End If

                Dim mU As Match = Regex.Match(json, """uptime""\s*:\s*""([^""]+)""")
                If mU.Success Then
                    uptimeText = mU.Groups(1).Value
                End If
            Catch ex As Exception
                'mantem offline
            End Try
        End If

        setStatusLabels(playersText, uptimeText, isOnline)
    End Sub

    Private Sub setStatusLabels(players As String, uptime As String, online As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() setStatusLabels(players, uptime, online))
        Else
            lblPlayers.Text = players + " player(s)  -  " + uptime
            If online Then
                lblOnline.Text = "ONLINE"
                lblOnline.ForeColor = Color.FromArgb(90, 235, 140)
            Else
                lblOnline.Text = "OFFLINE"
                lblOnline.ForeColor = Color.FromArgb(235, 90, 90)
            End If
        End If
    End Sub

    Private Function checkAddress(ByVal URL As String) As Boolean
        Try
            Dim req As WebRequest = WebRequest.Create(URL)
            req.Timeout = 4000
            Dim resp As WebResponse = req.GetResponse()
            resp.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub updateFromWeb()
        updating = True

        Dim myFileList As New List(Of String)
        Try
            Dim client As WebClient = New WebClient()
            Dim webReader As StreamReader = New StreamReader(client.OpenRead(fileListURL))
            While (webReader.Peek() <> -1)
                myFileList.Add(webReader.ReadLine())
            End While
            webReader.Close()
        Catch ex As Exception
            updating = False
            setStatus("Falha ao ler a lista de arquivos.")
            enableButtons(True)
            Exit Sub
        End Try

        progressBarInit(myFileList.Count)

        If (Directory.Exists(myStartupPath + downloadFolderName)) Then
            Directory.Delete(myStartupPath + downloadFolderName, True)
        End If
        Directory.CreateDirectory(myStartupPath + downloadFolderName)

        Dim clientWeb As WebClient = New WebClient()
        Dim fileHash As String
        Dim fileName As String

        For Each fileInfo In myFileList
            If fileInfo.Trim().Length = 0 Then Continue For

            fileHash = fileInfo.Split(vbTab)(0).Trim().ToLower()
            fileName = Regex.Replace(fileInfo.Split(vbTab)(1), "[^\u0020-\u007E]+", String.Empty)

            If fileName.ToLower().Equals(myFileName.ToLower()) Then
                If (Not getFileHash(myStartupPath + fileName).Equals(fileHash)) Then
                    myFileName = fileName
                    startSelfUpdate()
                    Exit Sub
                End If
                Continue For
            End If

            progressBarInc()
            progressText = "Checking: " + fileName

            If (File.Exists(myStartupPath + fileName)) Then
                If getFileHash(myStartupPath + fileName).Equals(fileHash) Then
                    Continue For
                End If
            End If

            Dim downloadedFileName As String
            If fileName.Contains("\") Then
                downloadedFileName = myStartupPath + downloadFolderName + "\" + Mid(fileName, fileName.LastIndexOf("\") + 1, fileName.Length) + ".tmp"
            Else
                downloadedFileName = myStartupPath + downloadFolderName + "\" + fileName + ".tmp"
            End If

            progressText = "Downloading: " + fileName

            Try
                clientWeb.DownloadFile(baseURL + pakFolderName + "/" + fileName.Replace("\", "/") + pakExtension, downloadedFileName)
            Catch ex As Exception
                MessageBox.Show("Problem downloading " + fileName, "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Continue For
            End Try

            If fileName.Contains("\") Then
                Dim fileFolderPath As String = myStartupPath + Mid(fileName, 1, fileName.LastIndexOf("\"))
                If (Not Directory.Exists(fileFolderPath)) Then
                    Directory.CreateDirectory(fileFolderPath)
                End If
            End If

            If File.Exists(myStartupPath + fileName) Then
                File.Delete(myStartupPath + fileName)
            End If

            ZipFile.ExtractToDirectory(downloadedFileName, myStartupPath)
            File.Delete(downloadedFileName)
        Next

        Directory.Delete(myStartupPath + downloadFolderName, True)

        Using outputFile As StreamWriter = New StreamWriter(myStartupPath + "version.ini", False, System.Text.Encoding.Unicode)
            outputFile.Write(launcherWebVersion.ToString())
        End Using

        setStatus("Your game is up to date. You can now start the game.")
        updating = False
        enableButtons(True)
    End Sub

    Private Sub startSelfUpdate()
        Dim downloadedFileName = myStartupPath + downloadFolderName + "\" + myFileName + ".tmp"

        Dim webClient As New WebClient()
        Try
            webClient.DownloadFile(baseURL + pakFolderName + "/" + myFileName + pakExtension, downloadedFileName)
        Catch ex As Exception
            MessageBox.Show("Problem downloading " + myFileName, "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        ZipFile.ExtractToDirectory(downloadedFileName, myStartupPath + downloadFolderName)
        My.Computer.FileSystem.RenameFile(myStartupPath + downloadFolderName + "\" + myFileName, myFileName + "_")
        Shell(downloadFolderName + "\" + myFileName + "_", vbMinimizedNoFocus)
        End
    End Sub

    Private Function getFileHash(ByVal fileName As String) As String
        Dim hash = SHA256.Create()
        Dim hashValue() As Byte

        Dim fileStream As FileStream = File.OpenRead(fileName)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        fileStream.Close()

        Dim hashHex As String = ""
        For counter = 0 To hashValue.Length - 1
            hashHex += hashValue(counter).ToString("X2")
        Next counter

        Return hashHex.ToLower()
    End Function

    Private Sub setStatus(text As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() setStatus(text))
        Else
            lblStatus.Text = text
        End If
    End Sub

    Private Sub enableButtons(state As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() enableButtons(state))
        Else
            picStart.Enabled = state
            picRepair.Enabled = state
        End If
    End Sub

    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            mouseX = Cursor.Position.X - Me.Left
            mouseY = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub progressBarInit(count As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() progressBarInit(count))
        Else
            progressBarCounter = 0
            progressBarCounterMax = count
            picLoadingFore.Width = 0
        End If
    End Sub

    Private Sub progressBarInc()
        progressBarCounter = progressBarCounter + 1
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property

    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        If Me.InvokeRequired Then
            Me.Invoke(Sub() updateTimer_Tick(sender, e))
            Exit Sub
        End If

        lblFileName.Text = progressText

        If progressBarCounterMax > 0 And picLoadingBack.Width > 0 Then
            Dim w As Integer = CInt((progressBarCounter / progressBarCounterMax) * picLoadingBack.Width)
            If w > picLoadingBack.Width Then w = picLoadingBack.Width
            picLoadingFore.Width = w
        End If
    End Sub

    '--- PLAY -------------------------------------------------------------------

    Private Sub picStart_Click(sender As Object, e As EventArgs) Handles picStart.Click
        If updating Then Exit Sub
        startGame()
    End Sub

    Private Sub lblPlay_Click(sender As Object, e As EventArgs) Handles lblPlay.Click
        If updating Then Exit Sub
        startGame()
    End Sub

    Private Sub lblPlay_MouseEnter(sender As Object, e As EventArgs) Handles lblPlay.MouseEnter
        picStart.BackColor = Color.FromArgb(190, 36, 42)
    End Sub

    Private Sub lblPlay_MouseLeave(sender As Object, e As EventArgs) Handles lblPlay.MouseLeave
        picStart.BackColor = Color.FromArgb(150, 28, 34)
    End Sub

    Private Sub startGame()
        Dim exePath As String = clientFolder + "\" + clientExe
        If Not File.Exists(myStartupPath + exePath) Then
            Dim alt As String = "system\" + clientExe
            If File.Exists(myStartupPath + alt) Then
                exePath = alt
            Else
                MessageBox.Show("Nao encontrei " + clientFolder + "\" + clientExe + " nesta pasta." + vbCrLf +
                                "Ajuste a variavel clientFolder no topo do frmMain.vb.",
                                "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        Shell(myStartupPath + exePath + " IP=" + gameServerIP, vbNormalFocus)
        End
    End Sub

    '--- REPAIR -----------------------------------------------------------------

    Private Sub picRepair_Click(sender As Object, e As EventArgs) Handles picRepair.Click
        If updating Then Exit Sub

        If checkAddress(versionFileURL) Then
            picStart.Enabled = False
            picRepair.Enabled = False
            lblFileName.Text = ""
            UpdateTimer.Enabled = True
            Call New Action(AddressOf updateFromWeb).BeginInvoke(Nothing, Me)
        Else
            MessageBox.Show("Cannot reach the server!", "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub picRepair_MouseEnter(sender As Object, e As EventArgs) Handles picRepair.MouseEnter
        picRepair.BackColor = Color.FromArgb(210, 208, 202)
    End Sub

    Private Sub picRepair_MouseLeave(sender As Object, e As EventArgs) Handles picRepair.MouseLeave
        picRepair.BackColor = Color.FromArgb(180, 178, 172)
    End Sub

    '--- Links ------------------------------------------------------------------

    Private Sub openURL(url As String)
        If url.Length = 0 Then Exit Sub
        Process.Start(url)
    End Sub

    Private Sub btnDownloads_Click(sender As Object, e As EventArgs) Handles btnDownloads.Click
        openURL(btnDownloadsURL)
    End Sub
    Private Sub btnStreamers_Click(sender As Object, e As EventArgs) Handles btnStreamers.Click
        openURL(btnStreamersURL)
    End Sub
    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        openURL(btnStoreURL)
    End Sub
    Private Sub btnSupport_Click(sender As Object, e As EventArgs) Handles btnSupport.Click
        openURL(btnSupportURL)
    End Sub
    Private Sub btnForum_Click(sender As Object, e As EventArgs) Handles btnForum.Click
        openURL(btnForumURL)
    End Sub

    Private Sub picDiscord_Click(sender As Object, e As EventArgs) Handles picDiscord.Click
        openURL(linkDiscord)
    End Sub
    Private Sub picWhatsApp_Click(sender As Object, e As EventArgs) Handles picWhatsApp.Click
        openURL(linkWhatsApp)
    End Sub
    Private Sub picInstagram_Click(sender As Object, e As EventArgs) Handles picInstagram.Click
        openURL(linkInstagram)
    End Sub
    Private Sub picFacebook_Click(sender As Object, e As EventArgs) Handles picFacebook.Click
        openURL(linkFacebook)
    End Sub
    Private Sub picYouTube_Click(sender As Object, e As EventArgs) Handles picYouTube.Click
        openURL(linkYouTube)
    End Sub

    '--- Janela -----------------------------------------------------------------

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        If updating Then
            Dim result As Integer = MessageBox.Show("Exit while updating?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then Exit Sub
        End If
        End
    End Sub

    Private Sub picClose_MouseEnter(sender As Object, e As EventArgs) Handles picClose.MouseEnter
        picClose.BackColor = Color.FromArgb(220, 60, 60)
    End Sub

    Private Sub picClose_MouseLeave(sender As Object, e As EventArgs) Handles picClose.MouseLeave
        picClose.BackColor = Color.FromArgb(180, 178, 172)
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub picMinimize_MouseEnter(sender As Object, e As EventArgs) Handles picMinimize.MouseEnter
        picMinimize.BackColor = Color.FromArgb(210, 208, 202)
    End Sub

    Private Sub picMinimize_MouseLeave(sender As Object, e As EventArgs) Handles picMinimize.MouseLeave
        picMinimize.BackColor = Color.FromArgb(180, 178, 172)
    End Sub

End Class
