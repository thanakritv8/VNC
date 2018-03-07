<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_Monitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnOFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteToolStripMenuItem, Me.LockToolStripMenuItem, Me.TurnOFFToolStripMenuItem, Me.RestartToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(132, 92)
        '
        'RemoteToolStripMenuItem
        '
        Me.RemoteToolStripMenuItem.Name = "RemoteToolStripMenuItem"
        Me.RemoteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.RemoteToolStripMenuItem.Text = "Remote"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'TurnOFFToolStripMenuItem
        '
        Me.TurnOFFToolStripMenuItem.Name = "TurnOFFToolStripMenuItem"
        Me.TurnOFFToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.TurnOFFToolStripMenuItem.Text = "Shut down"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'PL_Monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(406, 420)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PL_Monitor"
        Me.Text = "PL_Monitor"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOFFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
