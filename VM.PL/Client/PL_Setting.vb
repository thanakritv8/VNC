Imports NVNC
Imports System
Imports System.Threading
Public Class PL_Setting

#Region "Variable"
    Dim MachineName As String = Environment.MachineName
#End Region

#Region "Page load"
    Private Sub PL_Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Setting_PL()
    End Sub
#End Region

#Region "Setting form load"
    Private Sub Setting_PL()
        Dim t1 As Thread
        Me.Text = MachineName
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        'Run Thread
        t1 = New Thread(AddressOf IniciarVnc)
        t1.IsBackground = True
        t1.Priority = ThreadPriority.Highest
        t1.Start()
    End Sub
#End Region

#Region "Run server"
    Private Sub IniciarVnc()
        Try
            Dim myVnc As New VncServer("1234", 5900, MachineName)
            myVnc.Start()
        Catch ex As Exception
            Trace.WriteLine(ex.Message)
            Thread.Sleep(1000)
        End Try
    End Sub
#End Region

#Region "Control menu"
    Private Sub Show_Login()
        'Show form login
        Dim dr As DialogResult = New DialogResult()
        Dim PL_Login As PL_Login = New PL_Login()
        dr = PL_Login.ShowDialog()
        dr = DialogResult.OK
        'End form login
        Me.Opacity = 1
        Me.ShowInTaskbar = True
        Me.Show()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingToolStripMenuItem.Click
        Show_Login()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim PL_About As PL_About = New PL_About
        PL_About.Show()
    End Sub

    Private Sub btHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHide.Click
        Me.Hide()
    End Sub

    Private Sub Ni_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Ni.MouseDoubleClick
        Show_Login()
    End Sub

    Private Sub VMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VMToolStripMenuItem.Click
        Dim PL_Remote As PL_Remote = New PL_Remote
        PL_Remote.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
#End Region

End Class
