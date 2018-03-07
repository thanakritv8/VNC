<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USC_Menu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USC_Menu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_Lock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(64, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_Lock
        '
        Me.bt_Lock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bt_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Lock.ForeColor = System.Drawing.Color.Transparent
        Me.bt_Lock.Image = CType(resources.GetObject("bt_Lock.Image"), System.Drawing.Image)
        Me.bt_Lock.Location = New System.Drawing.Point(0, 4)
        Me.bt_Lock.Name = "bt_Lock"
        Me.bt_Lock.Size = New System.Drawing.Size(58, 63)
        Me.bt_Lock.TabIndex = 1
        Me.bt_Lock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Lock.UseVisualStyleBackColor = True
        '
        'USC_Monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_Lock)
        Me.Name = "USC_Monitor"
        Me.Size = New System.Drawing.Size(383, 67)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_Lock As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
