<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PL_Main))
        Me.PanelMainMenu = New System.Windows.Forms.Panel()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.FaTab = New FarsiLibrary.Win.FATabStrip()
        Me.FaTabStripItem1 = New FarsiLibrary.Win.FATabStripItem()
        Me.FaTabStripItem2 = New FarsiLibrary.Win.FATabStripItem()
        Me.PanelSubMenu = New System.Windows.Forms.Panel()
        Me.BoxMenu5 = New System.Windows.Forms.PictureBox()
        Me.BoxMenu4 = New System.Windows.Forms.PictureBox()
        Me.BoxMenu3 = New System.Windows.Forms.PictureBox()
        Me.BoxMenu2 = New System.Windows.Forms.PictureBox()
        Me.BoxMenu1 = New System.Windows.Forms.PictureBox()
        Me.FaTabStripItem3 = New FarsiLibrary.Win.FATabStripItem()
        Me.UsC_Monitor1 = New VM.PL.USC_Menu()
        Me.PanelMainMenu.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        CType(Me.FaTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenu.SuspendLayout()
        CType(Me.BoxMenu5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMenu4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMainMenu
        '
        Me.PanelMainMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PanelMainMenu.Controls.Add(Me.BoxMenu5)
        Me.PanelMainMenu.Controls.Add(Me.BoxMenu4)
        Me.PanelMainMenu.Controls.Add(Me.BoxMenu3)
        Me.PanelMainMenu.Controls.Add(Me.BoxMenu2)
        Me.PanelMainMenu.Controls.Add(Me.BoxMenu1)
        Me.PanelMainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMainMenu.ForeColor = System.Drawing.Color.Black
        Me.PanelMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMainMenu.Name = "PanelMainMenu"
        Me.PanelMainMenu.Size = New System.Drawing.Size(76, 362)
        Me.PanelMainMenu.TabIndex = 2
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelDetail.Controls.Add(Me.FaTab)
        Me.PanelDetail.Location = New System.Drawing.Point(73, 69)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(551, 293)
        Me.PanelDetail.TabIndex = 3
        '
        'FaTab
        '
        Me.FaTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaTab.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FaTab.Location = New System.Drawing.Point(0, 0)
        Me.FaTab.Name = "FaTab"
        Me.FaTab.SelectedItem = Me.FaTabStripItem3
        Me.FaTab.Size = New System.Drawing.Size(551, 293)
        Me.FaTab.TabIndex = 0
        Me.FaTab.Text = "FaTabStrip1"
        Me.FaTab.Visible = False
        '
        'FaTabStripItem1
        '
        Me.FaTabStripItem1.IsDrawn = True
        Me.FaTabStripItem1.Name = "FaTabStripItem1"
        Me.FaTabStripItem1.Size = New System.Drawing.Size(549, 272)
        Me.FaTabStripItem1.TabIndex = 0
        Me.FaTabStripItem1.Title = "TabStrip Page 1"
        '
        'FaTabStripItem2
        '
        Me.FaTabStripItem2.IsDrawn = True
        Me.FaTabStripItem2.Name = "FaTabStripItem2"
        Me.FaTabStripItem2.Size = New System.Drawing.Size(549, 272)
        Me.FaTabStripItem2.TabIndex = 1
        Me.FaTabStripItem2.Title = "TabStrip Page 2"
        '
        'PanelSubMenu
        '
        Me.PanelSubMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSubMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenu.Controls.Add(Me.UsC_Monitor1)
        Me.PanelSubMenu.Location = New System.Drawing.Point(76, 0)
        Me.PanelSubMenu.Name = "PanelSubMenu"
        Me.PanelSubMenu.Size = New System.Drawing.Size(548, 63)
        Me.PanelSubMenu.TabIndex = 4
        '
        'BoxMenu5
        '
        Me.BoxMenu5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMenu5.Image = Global.VM.PL.My.Resources.Resources.icon_logout1
        Me.BoxMenu5.Location = New System.Drawing.Point(0, 200)
        Me.BoxMenu5.Name = "BoxMenu5"
        Me.BoxMenu5.Size = New System.Drawing.Size(76, 50)
        Me.BoxMenu5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxMenu5.TabIndex = 4
        Me.BoxMenu5.TabStop = False
        '
        'BoxMenu4
        '
        Me.BoxMenu4.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMenu4.Image = Global.VM.PL.My.Resources.Resources.chatIcon
        Me.BoxMenu4.Location = New System.Drawing.Point(0, 150)
        Me.BoxMenu4.Name = "BoxMenu4"
        Me.BoxMenu4.Size = New System.Drawing.Size(76, 50)
        Me.BoxMenu4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxMenu4.TabIndex = 3
        Me.BoxMenu4.TabStop = False
        '
        'BoxMenu3
        '
        Me.BoxMenu3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMenu3.Image = Global.VM.PL.My.Resources.Resources.icon_support
        Me.BoxMenu3.Location = New System.Drawing.Point(0, 100)
        Me.BoxMenu3.Name = "BoxMenu3"
        Me.BoxMenu3.Size = New System.Drawing.Size(76, 50)
        Me.BoxMenu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxMenu3.TabIndex = 2
        Me.BoxMenu3.TabStop = False
        '
        'BoxMenu2
        '
        Me.BoxMenu2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMenu2.Image = Global.VM.PL.My.Resources.Resources.win_icon
        Me.BoxMenu2.Location = New System.Drawing.Point(0, 50)
        Me.BoxMenu2.Name = "BoxMenu2"
        Me.BoxMenu2.Size = New System.Drawing.Size(76, 50)
        Me.BoxMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxMenu2.TabIndex = 1
        Me.BoxMenu2.TabStop = False
        '
        'BoxMenu1
        '
        Me.BoxMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxMenu1.Image = Global.VM.PL.My.Resources.Resources.home_icon
        Me.BoxMenu1.Location = New System.Drawing.Point(0, 0)
        Me.BoxMenu1.Name = "BoxMenu1"
        Me.BoxMenu1.Size = New System.Drawing.Size(76, 50)
        Me.BoxMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxMenu1.TabIndex = 0
        Me.BoxMenu1.TabStop = False
        '
        'FaTabStripItem3
        '
        Me.FaTabStripItem3.IsDrawn = True
        Me.FaTabStripItem3.Name = "FaTabStripItem3"
        Me.FaTabStripItem3.Size = New System.Drawing.Size(549, 272)
        Me.FaTabStripItem3.TabIndex = 0
        Me.FaTabStripItem3.Title = "TabStrip Page 1"
        '
        'UsC_Monitor1
        '
        Me.UsC_Monitor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsC_Monitor1.Location = New System.Drawing.Point(0, 0)
        Me.UsC_Monitor1.Name = "UsC_Monitor1"
        Me.UsC_Monitor1.Size = New System.Drawing.Size(548, 63)
        Me.UsC_Monitor1.TabIndex = 0
        Me.UsC_Monitor1.Visible = False
        '
        'PL_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 362)
        Me.Controls.Add(Me.PanelSubMenu)
        Me.Controls.Add(Me.PanelMainMenu)
        Me.Controls.Add(Me.PanelDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PL_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PL_Monitor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMainMenu.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        CType(Me.FaTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenu.ResumeLayout(False)
        CType(Me.BoxMenu5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMenu4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMainMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents BoxMenu3 As System.Windows.Forms.PictureBox
    Friend WithEvents BoxMenu2 As System.Windows.Forms.PictureBox
    Friend WithEvents BoxMenu1 As System.Windows.Forms.PictureBox
    Friend WithEvents BoxMenu4 As System.Windows.Forms.PictureBox
    Friend WithEvents BoxMenu5 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelSubMenu As System.Windows.Forms.Panel
    Friend WithEvents FaTab As FarsiLibrary.Win.FATabStrip
    Friend WithEvents FaTabStripItem1 As FarsiLibrary.Win.FATabStripItem
    Friend WithEvents FaTabStripItem2 As FarsiLibrary.Win.FATabStripItem
    Friend WithEvents UsC_Monitor1 As VM.PL.USC_Menu
    Friend WithEvents FaTabStripItem3 As FarsiLibrary.Win.FATabStripItem
End Class
