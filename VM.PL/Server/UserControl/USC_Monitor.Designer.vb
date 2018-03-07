<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USC_Monitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USC_Monitor))
        Me.rd = New VncSharp.RemoteDesktop()
        Me.BoxFail = New System.Windows.Forms.PictureBox()
        Me.lbPC = New System.Windows.Forms.Label()
        Me.rd.SuspendLayout()
        CType(Me.BoxFail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rd
        '
        Me.rd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rd.AutoScroll = True
        Me.rd.AutoScrollMinSize = New System.Drawing.Size(608, 427)
        Me.rd.Controls.Add(Me.BoxFail)
        Me.rd.Location = New System.Drawing.Point(0, 0)
        Me.rd.Name = "rd"
        Me.rd.Size = New System.Drawing.Size(180, 160)
        Me.rd.TabIndex = 0
        '
        'BoxFail
        '
        Me.BoxFail.Cursor = System.Windows.Forms.Cursors.Default
        Me.BoxFail.Image = CType(resources.GetObject("BoxFail.Image"), System.Drawing.Image)
        Me.BoxFail.Location = New System.Drawing.Point(0, 0)
        Me.BoxFail.Name = "BoxFail"
        Me.BoxFail.Size = New System.Drawing.Size(180, 160)
        Me.BoxFail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BoxFail.TabIndex = 0
        Me.BoxFail.TabStop = False
        Me.BoxFail.Visible = False
        '
        'lbPC
        '
        Me.lbPC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPC.AutoSize = True
        Me.lbPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPC.ForeColor = System.Drawing.Color.White
        Me.lbPC.Location = New System.Drawing.Point(41, 164)
        Me.lbPC.Name = "lbPC"
        Me.lbPC.Size = New System.Drawing.Size(52, 16)
        Me.lbPC.TabIndex = 1
        Me.lbPC.Text = "0.0.0.0"
        Me.lbPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'USC_Monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.lbPC)
        Me.Controls.Add(Me.rd)
        Me.Name = "USC_Monitor"
        Me.Size = New System.Drawing.Size(180, 180)
        Me.rd.ResumeLayout(False)
        CType(Me.BoxFail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rd As VncSharp.RemoteDesktop
    Friend WithEvents lbPC As System.Windows.Forms.Label
    Friend WithEvents BoxFail As System.Windows.Forms.PictureBox

End Class
