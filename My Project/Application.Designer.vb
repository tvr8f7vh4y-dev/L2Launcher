Imports System
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication
        Inherits WindowsFormsApplicationBase

        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = False
            Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
        End Sub

        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.L2Launcher.frmMain
        End Sub
    End Class
End Namespace
