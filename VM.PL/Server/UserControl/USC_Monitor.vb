Imports System.Threading
Public Class USC_Monitor
    Private Sub RemoteDesktop1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles rd.DoubleClick
        If (rd.IsConnected) Then
            rd.Disconnect()
        End If
        Dim frm As PL_MonitorFull = New PL_MonitorFull
        frm._GetPass(lbPC.Tag, lbPC.Text)
        frm.Show()
        Thread.Sleep(5000)
        frm.PicConnect.Visible = False
    End Sub
End Class
