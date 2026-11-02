<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.picTopBar = New System.Windows.Forms.PictureBox()
        Me.picCardPanel = New System.Windows.Forms.PictureBox()
        Me.picCardImage = New System.Windows.Forms.PictureBox()
        Me.picStart = New System.Windows.Forms.PictureBox()
        Me.picRepair = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.picLoadingBack = New System.Windows.Forms.PictureBox()
        Me.picLoadingFore = New System.Windows.Forms.PictureBox()

        Me.picDiscord = New System.Windows.Forms.PictureBox()
        Me.picWhatsApp = New System.Windows.Forms.PictureBox()
        Me.picInstagram = New System.Windows.Forms.PictureBox()
        Me.picFacebook = New System.Windows.Forms.PictureBox()
        Me.picYouTube = New System.Windows.Forms.PictureBox()

        Me.lblServerName = New System.Windows.Forms.Label()
        Me.lblServerTagline = New System.Windows.Forms.Label()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.lblOnline = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()

        Me.btnDownloads = New System.Windows.Forms.Label()
        Me.btnStreamers = New System.Windows.Forms.Label()
        Me.btnStore = New System.Windows.Forms.Label()
        Me.btnSupport = New System.Windows.Forms.Label()
        Me.btnForum = New System.Windows.Forms.Label()

        Me.MyWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)

        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoadingBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoadingFore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiscord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhatsApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInstagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFacebook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYouTube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'picBackground
        '
        Me.picBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.picBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(1280, 800)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False

        '
        'picTopBar
        '
        Me.picTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.picTopBar.Location = New System.Drawing.Point(140, 34)
        Me.picTopBar.Name = "picTopBar"
        Me.picTopBar.Size = New System.Drawing.Size(502, 34)
        Me.picTopBar.TabIndex = 1
        Me.picTopBar.TabStop = False

        '
        'picCardPanel
        '
        Me.picCardPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.picCardPanel.Location = New System.Drawing.Point(120, 250)
        Me.picCardPanel.Name = "picCardPanel"
        Me.picCardPanel.Size = New System.Drawing.Size(235, 310)
        Me.picCardPanel.TabIndex = 2
        Me.picCardPanel.TabStop = False

        '
        'picCardImage
        '
        Me.picCardImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.picCardImage.Location = New System.Drawing.Point(139, 276)
        Me.picCardImage.Name = "picCardImage"
        Me.picCardImage.Size = New System.Drawing.Size(197, 175)
        Me.picCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCardImage.TabIndex = 3
        Me.picCardImage.TabStop = False

        '
        'lblOnline
        '
        Me.lblOnline.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblOnline.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblOnline.ForeColor = System.Drawing.Color.Black
        Me.lblOnline.Location = New System.Drawing.Point(139, 260)
        Me.lblOnline.Name = "lblOnline"
        Me.lblOnline.Size = New System.Drawing.Size(62, 16)
        Me.lblOnline.TabIndex = 4
        Me.lblOnline.Text = "ONLINE"
        Me.lblOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'lblServerName
        '
        Me.lblServerName.BackColor = System.Drawing.Color.Transparent
        Me.lblServerName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblServerName.ForeColor = System.Drawing.Color.White
        Me.lblServerName.Location = New System.Drawing.Point(120, 458)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(235, 26)
        Me.lblServerName.TabIndex = 5
        Me.lblServerName.Text = "SERVER"
        Me.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'lblPlayers
        '
        Me.lblPlayers.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayers.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPlayers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblPlayers.Location = New System.Drawing.Point(120, 484)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(235, 20)
        Me.lblPlayers.TabIndex = 6
        Me.lblPlayers.Text = "- player(s)"
        Me.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'lblServerTagline
        '
        Me.lblServerTagline.BackColor = System.Drawing.Color.Transparent
        Me.lblServerTagline.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblServerTagline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lblServerTagline.Location = New System.Drawing.Point(120, 524)
        Me.lblServerTagline.Name = "lblServerTagline"
        Me.lblServerTagline.Size = New System.Drawing.Size(235, 20)
        Me.lblServerTagline.TabIndex = 7
        Me.lblServerTagline.Text = "-"
        Me.lblServerTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Botoes do topo
        '
        Me.btnDownloads.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloads.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDownloads.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnDownloads.Location = New System.Drawing.Point(150, 40)
        Me.btnDownloads.Name = "btnDownloads"
        Me.btnDownloads.Size = New System.Drawing.Size(100, 24)
        Me.btnDownloads.TabIndex = 10
        Me.btnDownloads.Text = "DOWNLOADS"
        Me.btnDownloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDownloads.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnStreamers.BackColor = System.Drawing.Color.Transparent
        Me.btnStreamers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStreamers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnStreamers.Location = New System.Drawing.Point(258, 40)
        Me.btnStreamers.Name = "btnStreamers"
        Me.btnStreamers.Size = New System.Drawing.Size(100, 24)
        Me.btnStreamers.TabIndex = 11
        Me.btnStreamers.Text = "STREAMERS"
        Me.btnStreamers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnStreamers.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnStore.BackColor = System.Drawing.Color.Transparent
        Me.btnStore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnStore.Location = New System.Drawing.Point(366, 40)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(80, 24)
        Me.btnStore.TabIndex = 12
        Me.btnStore.Text = "STORE"
        Me.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnStore.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnSupport.BackColor = System.Drawing.Color.Transparent
        Me.btnSupport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSupport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnSupport.Location = New System.Drawing.Point(454, 40)
        Me.btnSupport.Name = "btnSupport"
        Me.btnSupport.Size = New System.Drawing.Size(90, 24)
        Me.btnSupport.TabIndex = 13
        Me.btnSupport.Text = "SUPPORT"
        Me.btnSupport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSupport.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnForum.BackColor = System.Drawing.Color.Transparent
        Me.btnForum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnForum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnForum.Location = New System.Drawing.Point(552, 40)
        Me.btnForum.Name = "btnForum"
        Me.btnForum.Size = New System.Drawing.Size(80, 24)
        Me.btnForum.TabIndex = 14
        Me.btnForum.Text = "FORUM"
        Me.btnForum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnForum.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'MyWebBrowser
        '
        Me.MyWebBrowser.Location = New System.Drawing.Point(700, 120)
        Me.MyWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MyWebBrowser.Name = "MyWebBrowser"
        Me.MyWebBrowser.ScriptErrorsSuppressed = True
        Me.MyWebBrowser.ScrollBarsEnabled = False
        Me.MyWebBrowser.Size = New System.Drawing.Size(480, 380)
        Me.MyWebBrowser.TabIndex = 20
        Me.MyWebBrowser.Visible = False

        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(70, 640)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(700, 24)
        Me.lblStatus.TabIndex = 30
        Me.lblStatus.Text = "Verificando atualizacoes..."

        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblFileName.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblFileName.Location = New System.Drawing.Point(70, 668)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(700, 18)
        Me.lblFileName.TabIndex = 31

        '
        'picRepair
        '
        Me.picRepair.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.picRepair.Location = New System.Drawing.Point(70, 692)
        Me.picRepair.Name = "picRepair"
        Me.picRepair.Size = New System.Drawing.Size(28, 28)
        Me.picRepair.TabIndex = 32
        Me.picRepair.TabStop = False
        Me.picRepair.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(70, 730)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(260, 20)
        Me.lblVersion.TabIndex = 33
        Me.lblVersion.Text = "Version: -"

        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(900, 730)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(340, 20)
        Me.lblCopyright.TabIndex = 34
        Me.lblCopyright.Text = "Copyrights 2026"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        '
        'picStart (PLAY)
        '
        Me.picStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.picStart.Location = New System.Drawing.Point(920, 610)
        Me.picStart.Name = "picStart"
        Me.picStart.Size = New System.Drawing.Size(200, 62)
        Me.picStart.TabIndex = 40
        Me.picStart.TabStop = False
        Me.picStart.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'lblPlay
        '
        Me.lblPlay.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlay.ForeColor = System.Drawing.Color.White
        Me.lblPlay.Location = New System.Drawing.Point(920, 610)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(200, 62)
        Me.lblPlay.TabIndex = 41
        Me.lblPlay.Text = "PLAY"
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'Barra de progresso
        '
        Me.picLoadingBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.picLoadingBack.Location = New System.Drawing.Point(920, 686)
        Me.picLoadingBack.Name = "picLoadingBack"
        Me.picLoadingBack.Size = New System.Drawing.Size(200, 6)
        Me.picLoadingBack.TabIndex = 50
        Me.picLoadingBack.TabStop = False

        Me.picLoadingFore.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.picLoadingFore.Location = New System.Drawing.Point(920, 686)
        Me.picLoadingFore.Name = "picLoadingFore"
        Me.picLoadingFore.Size = New System.Drawing.Size(0, 6)
        Me.picLoadingFore.TabIndex = 51
        Me.picLoadingFore.TabStop = False

        '
        'Icones de redes sociais
        '
        Me.picDiscord.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.picDiscord.Location = New System.Drawing.Point(70, 762)
        Me.picDiscord.Name = "picDiscord"
        Me.picDiscord.Size = New System.Drawing.Size(30, 30)
        Me.picDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDiscord.TabIndex = 60
        Me.picDiscord.TabStop = False
        Me.picDiscord.Cursor = System.Windows.Forms.Cursors.Hand

        Me.picWhatsApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.picWhatsApp.Location = New System.Drawing.Point(110, 762)
        Me.picWhatsApp.Name = "picWhatsApp"
        Me.picWhatsApp.Size = New System.Drawing.Size(30, 30)
        Me.picWhatsApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWhatsApp.TabIndex = 61
        Me.picWhatsApp.TabStop = False
        Me.picWhatsApp.Cursor = System.Windows.Forms.Cursors.Hand

        Me.picInstagram.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.picInstagram.Location = New System.Drawing.Point(150, 762)
        Me.picInstagram.Name = "picInstagram"
        Me.picInstagram.Size = New System.Drawing.Size(30, 30)
        Me.picInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInstagram.TabIndex = 62
        Me.picInstagram.TabStop = False
        Me.picInstagram.Cursor = System.Windows.Forms.Cursors.Hand

        Me.picFacebook.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.picFacebook.Location = New System.Drawing.Point(190, 762)
        Me.picFacebook.Name = "picFacebook"
        Me.picFacebook.Size = New System.Drawing.Size(30, 30)
        Me.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFacebook.TabIndex = 63
        Me.picFacebook.TabStop = False
        Me.picFacebook.Cursor = System.Windows.Forms.Cursors.Hand

        Me.picYouTube.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.picYouTube.Location = New System.Drawing.Point(230, 762)
        Me.picYouTube.Name = "picYouTube"
        Me.picYouTube.Size = New System.Drawing.Size(30, 30)
        Me.picYouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picYouTube.TabIndex = 64
        Me.picYouTube.TabStop = False
        Me.picYouTube.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'picMinimize
        '
        Me.picMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.picMinimize.Location = New System.Drawing.Point(1210, 16)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(20, 20)
        Me.picMinimize.TabIndex = 70
        Me.picMinimize.TabStop = False
        Me.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'picClose
        '
        Me.picClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.picClose.Location = New System.Drawing.Point(1240, 16)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 71
        Me.picClose.TabStop = False
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand

        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 500

        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 800)
        Me.Controls.Add(Me.MyWebBrowser)
        Me.Controls.Add(Me.lblOnline)
        Me.Controls.Add(Me.picCardImage)
        Me.Controls.Add(Me.picCardPanel)
        Me.Controls.Add(Me.lblServerName)
        Me.Controls.Add(Me.lblPlayers)
        Me.Controls.Add(Me.lblServerTagline)
        Me.Controls.Add(Me.picTopBar)
        Me.Controls.Add(Me.btnDownloads)
        Me.Controls.Add(Me.btnStreamers)
        Me.Controls.Add(Me.btnStore)
        Me.Controls.Add(Me.btnSupport)
        Me.Controls.Add(Me.btnForum)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.picRepair)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.picDiscord)
        Me.Controls.Add(Me.picWhatsApp)
        Me.Controls.Add(Me.picInstagram)
        Me.Controls.Add(Me.picFacebook)
        Me.Controls.Add(Me.picYouTube)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.picMinimize)
        Me.Controls.Add(Me.picStart)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.picLoadingFore)
        Me.Controls.Add(Me.picLoadingBack)
        Me.Controls.Add(Me.picBackground)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "L2 Launcher"

        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRepair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoadingBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoadingFore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiscord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhatsApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInstagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFacebook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYouTube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents picTopBar As PictureBox
    Friend WithEvents picCardPanel As PictureBox
    Friend WithEvents picCardImage As PictureBox
    Friend WithEvents picStart As PictureBox
    Friend WithEvents picRepair As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picLoadingBack As PictureBox
    Friend WithEvents picLoadingFore As PictureBox
    Friend WithEvents picDiscord As PictureBox
    Friend WithEvents picWhatsApp As PictureBox
    Friend WithEvents picInstagram As PictureBox
    Friend WithEvents picFacebook As PictureBox
    Friend WithEvents picYouTube As PictureBox
    Friend WithEvents lblServerName As Label
    Friend WithEvents lblServerTagline As Label
    Friend WithEvents lblPlayers As Label
    Friend WithEvents lblOnline As Label
    Friend WithEvents lblPlay As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents btnDownloads As Label
    Friend WithEvents btnStreamers As Label
    Friend WithEvents btnStore As Label
    Friend WithEvents btnSupport As Label
    Friend WithEvents btnForum As Label
    Friend WithEvents MyWebBrowser As WebBrowser
    Friend WithEvents UpdateTimer As Timer
End Class
