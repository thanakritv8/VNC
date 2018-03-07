Imports VncSharp
Imports System.Windows.Forms

Public Class PL_MonitorFull
    Dim _Pass As String = String.Empty
    Dim _IP As String = String.Empty
    Public Function GetPassword() As String
        Return _Pass
    End Function

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FlipMenuOptions()
        DisconnectToolStripMenuItem.Enabled = rd.IsConnected
        CTRLALTDELToolStripMenuItem.Enabled = rd.IsConnected
        FullScreenRefreshToolStripMenuItem.Enabled = rd.IsConnected
        ALTF4ToolStripMenuItem.Enabled = rd.IsConnected
        CTRLESCToolStripMenuItem.Enabled = rd.IsConnected
        CTRLToolStripMenuItem.Enabled = rd.IsConnected
        ALTToolStripMenuItem.Enabled = rd.IsConnected
        CopyClipboardContentsToolStripMenuItem.Enabled = rd.IsConnected
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.Disconnect()
        End If
    End Sub

    Private Sub ClippedViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClippedViewToolStripMenuItem.Click
        ClippedViewToolStripMenuItem.Checked = True
        ScaledViewToolStripMenuItem.Checked = False

        ' Turn-off scaling and use clipping
        If (rd.IsConnected) Then
            rd.SetScalingMode(False)
        End If
    End Sub

    Private Sub ScaledViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScaledViewToolStripMenuItem.Click
        ClippedViewToolStripMenuItem.Checked = False
        ScaledViewToolStripMenuItem.Checked = True

        ' Turn-off clipping and use scaling
        If (rd.IsConnected) Then
            rd.SetScalingMode(True)
        End If
    End Sub

    Private Sub FullScreenRefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenRefreshToolStripMenuItem.Click
        ' Request a fullscreen update (normally incremental updates are sent)
        If (rd.IsConnected) Then
            rd.FullScreenUpdate()
        End If
    End Sub

    Private Sub ViewOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOnlyToolStripMenuItem.Click
        ViewOnlyToolStripMenuItem.Checked = Not ViewOnlyToolStripMenuItem.Checked

        ' Turn view-only mode (no mouse/keyboard events sent) on or off
        If (rd.IsConnected) Then
            rd.SetInputMode(ViewOnlyToolStripMenuItem.Checked)
        End If
    End Sub

    Private Sub CopyClipboardContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyClipboardContentsToolStripMenuItem.Click
        ' Copy the contents of the local clipboard into the server's clipboard
        ' so that it can be pasted.  Only works with text.
        If (rd.IsConnected) Then
            rd.FillServerClipboard()

            MessageBox.Show(Me, _
                            "Your clipboard's text was copied to the remote host.", _
                            "Clipboard Copied", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CTRLALTDELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLALTDELToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.SendSpecialKeys(SpecialKeys.CtrlAltDel)
        End If
    End Sub

    Private Sub ALTF4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTF4ToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.SendSpecialKeys(SpecialKeys.AltF4)
        End If
    End Sub

    Private Sub CTRLESCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLESCToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.SendSpecialKeys(SpecialKeys.CtrlEsc)
        End If
    End Sub

    Private Sub CTRLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.SendSpecialKeys(SpecialKeys.Ctrl, False) ' Don't release CTRL
        End If
    End Sub

    Private Sub ALTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALTToolStripMenuItem.Click
        If (rd.IsConnected) Then
            rd.SendSpecialKeys(SpecialKeys.Alt, False) ' Don't release ALT
        End If
    End Sub

    Private Sub VncClientExampleForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' If the user tries to close the window without doing a clean
        ' shutdown of the remote connection, do it for them.
        If (rd.IsConnected) Then
            rd.Disconnect()
        End If
        'PL_Monitor.ConnectRd()
    End Sub

    Private Sub rd_ConnectComplete(ByVal sender As System.Object, ByVal e As VncSharp.ConnectEventArgs) Handles rd.ConnectComplete
        ' Update the Form to match the geometry of remote desktop, including the height of the menu bar.
        ClientSize = New Size(e.DesktopWidth, e.DesktopHeight + MenuStrip.Height)

        ' Change the Form's title to match the remote desktop name
        Text = e.DesktopName

        ' Give the remote desktop focus now that it's connected.
        rd.Focus()
        FlipMenuOptions()
    End Sub

    Private Sub rd_ConnectionLost(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd.ConnectionLost
        ' Let the user know of the lost connection
        ' MessageBox.Show(Me, _
        '                "Lost Connection to Host.", _
        '                "Connection Lost", _
        '                MessageBoxButtons.OK, _
        '                MessageBoxIcon.Information)
        FlipMenuOptions()
    End Sub

    Private Sub rd_ClipboardChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd.ClipboardChanged
        ' You normally wouldn't do this (i.e., you might show something in the status bar),
        ' but as a demo, let the user know that there is new data in the local clipboard
        MessageBox.Show(Me, _
                        "Remote clipboard copied to local host.", _
                        "Clipboard Changed", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
    End Sub

    Private Sub frmMonitorFull_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PicConnect.Visible = True
        Try
            rd.GetPassword = New AuthenticateDelegate(AddressOf GetPassword)
            rd.Connect(_IP)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub _GetPass(ByVal _P As String, ByVal _IPAddress As String)
        _Pass = _P
        _IP = _IPAddress
    End Sub
End Class