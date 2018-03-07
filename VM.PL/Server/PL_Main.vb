Imports System.Threading
Public Class PL_Main

#Region "Variable Global"
    Dim MenuSelect() As Boolean = {False, False, False, False, False}
    Dim _PSM As Thread
#End Region

#Region "Control Menu"

    Public Sub ProcessSelectMenu()
        Thread.Sleep(30)
        Try
            Dim ArrBox As Integer = 0
            Dim BoxMenu = New PictureBox() {BoxMenu1, BoxMenu2, BoxMenu3, BoxMenu4, BoxMenu5}
            For Each _Item In MenuSelect
                If _Item Then
                    BoxMenu(ArrBox).BackColor = Color.FromArgb(66, 65, 70)
                Else
                    BoxMenu(ArrBox).BackColor = Color.FromArgb(106, 104, 105)
                End If
                ArrBox += 1
            Next
        Catch ex As Exception
            Exit Try
        End Try
        _PSM.Abort()
    End Sub

    Private Sub BoxMenu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxMenu1.Click
        MenuSelect = {True, False, False, False, False}
        _PSM = New Thread(AddressOf ProcessSelectMenu)
        _PSM.Start()
    End Sub

    Private Sub BoxMenu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxMenu2.Click
        MenuSelect = {False, True, False, False, False}
        _PSM = New Thread(AddressOf ProcessSelectMenu)
        _PSM.Start()
        UsC_Monitor1.Visible = True
        FaTab.Visible = True
        OpenForm(PL_Monitor)
    End Sub

    Private Sub BoxMenu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxMenu3.Click
        MenuSelect = {False, False, True, False, False}
        _PSM = New Thread(AddressOf ProcessSelectMenu)
        _PSM.Start()
        UsC_Monitor1.Visible = True
        FaTab.Visible = True
        OpenForm(PL_Config)
    End Sub

    Private Sub BoxMenu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxMenu4.Click
        MenuSelect = {False, False, False, True, False}
        _PSM = New Thread(AddressOf ProcessSelectMenu)
        _PSM.Start()
    End Sub

    Private Sub BoxMenu5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoxMenu5.Click
        MenuSelect = {False, False, False, False, True}
        _PSM = New Thread(AddressOf ProcessSelectMenu)
        _PSM.Start()
        Dim frmBg As New PL_BgMsg()
        frmBg.ShowDialog()
    End Sub

    Private Sub OpenForm(ByVal formToOpen As Form)
        Try
            Dim myForm As New Form()
            Dim formIsOpenning As Boolean = False
            myForm = formToOpen

            If myForm IsNot Nothing Then
                Dim tabTmp As FarsiLibrary.Win.FATabStripItem = Nothing
                For Each tab As FarsiLibrary.Win.FATabStripItem In FaTab.Items
                    If tab.Name = myForm.Text Then ' Check open form
                        FaTab.SelectedItem = tab
                        tabTmp = tab
                        formIsOpenning = True
                        Exit For
                    End If
                Next

                If formIsOpenning = True Then ' Focus form
                    FaTab.SelectedItem = tabTmp
                Else ' New form
                    tabTmp = New FarsiLibrary.Win.FATabStripItem()
                    myForm.TopLevel = False
                    myForm.FormBorderStyle = FormBorderStyle.None
                    myForm.Dock = DockStyle.Fill
                    myForm.Visible = True

                    Dim uc As New UserControl()
                    uc.Dock = DockStyle.Fill
                    uc.Controls.Add(myForm)

                    tabTmp.Controls.Add(uc)
                    tabTmp.CanClose = True
                    tabTmp.Title = myForm.Text
                    tabTmp.Name = myForm.Text
                    tabTmp.Dock = DockStyle.Fill
                    FaTab.AddTab(tabTmp)
                    FaTab.SelectedItem = tabTmp
                End If
            End If
        Catch generatedExceptionName As Exception
            Exit Sub
        End Try
    End Sub

#End Region

End Class