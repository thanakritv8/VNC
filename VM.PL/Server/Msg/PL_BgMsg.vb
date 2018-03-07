Public Class PL_BgMsg

    Private Sub PL_BgMsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frm As New PL_Msg()
        If frm.ShowDialog() = DialogResult.OK Then
            Application.Exit()
        Else
            Me.Close()
        End If
    End Sub
End Class