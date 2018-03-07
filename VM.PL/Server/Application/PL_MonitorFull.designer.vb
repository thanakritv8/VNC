<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_MonitorFull
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_MonitorFull))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRLALTDELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRLESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CTRLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyClipboardContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClippedViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScaledViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FullScreenRefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rd = New VncSharp.RemoteDesktop()
        Me.PicConnect = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.rd.SuspendLayout()
        CType(Me.PicConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisconnectToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Enabled = False
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendKeysToolStripMenuItem, Me.CopyClipboardContentsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SendKeysToolStripMenuItem
        '
        Me.SendKeysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CTRLALTDELToolStripMenuItem, Me.ALTF4ToolStripMenuItem, Me.CTRLESCToolStripMenuItem, Me.CTRLToolStripMenuItem, Me.ALTToolStripMenuItem})
        Me.SendKeysToolStripMenuItem.Name = "SendKeysToolStripMenuItem"
        Me.SendKeysToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.SendKeysToolStripMenuItem.Text = "Send Keys"
        '
        'CTRLALTDELToolStripMenuItem
        '
        Me.CTRLALTDELToolStripMenuItem.Enabled = False
        Me.CTRLALTDELToolStripMenuItem.Name = "CTRLALTDELToolStripMenuItem"
        Me.CTRLALTDELToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CTRLALTDELToolStripMenuItem.Text = "CTRL + ALT + DEL"
        '
        'ALTF4ToolStripMenuItem
        '
        Me.ALTF4ToolStripMenuItem.Enabled = False
        Me.ALTF4ToolStripMenuItem.Name = "ALTF4ToolStripMenuItem"
        Me.ALTF4ToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ALTF4ToolStripMenuItem.Text = "ALT + F4 (Exit)"
        '
        'CTRLESCToolStripMenuItem
        '
        Me.CTRLESCToolStripMenuItem.Enabled = False
        Me.CTRLESCToolStripMenuItem.Name = "CTRLESCToolStripMenuItem"
        Me.CTRLESCToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CTRLESCToolStripMenuItem.Text = "CTRL + ESC (Start)"
        '
        'CTRLToolStripMenuItem
        '
        Me.CTRLToolStripMenuItem.Enabled = False
        Me.CTRLToolStripMenuItem.Name = "CTRLToolStripMenuItem"
        Me.CTRLToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CTRLToolStripMenuItem.Text = "CTRL"
        '
        'ALTToolStripMenuItem
        '
        Me.ALTToolStripMenuItem.Enabled = False
        Me.ALTToolStripMenuItem.Name = "ALTToolStripMenuItem"
        Me.ALTToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ALTToolStripMenuItem.Text = "ALT"
        '
        'CopyClipboardContentsToolStripMenuItem
        '
        Me.CopyClipboardContentsToolStripMenuItem.Enabled = False
        Me.CopyClipboardContentsToolStripMenuItem.Name = "CopyClipboardContentsToolStripMenuItem"
        Me.CopyClipboardContentsToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CopyClipboardContentsToolStripMenuItem.Text = "Copy local clipboard to host"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClippedViewToolStripMenuItem, Me.ScaledViewToolStripMenuItem, Me.ToolStripMenuItem1, Me.FullScreenRefreshToolStripMenuItem, Me.ViewOnlyToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ClippedViewToolStripMenuItem
        '
        Me.ClippedViewToolStripMenuItem.Checked = True
        Me.ClippedViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClippedViewToolStripMenuItem.Name = "ClippedViewToolStripMenuItem"
        Me.ClippedViewToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClippedViewToolStripMenuItem.Text = "Clipped View"
        '
        'ScaledViewToolStripMenuItem
        '
        Me.ScaledViewToolStripMenuItem.Name = "ScaledViewToolStripMenuItem"
        Me.ScaledViewToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ScaledViewToolStripMenuItem.Text = "Scaled View"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 6)
        '
        'FullScreenRefreshToolStripMenuItem
        '
        Me.FullScreenRefreshToolStripMenuItem.Enabled = False
        Me.FullScreenRefreshToolStripMenuItem.Name = "FullScreenRefreshToolStripMenuItem"
        Me.FullScreenRefreshToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.FullScreenRefreshToolStripMenuItem.Text = "Full Screen Refresh"
        '
        'ViewOnlyToolStripMenuItem
        '
        Me.ViewOnlyToolStripMenuItem.Name = "ViewOnlyToolStripMenuItem"
        Me.ViewOnlyToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ViewOnlyToolStripMenuItem.Text = "View Only"
        '
        'rd
        '
        Me.rd.AutoScroll = True
        Me.rd.AutoScrollMinSize = New System.Drawing.Size(608, 427)
        Me.rd.Controls.Add(Me.PicConnect)
        Me.rd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rd.Location = New System.Drawing.Point(0, 24)
        Me.rd.Name = "rd"
        Me.rd.Size = New System.Drawing.Size(802, 601)
        Me.rd.TabIndex = 1
        '
        'PicConnect
        '
        Me.PicConnect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicConnect.Location = New System.Drawing.Point(0, 0)
        Me.PicConnect.Name = "PicConnect"
        Me.PicConnect.Size = New System.Drawing.Size(802, 574)
        Me.PicConnect.TabIndex = 0
        Me.PicConnect.TabStop = False
        '
        'PL_MonitorFull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 625)
        Me.Controls.Add(Me.rd)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "PL_MonitorFull"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Full Monitor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.rd.ResumeLayout(False)
        CType(Me.PicConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents rd As VncSharp.RemoteDesktop
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendKeysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTRLALTDELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALTF4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTRLESCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CTRLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyClipboardContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClippedViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScaledViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FullScreenRefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicConnect As System.Windows.Forms.PictureBox

End Class
