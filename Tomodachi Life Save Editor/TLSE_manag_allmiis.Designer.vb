﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TLSE_manag_allmiis
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TLSE_manag_allmiis))
        Me.TLSE_header = New System.Windows.Forms.Panel()
        Me.TLSE_filepath = New System.Windows.Forms.TextBox()
        Me.Select_language = New System.Windows.Forms.ComboBox()
        Me.Panel_bspesymb = New System.Windows.Forms.Panel()
        Me.Setting_spesymb = New System.Windows.Forms.CheckBox()
        Me.Icon_bspesymb = New System.Windows.Forms.PictureBox()
        Me.Panel_Advhelp = New System.Windows.Forms.Panel()
        Me.Setting_Advhelp = New System.Windows.Forms.CheckBox()
        Me.Icon_Advhelp = New System.Windows.Forms.PictureBox()
        Me.Panel_chkupdate = New System.Windows.Forms.Panel()
        Me.Setting_ckupdate = New System.Windows.Forms.CheckBox()
        Me.Icon_chkupdate = New System.Windows.Forms.PictureBox()
        Me.Panel_filepath = New System.Windows.Forms.Panel()
        Me.Setting_filepath = New System.Windows.Forms.CheckBox()
        Me.Icon_filepath = New System.Windows.Forms.PictureBox()
        Me.Panel_hiddenthings = New System.Windows.Forms.Panel()
        Me.Setting_hidden = New System.Windows.Forms.CheckBox()
        Me.Icon_hiddenthings = New System.Windows.Forms.PictureBox()
        Me.Panel_bgmusic = New System.Windows.Forms.Panel()
        Me.Select_music = New System.Windows.Forms.ComboBox()
        Me.Setting_music = New System.Windows.Forms.CheckBox()
        Me.Icon_bgmusic = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Filever_text = New System.Windows.Forms.Label()
        Me.Title_filever = New System.Windows.Forms.Label()
        Me.Panel_menu_opensave = New System.Windows.Forms.Panel()
        Me.Text_menu_save = New System.Windows.Forms.Label()
        Me.Text_menu_open = New System.Windows.Forms.Label()
        Me.Minimizebutton = New System.Windows.Forms.PictureBox()
        Me.TLSE_title = New System.Windows.Forms.PictureBox()
        Me.Closebutton = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo_update = New System.Windows.Forms.PictureBox()
        Me.TLSE_logo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Icon_menu = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Menuflow_ext_miimanagement = New System.Windows.Forms.Panel()
        Me.Menu_text_ext_miimanagement = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Menu_text_ext_extract = New System.Windows.Forms.Label()
        Me.Title_extract = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Text_extract = New System.Windows.Forms.Label()
        Me.Text_extract_allMii = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Text_restore = New System.Windows.Forms.Label()
        Me.Text_restore_allMii = New System.Windows.Forms.TextBox()
        Me.Title_restore = New System.Windows.Forms.Label()
        Me.valu_lastmii = New System.Windows.Forms.NumericUpDown()
        Me.Icon_miidetected = New System.Windows.Forms.PictureBox()
        Me.Text_miidetected = New System.Windows.Forms.Label()
        Me.TLSE_header.SuspendLayout()
        Me.Panel_bspesymb.SuspendLayout()
        CType(Me.Icon_bspesymb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Advhelp.SuspendLayout()
        CType(Me.Icon_Advhelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_chkupdate.SuspendLayout()
        CType(Me.Icon_chkupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_filepath.SuspendLayout()
        CType(Me.Icon_filepath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hiddenthings.SuspendLayout()
        CType(Me.Icon_hiddenthings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_bgmusic.SuspendLayout()
        CType(Me.Icon_bgmusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel_menu_opensave.SuspendLayout()
        CType(Me.Minimizebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menuflow_ext_miimanagement.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.valu_lastmii, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_miidetected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TLSE_header
        '
        Me.TLSE_header.BackColor = System.Drawing.Color.White
        Me.TLSE_header.Controls.Add(Me.TLSE_filepath)
        Me.TLSE_header.Controls.Add(Me.Select_language)
        Me.TLSE_header.Controls.Add(Me.Panel_bspesymb)
        Me.TLSE_header.Controls.Add(Me.Panel_Advhelp)
        Me.TLSE_header.Controls.Add(Me.Panel_chkupdate)
        Me.TLSE_header.Controls.Add(Me.Panel_filepath)
        Me.TLSE_header.Controls.Add(Me.Panel_hiddenthings)
        Me.TLSE_header.Controls.Add(Me.Panel_bgmusic)
        Me.TLSE_header.Controls.Add(Me.Panel2)
        Me.TLSE_header.Controls.Add(Me.Panel_menu_opensave)
        Me.TLSE_header.Controls.Add(Me.Minimizebutton)
        Me.TLSE_header.Controls.Add(Me.TLSE_title)
        Me.TLSE_header.Controls.Add(Me.Closebutton)
        Me.TLSE_header.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.TLSE_header.Location = New System.Drawing.Point(150, 0)
        Me.TLSE_header.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLSE_header.Name = "TLSE_header"
        Me.TLSE_header.Size = New System.Drawing.Size(650, 75)
        Me.TLSE_header.TabIndex = 41
        '
        'TLSE_filepath
        '
        Me.TLSE_filepath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLSE_filepath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TLSE_filepath.Location = New System.Drawing.Point(440, 57)
        Me.TLSE_filepath.Name = "TLSE_filepath"
        Me.TLSE_filepath.ReadOnly = True
        Me.TLSE_filepath.Size = New System.Drawing.Size(233, 13)
        Me.TLSE_filepath.TabIndex = 18
        Me.TLSE_filepath.Visible = False
        '
        'Select_language
        '
        Me.Select_language.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Select_language.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_language.FormattingEnabled = True
        Me.Select_language.Items.AddRange(New Object() {"ENG", "FRA"})
        Me.Select_language.Location = New System.Drawing.Point(440, 40)
        Me.Select_language.Name = "Select_language"
        Me.Select_language.Size = New System.Drawing.Size(51, 21)
        Me.Select_language.TabIndex = 17
        Me.Select_language.Visible = False
        '
        'Panel_bspesymb
        '
        Me.Panel_bspesymb.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_bspesymb.Controls.Add(Me.Setting_spesymb)
        Me.Panel_bspesymb.Controls.Add(Me.Icon_bspesymb)
        Me.Panel_bspesymb.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_bspesymb.Location = New System.Drawing.Point(401, 38)
        Me.Panel_bspesymb.Name = "Panel_bspesymb"
        Me.Panel_bspesymb.Size = New System.Drawing.Size(34, 34)
        Me.Panel_bspesymb.TabIndex = 15
        Me.Panel_bspesymb.Visible = False
        '
        'Setting_spesymb
        '
        Me.Setting_spesymb.AutoSize = True
        Me.Setting_spesymb.Location = New System.Drawing.Point(0, 20)
        Me.Setting_spesymb.Name = "Setting_spesymb"
        Me.Setting_spesymb.Size = New System.Drawing.Size(15, 14)
        Me.Setting_spesymb.TabIndex = 6
        Me.Setting_spesymb.UseVisualStyleBackColor = True
        Me.Setting_spesymb.Visible = False
        '
        'Icon_bspesymb
        '
        Me.Icon_bspesymb.BackColor = System.Drawing.Color.Transparent
        Me.Icon_bspesymb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_bspesymb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_bspesymb.Enabled = False
        Me.Icon_bspesymb.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bsymb
        Me.Icon_bspesymb.Location = New System.Drawing.Point(0, 0)
        Me.Icon_bspesymb.Name = "Icon_bspesymb"
        Me.Icon_bspesymb.Size = New System.Drawing.Size(34, 34)
        Me.Icon_bspesymb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_bspesymb.TabIndex = 2
        Me.Icon_bspesymb.TabStop = False
        '
        'Panel_Advhelp
        '
        Me.Panel_Advhelp.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_Advhelp.Controls.Add(Me.Setting_Advhelp)
        Me.Panel_Advhelp.Controls.Add(Me.Icon_Advhelp)
        Me.Panel_Advhelp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_Advhelp.Location = New System.Drawing.Point(364, 38)
        Me.Panel_Advhelp.Name = "Panel_Advhelp"
        Me.Panel_Advhelp.Size = New System.Drawing.Size(34, 34)
        Me.Panel_Advhelp.TabIndex = 14
        Me.Panel_Advhelp.Visible = False
        '
        'Setting_Advhelp
        '
        Me.Setting_Advhelp.AutoSize = True
        Me.Setting_Advhelp.Location = New System.Drawing.Point(0, 20)
        Me.Setting_Advhelp.Name = "Setting_Advhelp"
        Me.Setting_Advhelp.Size = New System.Drawing.Size(15, 14)
        Me.Setting_Advhelp.TabIndex = 6
        Me.Setting_Advhelp.UseVisualStyleBackColor = True
        Me.Setting_Advhelp.Visible = False
        '
        'Icon_Advhelp
        '
        Me.Icon_Advhelp.BackColor = System.Drawing.Color.Transparent
        Me.Icon_Advhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_Advhelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_Advhelp.Enabled = False
        Me.Icon_Advhelp.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_badvh
        Me.Icon_Advhelp.Location = New System.Drawing.Point(0, 0)
        Me.Icon_Advhelp.Name = "Icon_Advhelp"
        Me.Icon_Advhelp.Size = New System.Drawing.Size(34, 34)
        Me.Icon_Advhelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_Advhelp.TabIndex = 2
        Me.Icon_Advhelp.TabStop = False
        '
        'Panel_chkupdate
        '
        Me.Panel_chkupdate.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_chkupdate.Controls.Add(Me.Setting_ckupdate)
        Me.Panel_chkupdate.Controls.Add(Me.Icon_chkupdate)
        Me.Panel_chkupdate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_chkupdate.Location = New System.Drawing.Point(327, 38)
        Me.Panel_chkupdate.Name = "Panel_chkupdate"
        Me.Panel_chkupdate.Size = New System.Drawing.Size(34, 34)
        Me.Panel_chkupdate.TabIndex = 13
        Me.Panel_chkupdate.Visible = False
        '
        'Setting_ckupdate
        '
        Me.Setting_ckupdate.AutoSize = True
        Me.Setting_ckupdate.Location = New System.Drawing.Point(0, 20)
        Me.Setting_ckupdate.Name = "Setting_ckupdate"
        Me.Setting_ckupdate.Size = New System.Drawing.Size(15, 14)
        Me.Setting_ckupdate.TabIndex = 6
        Me.Setting_ckupdate.UseVisualStyleBackColor = True
        Me.Setting_ckupdate.Visible = False
        '
        'Icon_chkupdate
        '
        Me.Icon_chkupdate.AccessibleDescription = ""
        Me.Icon_chkupdate.AccessibleName = ""
        Me.Icon_chkupdate.BackColor = System.Drawing.Color.Transparent
        Me.Icon_chkupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_chkupdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_chkupdate.Enabled = False
        Me.Icon_chkupdate.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bnoupdate
        Me.Icon_chkupdate.Location = New System.Drawing.Point(0, 0)
        Me.Icon_chkupdate.Name = "Icon_chkupdate"
        Me.Icon_chkupdate.Size = New System.Drawing.Size(34, 34)
        Me.Icon_chkupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_chkupdate.TabIndex = 2
        Me.Icon_chkupdate.TabStop = False
        '
        'Panel_filepath
        '
        Me.Panel_filepath.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_filepath.Controls.Add(Me.Setting_filepath)
        Me.Panel_filepath.Controls.Add(Me.Icon_filepath)
        Me.Panel_filepath.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_filepath.Location = New System.Drawing.Point(290, 38)
        Me.Panel_filepath.Name = "Panel_filepath"
        Me.Panel_filepath.Size = New System.Drawing.Size(34, 34)
        Me.Panel_filepath.TabIndex = 12
        Me.Panel_filepath.Visible = False
        '
        'Setting_filepath
        '
        Me.Setting_filepath.AutoSize = True
        Me.Setting_filepath.Location = New System.Drawing.Point(0, 20)
        Me.Setting_filepath.Name = "Setting_filepath"
        Me.Setting_filepath.Size = New System.Drawing.Size(15, 14)
        Me.Setting_filepath.TabIndex = 6
        Me.Setting_filepath.UseVisualStyleBackColor = True
        Me.Setting_filepath.Visible = False
        '
        'Icon_filepath
        '
        Me.Icon_filepath.BackColor = System.Drawing.Color.Transparent
        Me.Icon_filepath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_filepath.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon_filepath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_filepath.Enabled = False
        Me.Icon_filepath.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bfilepath
        Me.Icon_filepath.Location = New System.Drawing.Point(0, 0)
        Me.Icon_filepath.Name = "Icon_filepath"
        Me.Icon_filepath.Size = New System.Drawing.Size(34, 34)
        Me.Icon_filepath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_filepath.TabIndex = 2
        Me.Icon_filepath.TabStop = False
        '
        'Panel_hiddenthings
        '
        Me.Panel_hiddenthings.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_hiddenthings.Controls.Add(Me.Setting_hidden)
        Me.Panel_hiddenthings.Controls.Add(Me.Icon_hiddenthings)
        Me.Panel_hiddenthings.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_hiddenthings.Location = New System.Drawing.Point(253, 38)
        Me.Panel_hiddenthings.Name = "Panel_hiddenthings"
        Me.Panel_hiddenthings.Size = New System.Drawing.Size(34, 34)
        Me.Panel_hiddenthings.TabIndex = 11
        Me.Panel_hiddenthings.Visible = False
        '
        'Setting_hidden
        '
        Me.Setting_hidden.AutoSize = True
        Me.Setting_hidden.Location = New System.Drawing.Point(0, 20)
        Me.Setting_hidden.Name = "Setting_hidden"
        Me.Setting_hidden.Size = New System.Drawing.Size(15, 14)
        Me.Setting_hidden.TabIndex = 6
        Me.Setting_hidden.UseVisualStyleBackColor = True
        Me.Setting_hidden.Visible = False
        '
        'Icon_hiddenthings
        '
        Me.Icon_hiddenthings.BackColor = System.Drawing.Color.Transparent
        Me.Icon_hiddenthings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_hiddenthings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_hiddenthings.Enabled = False
        Me.Icon_hiddenthings.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bhidden
        Me.Icon_hiddenthings.Location = New System.Drawing.Point(0, 0)
        Me.Icon_hiddenthings.Name = "Icon_hiddenthings"
        Me.Icon_hiddenthings.Size = New System.Drawing.Size(34, 34)
        Me.Icon_hiddenthings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_hiddenthings.TabIndex = 2
        Me.Icon_hiddenthings.TabStop = False
        '
        'Panel_bgmusic
        '
        Me.Panel_bgmusic.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_single
        Me.Panel_bgmusic.Controls.Add(Me.Select_music)
        Me.Panel_bgmusic.Controls.Add(Me.Setting_music)
        Me.Panel_bgmusic.Controls.Add(Me.Icon_bgmusic)
        Me.Panel_bgmusic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel_bgmusic.Location = New System.Drawing.Point(216, 38)
        Me.Panel_bgmusic.Name = "Panel_bgmusic"
        Me.Panel_bgmusic.Size = New System.Drawing.Size(34, 34)
        Me.Panel_bgmusic.TabIndex = 10
        Me.Panel_bgmusic.Visible = False
        '
        'Select_music
        '
        Me.Select_music.BackColor = System.Drawing.Color.White
        Me.Select_music.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_music.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Select_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Select_music.FormattingEnabled = True
        Me.Select_music.Items.AddRange(New Object() {"1", "2", "3"})
        Me.Select_music.Location = New System.Drawing.Point(2, 11)
        Me.Select_music.Name = "Select_music"
        Me.Select_music.Size = New System.Drawing.Size(31, 21)
        Me.Select_music.TabIndex = 17
        Me.Select_music.Visible = False
        '
        'Setting_music
        '
        Me.Setting_music.AutoSize = True
        Me.Setting_music.Location = New System.Drawing.Point(0, 0)
        Me.Setting_music.Name = "Setting_music"
        Me.Setting_music.Size = New System.Drawing.Size(15, 14)
        Me.Setting_music.TabIndex = 16
        Me.Setting_music.UseVisualStyleBackColor = True
        Me.Setting_music.Visible = False
        '
        'Icon_bgmusic
        '
        Me.Icon_bgmusic.BackColor = System.Drawing.Color.Transparent
        Me.Icon_bgmusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_bgmusic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Icon_bgmusic.Enabled = False
        Me.Icon_bgmusic.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_bgmusic
        Me.Icon_bgmusic.Location = New System.Drawing.Point(0, 0)
        Me.Icon_bgmusic.Name = "Icon_bgmusic"
        Me.Icon_bgmusic.Size = New System.Drawing.Size(34, 34)
        Me.Icon_bgmusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_bgmusic.TabIndex = 2
        Me.Icon_bgmusic.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_largex4
        Me.Panel2.Controls.Add(Me.Filever_text)
        Me.Panel2.Controls.Add(Me.Title_filever)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Panel2.Location = New System.Drawing.Point(78, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 34)
        Me.Panel2.TabIndex = 9
        '
        'Filever_text
        '
        Me.Filever_text.BackColor = System.Drawing.Color.Transparent
        Me.Filever_text.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Filever_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filever_text.Location = New System.Drawing.Point(101, 0)
        Me.Filever_text.Name = "Filever_text"
        Me.Filever_text.Size = New System.Drawing.Size(34, 34)
        Me.Filever_text.TabIndex = 1
        Me.Filever_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title_filever
        '
        Me.Title_filever.BackColor = System.Drawing.Color.Transparent
        Me.Title_filever.Cursor = System.Windows.Forms.Cursors.Default
        Me.Title_filever.Location = New System.Drawing.Point(3, 0)
        Me.Title_filever.Name = "Title_filever"
        Me.Title_filever.Size = New System.Drawing.Size(100, 34)
        Me.Title_filever.TabIndex = 0
        Me.Title_filever.Text = "Save file region :"
        Me.Title_filever.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_menu_opensave
        '
        Me.Panel_menu_opensave.BackColor = System.Drawing.Color.Transparent
        Me.Panel_menu_opensave.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.buttontop_largex2
        Me.Panel_menu_opensave.Controls.Add(Me.Text_menu_save)
        Me.Panel_menu_opensave.Controls.Add(Me.Text_menu_open)
        Me.Panel_menu_opensave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_menu_opensave.Location = New System.Drawing.Point(6, 38)
        Me.Panel_menu_opensave.Name = "Panel_menu_opensave"
        Me.Panel_menu_opensave.Size = New System.Drawing.Size(69, 34)
        Me.Panel_menu_opensave.TabIndex = 8
        Me.Panel_menu_opensave.Visible = False
        '
        'Text_menu_save
        '
        Me.Text_menu_save.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Text_menu_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Text_menu_save.ImageKey = "icon_menusave.png"
        Me.Text_menu_save.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_save.Name = "Text_menu_save"
        Me.Text_menu_save.Size = New System.Drawing.Size(69, 34)
        Me.Text_menu_save.TabIndex = 3
        Me.Text_menu_save.Text = "Save"
        Me.Text_menu_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_menu_open
        '
        Me.Text_menu_open.BackColor = System.Drawing.Color.Transparent
        Me.Text_menu_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Text_menu_open.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Text_menu_open.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_menu_open.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Text_menu_open.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Text_menu_open.ImageKey = "icon_menusave.png"
        Me.Text_menu_open.Location = New System.Drawing.Point(0, 0)
        Me.Text_menu_open.Name = "Text_menu_open"
        Me.Text_menu_open.Size = New System.Drawing.Size(69, 34)
        Me.Text_menu_open.TabIndex = 2
        Me.Text_menu_open.Text = "Open"
        Me.Text_menu_open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minimizebutton
        '
        Me.Minimizebutton.BackColor = System.Drawing.Color.Transparent
        Me.Minimizebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Minimizebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.minimize
        Me.Minimizebutton.Location = New System.Drawing.Point(559, 0)
        Me.Minimizebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Minimizebutton.Name = "Minimizebutton"
        Me.Minimizebutton.Size = New System.Drawing.Size(45, 35)
        Me.Minimizebutton.TabIndex = 4
        Me.Minimizebutton.TabStop = False
        '
        'TLSE_title
        '
        Me.TLSE_title.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tlse_title_ex
        Me.TLSE_title.Location = New System.Drawing.Point(5, 3)
        Me.TLSE_title.Name = "TLSE_title"
        Me.TLSE_title.Size = New System.Drawing.Size(533, 32)
        Me.TLSE_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_title.TabIndex = 3
        Me.TLSE_title.TabStop = False
        '
        'Closebutton
        '
        Me.Closebutton.BackColor = System.Drawing.Color.Transparent
        Me.Closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Closebutton.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.close_tl
        Me.Closebutton.Location = New System.Drawing.Point(604, 0)
        Me.Closebutton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Closebutton.Name = "Closebutton"
        Me.Closebutton.Size = New System.Drawing.Size(45, 35)
        Me.Closebutton.TabIndex = 2
        Me.Closebutton.TabStop = False
        '
        'TLSE_logo_update
        '
        Me.TLSE_logo_update.BackColor = System.Drawing.Color.White
        Me.TLSE_logo_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TLSE_logo_update.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US_update
        Me.TLSE_logo_update.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo_update.Name = "TLSE_logo_update"
        Me.TLSE_logo_update.Size = New System.Drawing.Size(150, 75)
        Me.TLSE_logo_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo_update.TabIndex = 40
        Me.TLSE_logo_update.TabStop = False
        Me.TLSE_logo_update.Visible = False
        '
        'TLSE_logo
        '
        Me.TLSE_logo.BackColor = System.Drawing.Color.White
        Me.TLSE_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TLSE_logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TLSE_logo.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.logo_US
        Me.TLSE_logo.Location = New System.Drawing.Point(0, 0)
        Me.TLSE_logo.Name = "TLSE_logo"
        Me.TLSE_logo.Size = New System.Drawing.Size(150, 75)
        Me.TLSE_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TLSE_logo.TabIndex = 39
        Me.TLSE_logo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.Icon_menu)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Menuflow_ext_miimanagement)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel8)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 76)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(799, 57)
        Me.FlowLayoutPanel1.TabIndex = 42
        '
        'Icon_menu
        '
        Me.Icon_menu.BackColor = System.Drawing.Color.Transparent
        Me.Icon_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon_menu.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_menu_off
        Me.Icon_menu.Location = New System.Drawing.Point(3, 3)
        Me.Icon_menu.Name = "Icon_menu"
        Me.Icon_menu.Size = New System.Drawing.Size(61, 51)
        Me.Icon_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_menu.TabIndex = 42
        Me.Icon_menu.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tab_miimanagement_base
        Me.Panel4.Location = New System.Drawing.Point(70, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(45, 50)
        Me.Panel4.TabIndex = 2
        '
        'Menuflow_ext_miimanagement
        '
        Me.Menuflow_ext_miimanagement.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tab_miimanagement
        Me.Menuflow_ext_miimanagement.Controls.Add(Me.Menu_text_ext_miimanagement)
        Me.Menuflow_ext_miimanagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menuflow_ext_miimanagement.Location = New System.Drawing.Point(121, 3)
        Me.Menuflow_ext_miimanagement.Name = "Menuflow_ext_miimanagement"
        Me.Menuflow_ext_miimanagement.Size = New System.Drawing.Size(120, 50)
        Me.Menuflow_ext_miimanagement.TabIndex = 3
        '
        'Menu_text_ext_miimanagement
        '
        Me.Menu_text_ext_miimanagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Menu_text_ext_miimanagement.Location = New System.Drawing.Point(20, 0)
        Me.Menu_text_ext_miimanagement.Name = "Menu_text_ext_miimanagement"
        Me.Menu_text_ext_miimanagement.Size = New System.Drawing.Size(80, 50)
        Me.Menu_text_ext_miimanagement.TabIndex = 0
        Me.Menu_text_ext_miimanagement.Text = "Mii management"
        Me.Menu_text_ext_miimanagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.tab_miimanagement
        Me.Panel8.Controls.Add(Me.Menu_text_ext_extract)
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel8.Location = New System.Drawing.Point(247, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(120, 50)
        Me.Panel8.TabIndex = 43
        '
        'Menu_text_ext_extract
        '
        Me.Menu_text_ext_extract.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Menu_text_ext_extract.Location = New System.Drawing.Point(20, 0)
        Me.Menu_text_ext_extract.Name = "Menu_text_ext_extract"
        Me.Menu_text_ext_extract.Size = New System.Drawing.Size(80, 50)
        Me.Menu_text_ext_extract.TabIndex = 0
        Me.Menu_text_ext_extract.Text = "All Miis"
        Me.Menu_text_ext_extract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Title_extract
        '
        Me.Title_extract.BackColor = System.Drawing.Color.Transparent
        Me.Title_extract.Location = New System.Drawing.Point(32, 151)
        Me.Title_extract.Name = "Title_extract"
        Me.Title_extract.Size = New System.Drawing.Size(155, 13)
        Me.Title_extract.TabIndex = 43
        Me.Title_extract.Text = "All Miis in your island"
        Me.Title_extract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_buttons_large
        Me.Panel11.Controls.Add(Me.Text_extract)
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel11.Location = New System.Drawing.Point(115, 404)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(150, 32)
        Me.Panel11.TabIndex = 314
        '
        'Text_extract
        '
        Me.Text_extract.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Text_extract.Location = New System.Drawing.Point(0, 0)
        Me.Text_extract.Name = "Text_extract"
        Me.Text_extract.Size = New System.Drawing.Size(150, 32)
        Me.Text_extract.TabIndex = 1
        Me.Text_extract.Text = "Extract"
        Me.Text_extract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_extract_allMii
        '
        Me.Text_extract_allMii.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_extract_allMii.Location = New System.Drawing.Point(35, 167)
        Me.Text_extract_allMii.MaxLength = 99999999
        Me.Text_extract_allMii.Multiline = True
        Me.Text_extract_allMii.Name = "Text_extract_allMii"
        Me.Text_extract_allMii.ReadOnly = True
        Me.Text_extract_allMii.Size = New System.Drawing.Size(310, 231)
        Me.Text_extract_allMii.TabIndex = 313
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_buttons_large
        Me.Panel1.Controls.Add(Me.Text_restore)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(538, 404)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 32)
        Me.Panel1.TabIndex = 317
        '
        'Text_restore
        '
        Me.Text_restore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Text_restore.Location = New System.Drawing.Point(0, 0)
        Me.Text_restore.Name = "Text_restore"
        Me.Text_restore.Size = New System.Drawing.Size(150, 32)
        Me.Text_restore.TabIndex = 1
        Me.Text_restore.Text = "Restore"
        Me.Text_restore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Text_restore_allMii
        '
        Me.Text_restore_allMii.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Text_restore_allMii.Location = New System.Drawing.Point(458, 167)
        Me.Text_restore_allMii.MaxLength = 99999999
        Me.Text_restore_allMii.Multiline = True
        Me.Text_restore_allMii.Name = "Text_restore_allMii"
        Me.Text_restore_allMii.ReadOnly = True
        Me.Text_restore_allMii.Size = New System.Drawing.Size(310, 231)
        Me.Text_restore_allMii.TabIndex = 316
        '
        'Title_restore
        '
        Me.Title_restore.BackColor = System.Drawing.Color.Transparent
        Me.Title_restore.Location = New System.Drawing.Point(455, 151)
        Me.Title_restore.Name = "Title_restore"
        Me.Title_restore.Size = New System.Drawing.Size(155, 13)
        Me.Title_restore.TabIndex = 315
        Me.Title_restore.Text = "All Miis in a file"
        Me.Title_restore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valu_lastmii
        '
        Me.valu_lastmii.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.valu_lastmii.Location = New System.Drawing.Point(271, 149)
        Me.valu_lastmii.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valu_lastmii.Name = "valu_lastmii"
        Me.valu_lastmii.Size = New System.Drawing.Size(58, 16)
        Me.valu_lastmii.TabIndex = 318
        Me.valu_lastmii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.valu_lastmii.Visible = False
        '
        'Icon_miidetected
        '
        Me.Icon_miidetected.BackColor = System.Drawing.Color.Transparent
        Me.Icon_miidetected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Icon_miidetected.Cursor = System.Windows.Forms.Cursors.Help
        Me.Icon_miidetected.Image = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.icon_menu_mii
        Me.Icon_miidetected.Location = New System.Drawing.Point(271, 135)
        Me.Icon_miidetected.Name = "Icon_miidetected"
        Me.Icon_miidetected.Size = New System.Drawing.Size(30, 30)
        Me.Icon_miidetected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_miidetected.TabIndex = 320
        Me.Icon_miidetected.TabStop = False
        '
        'Text_miidetected
        '
        Me.Text_miidetected.AutoSize = True
        Me.Text_miidetected.BackColor = System.Drawing.Color.Transparent
        Me.Text_miidetected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_miidetected.Location = New System.Drawing.Point(304, 142)
        Me.Text_miidetected.Name = "Text_miidetected"
        Me.Text_miidetected.Size = New System.Drawing.Size(33, 16)
        Me.Text_miidetected.TabIndex = 319
        Me.Text_miidetected.Text = "X  0"
        '
        'TLSE_manag_allmiis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tomodachi_Life_Save_Editor.My.Resources.Resources.bg_miimanagement
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.valu_lastmii)
        Me.Controls.Add(Me.Icon_miidetected)
        Me.Controls.Add(Me.Text_miidetected)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Text_restore_allMii)
        Me.Controls.Add(Me.Title_restore)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Text_extract_allMii)
        Me.Controls.Add(Me.Title_extract)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TLSE_header)
        Me.Controls.Add(Me.TLSE_logo_update)
        Me.Controls.Add(Me.TLSE_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TLSE_manag_allmiis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TLSE_manag_allmiis"
        Me.TLSE_header.ResumeLayout(False)
        Me.TLSE_header.PerformLayout()
        Me.Panel_bspesymb.ResumeLayout(False)
        Me.Panel_bspesymb.PerformLayout()
        CType(Me.Icon_bspesymb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Advhelp.ResumeLayout(False)
        Me.Panel_Advhelp.PerformLayout()
        CType(Me.Icon_Advhelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_chkupdate.ResumeLayout(False)
        Me.Panel_chkupdate.PerformLayout()
        CType(Me.Icon_chkupdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_filepath.ResumeLayout(False)
        Me.Panel_filepath.PerformLayout()
        CType(Me.Icon_filepath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hiddenthings.ResumeLayout(False)
        Me.Panel_hiddenthings.PerformLayout()
        CType(Me.Icon_hiddenthings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_bgmusic.ResumeLayout(False)
        Me.Panel_bgmusic.PerformLayout()
        CType(Me.Icon_bgmusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel_menu_opensave.ResumeLayout(False)
        CType(Me.Minimizebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_title, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Closebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLSE_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.Icon_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menuflow_ext_miimanagement.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.valu_lastmii, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_miidetected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TLSE_header As Panel
    Friend WithEvents TLSE_filepath As TextBox
    Friend WithEvents Select_language As ComboBox
    Friend WithEvents Panel_bspesymb As Panel
    Friend WithEvents Setting_spesymb As CheckBox
    Friend WithEvents Icon_bspesymb As PictureBox
    Friend WithEvents Panel_Advhelp As Panel
    Friend WithEvents Setting_Advhelp As CheckBox
    Friend WithEvents Icon_Advhelp As PictureBox
    Friend WithEvents Panel_chkupdate As Panel
    Friend WithEvents Setting_ckupdate As CheckBox
    Friend WithEvents Icon_chkupdate As PictureBox
    Friend WithEvents Panel_filepath As Panel
    Friend WithEvents Setting_filepath As CheckBox
    Friend WithEvents Icon_filepath As PictureBox
    Friend WithEvents Panel_hiddenthings As Panel
    Friend WithEvents Setting_hidden As CheckBox
    Friend WithEvents Icon_hiddenthings As PictureBox
    Friend WithEvents Panel_bgmusic As Panel
    Friend WithEvents Select_music As ComboBox
    Friend WithEvents Setting_music As CheckBox
    Friend WithEvents Icon_bgmusic As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Filever_text As Label
    Friend WithEvents Title_filever As Label
    Friend WithEvents Panel_menu_opensave As Panel
    Friend WithEvents Text_menu_save As Label
    Friend WithEvents Text_menu_open As Label
    Friend WithEvents Minimizebutton As PictureBox
    Friend WithEvents TLSE_title As PictureBox
    Friend WithEvents Closebutton As PictureBox
    Friend WithEvents TLSE_logo_update As PictureBox
    Friend WithEvents TLSE_logo As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Icon_menu As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Menuflow_ext_miimanagement As Panel
    Friend WithEvents Menu_text_ext_miimanagement As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Menu_text_ext_extract As Label
    Friend WithEvents Title_extract As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Text_extract As Label
    Friend WithEvents Text_extract_allMii As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Text_restore As Label
    Friend WithEvents Text_restore_allMii As TextBox
    Friend WithEvents Title_restore As Label
    Friend WithEvents valu_lastmii As NumericUpDown
    Friend WithEvents Icon_miidetected As PictureBox
    Friend WithEvents Text_miidetected As Label
End Class
