Imports VncSharp
Imports VM.BLL
Public Class PL_Monitor

#Region "Variable"
    Private USC_Monitor() As USC_Monitor
    Private DtServer As DataTable
#End Region

#Region "Get Password"
    Dim _Pass As String = String.Empty
    Public Function GetPassword() As String
        Return _Pass
    End Function
#End Region

#Region "New"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load"
    Private Sub PL_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BLL As BLL_Server = New BLL_Server
        DtServer = BLL.GetDataServer
        Config()
    End Sub

    Private Sub Config()
        ReDim USC_Monitor(DtServer.Rows.Count - 1)
        Dim _Col As Integer = 10    'numCol
        Dim _r As Integer = 0   'Row
        Dim _c As Integer = 0   'Col
        For _numPC As Integer = 0 To USC_Monitor.Length - 1

            'New line
            If _r = _Col Then
                _c += 1
                _r = 0
            End If
            'End new line

            USC_Monitor(_numPC) = New USC_Monitor
            With USC_Monitor(_numPC)
                .lbPC.Text = DtServer.Rows(_numPC)("IP")
                .lbPC.Tag = DtServer.Rows(_numPC)("PASS")
                .Name = "PC" & _numPC + 1
                .Location = New Point((_r * .Width) + (5 * (_r + 1)), (_c * .Height) + (5 * (_c + 1)))  'Location in form

                'ConnectRd
                If .rd.IsConnected Then
                    .rd.Disconnect()
                End If
                _Pass = .lbPC.Tag
                .rd.GetPassword = New AuthenticateDelegate(AddressOf GetPassword)
                .rd.Connect(.lbPC.Text)
                If (.rd.IsConnected) Then
                    .rd.SetScalingMode(True)
                    .rd.SetInputMode(True)
                Else
                    .BoxFail.Visible = True
                End If
                'End ConnectRd

            End With
            Me.Controls.Add(USC_Monitor(_numPC))
            _r += 1
        Next
    End Sub
#End Region

End Class