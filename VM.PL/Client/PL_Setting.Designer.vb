<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_Setting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ni = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btHide = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password :"
        '
        'Ni
        '
        Me.Ni.ContextMenuStrip = Me.Cms
        Me.Ni.Icon = CType(resources.GetObject("Ni.Icon"), System.Drawing.Icon)
        Me.Ni.Text = "NotifyIcon1"
        Me.Ni.Visible = True
        '
        'Cms
        '
        Me.Cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.VMToolStripMenuItem, Me.AboutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.Cms.Name = "Cms"
        Me.Cms.Size = New System.Drawing.Size(153, 114)
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'VMToolStripMenuItem
        '
        Me.VMToolStripMenuItem.Name = "VMToolStripMenuItem"
        Me.VMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VMToolStripMenuItem.Text = "View Monitor"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btHide
        '
        Me.btHide.BackColor = System.Drawing.Color.LavenderBlush
        Me.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btHide.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHide.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btHide.Location = New System.Drawing.Point(159, 55)
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(75, 33)
        Me.btHide.TabIndex = 1
        Me.btHide.Text = "Hide"
        Me.btHide.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TextBox1.Location = New System.Drawing.Point(159, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 30)
        Me.TextBox1.TabIndex = 2
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.LavenderBlush
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btSave.Location = New System.Drawing.Point(78, 55)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 33)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'PL_Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(311, 106)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btHide)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PL_Server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VM Setting"
        Me.Cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ni As System.Windows.Forms.NotifyIcon
    Friend WithEvents Cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btHide As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btSave As System.Windows.Forms.Button

End Class
