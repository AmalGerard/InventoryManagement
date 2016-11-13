<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsDialog
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Opt_lbx = New System.Windows.Forms.ListBox
        Me.Printing_gbx = New System.Windows.Forms.GroupBox
        Me.ForDisc_lbl = New System.Windows.Forms.Label
        Me.Template_btn = New System.Windows.Forms.Button
        Me.Template_lbl = New System.Windows.Forms.Label
        Me.Space_cbx = New System.Windows.Forms.ComboBox
        Me.Space_lbl = New System.Windows.Forms.Label
        Me.Note_tbx = New System.Windows.Forms.TextBox
        Me.Note_lbl = New System.Windows.Forms.Label
        Me.PCode_ckbx = New System.Windows.Forms.CheckBox
        Me.Paper_cbx = New System.Windows.Forms.ComboBox
        Me.Paper_lbl = New System.Windows.Forms.Label
        Me.FootPage_ckbx = New System.Windows.Forms.CheckBox
        Me.FootText_tbx = New System.Windows.Forms.TextBox
        Me.FootText_lbl = New System.Windows.Forms.Label
        Me.HeadDate_ckbx = New System.Windows.Forms.CheckBox
        Me.HeadPhone_ckbx = New System.Windows.Forms.CheckBox
        Me.HeadAdd_ckbx = New System.Windows.Forms.CheckBox
        Me.Apply_btn = New System.Windows.Forms.Button
        Me.Cancel_btn = New System.Windows.Forms.Button
        Me.Ok_btn = New System.Windows.Forms.Button
        Me.General_gbx = New System.Windows.Forms.GroupBox
        Me.Website_tbx = New System.Windows.Forms.TextBox
        Me.Website_lbl = New System.Windows.Forms.Label
        Me.email_tbx = New System.Windows.Forms.TextBox
        Me.email_lbl = New System.Windows.Forms.Label
        Me.Currency_tbx = New System.Windows.Forms.TextBox
        Me.Currency_cbx = New System.Windows.Forms.ComboBox
        Me.Currency_lbl = New System.Windows.Forms.Label
        Me.State_tbx = New System.Windows.Forms.TextBox
        Me.State_lbl = New System.Windows.Forms.Label
        Me.Phone_tbx = New System.Windows.Forms.TextBox
        Me.Phone_lbl = New System.Windows.Forms.Label
        Me.Pin_tbx = New System.Windows.Forms.TextBox
        Me.Pin_lbl = New System.Windows.Forms.Label
        Me.City_tbx = New System.Windows.Forms.TextBox
        Me.City_lbl = New System.Windows.Forms.Label
        Me.Add2_tbx = New System.Windows.Forms.TextBox
        Me.Add2_lbl = New System.Windows.Forms.Label
        Me.Add1_tbx = New System.Windows.Forms.TextBox
        Me.Add1_lbl = New System.Windows.Forms.Label
        Me.Name_tbx = New System.Windows.Forms.TextBox
        Me.Name_lbl = New System.Windows.Forms.Label
        Me.Billing_gbx = New System.Windows.Forms.GroupBox
        Me.ItmDisc_ckbx = New System.Windows.Forms.CheckBox
        Me.Start_tbx = New System.Windows.Forms.TextBox
        Me.Step_tbx = New System.Windows.Forms.TextBox
        Me.Step_lbl = New System.Windows.Forms.Label
        Me.Start_lbl = New System.Windows.Forms.Label
        Me.Prefix_tbx = New System.Windows.Forms.TextBox
        Me.Prefix2_lbl = New System.Windows.Forms.Label
        Me.Prefix_cbx = New System.Windows.Forms.ComboBox
        Me.Prefix1_lbl = New System.Windows.Forms.Label
        Me.Prefix_ckbx = New System.Windows.Forms.CheckBox
        Me.Auto_ckbx = New System.Windows.Forms.CheckBox
        Me.BillNo_lbl = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Printing_gbx.SuspendLayout()
        Me.General_gbx.SuspendLayout()
        Me.Billing_gbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Opt_lbx)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Printing_gbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Apply_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cancel_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Ok_btn)
        Me.SplitContainer1.Size = New System.Drawing.Size(412, 331)
        Me.SplitContainer1.SplitterDistance = 65
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'Opt_lbx
        '
        Me.Opt_lbx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Opt_lbx.FormattingEnabled = True
        Me.Opt_lbx.Items.AddRange(New Object() {"General", "Billing", "Printing"})
        Me.Opt_lbx.Location = New System.Drawing.Point(0, 0)
        Me.Opt_lbx.Name = "Opt_lbx"
        Me.Opt_lbx.Size = New System.Drawing.Size(63, 329)
        Me.Opt_lbx.TabIndex = 0
        '
        'Printing_gbx
        '
        Me.Printing_gbx.Controls.Add(Me.ForDisc_lbl)
        Me.Printing_gbx.Controls.Add(Me.Template_btn)
        Me.Printing_gbx.Controls.Add(Me.Template_lbl)
        Me.Printing_gbx.Controls.Add(Me.Space_cbx)
        Me.Printing_gbx.Controls.Add(Me.Space_lbl)
        Me.Printing_gbx.Controls.Add(Me.Note_tbx)
        Me.Printing_gbx.Controls.Add(Me.Note_lbl)
        Me.Printing_gbx.Controls.Add(Me.PCode_ckbx)
        Me.Printing_gbx.Controls.Add(Me.Paper_cbx)
        Me.Printing_gbx.Controls.Add(Me.Paper_lbl)
        Me.Printing_gbx.Controls.Add(Me.FootPage_ckbx)
        Me.Printing_gbx.Controls.Add(Me.FootText_tbx)
        Me.Printing_gbx.Controls.Add(Me.FootText_lbl)
        Me.Printing_gbx.Controls.Add(Me.HeadDate_ckbx)
        Me.Printing_gbx.Controls.Add(Me.HeadPhone_ckbx)
        Me.Printing_gbx.Controls.Add(Me.HeadAdd_ckbx)
        Me.Printing_gbx.Location = New System.Drawing.Point(12, 11)
        Me.Printing_gbx.Name = "Printing_gbx"
        Me.Printing_gbx.Size = New System.Drawing.Size(315, 278)
        Me.Printing_gbx.TabIndex = 5
        Me.Printing_gbx.TabStop = False
        Me.Printing_gbx.Text = "Printing"
        '
        'ForDisc_lbl
        '
        Me.ForDisc_lbl.AutoSize = True
        Me.ForDisc_lbl.Location = New System.Drawing.Point(197, 244)
        Me.ForDisc_lbl.Name = "ForDisc_lbl"
        Me.ForDisc_lbl.Size = New System.Drawing.Size(95, 13)
        Me.ForDisc_lbl.TabIndex = 27
        Me.ForDisc_lbl.Text = "(for discrete paper)"
        '
        'Template_btn
        '
        Me.Template_btn.Location = New System.Drawing.Point(81, 239)
        Me.Template_btn.Name = "Template_btn"
        Me.Template_btn.Size = New System.Drawing.Size(113, 23)
        Me.Template_btn.TabIndex = 9
        Me.Template_btn.Text = "Simple"
        Me.Template_btn.UseVisualStyleBackColor = True
        '
        'Template_lbl
        '
        Me.Template_lbl.AutoSize = True
        Me.Template_lbl.Location = New System.Drawing.Point(3, 244)
        Me.Template_lbl.Name = "Template_lbl"
        Me.Template_lbl.Size = New System.Drawing.Size(70, 13)
        Me.Template_lbl.TabIndex = 25
        Me.Template_lbl.Text = "Bill Template:"
        '
        'Space_cbx
        '
        Me.Space_cbx.FormattingEnabled = True
        Me.Space_cbx.Items.AddRange(New Object() {"Single", "1.5", "Double"})
        Me.Space_cbx.Location = New System.Drawing.Point(81, 213)
        Me.Space_cbx.Name = "Space_cbx"
        Me.Space_cbx.Size = New System.Drawing.Size(86, 21)
        Me.Space_cbx.TabIndex = 8
        '
        'Space_lbl
        '
        Me.Space_lbl.AutoSize = True
        Me.Space_lbl.Location = New System.Drawing.Point(3, 216)
        Me.Space_lbl.Name = "Space_lbl"
        Me.Space_lbl.Size = New System.Drawing.Size(72, 13)
        Me.Space_lbl.TabIndex = 23
        Me.Space_lbl.Text = "Line Spacing:"
        '
        'Note_tbx
        '
        Me.Note_tbx.Location = New System.Drawing.Point(81, 187)
        Me.Note_tbx.Name = "Note_tbx"
        Me.Note_tbx.Size = New System.Drawing.Size(222, 20)
        Me.Note_tbx.TabIndex = 7
        '
        'Note_lbl
        '
        Me.Note_lbl.AutoSize = True
        Me.Note_lbl.Location = New System.Drawing.Point(3, 190)
        Me.Note_lbl.Name = "Note_lbl"
        Me.Note_lbl.Size = New System.Drawing.Size(33, 13)
        Me.Note_lbl.TabIndex = 21
        Me.Note_lbl.Text = "Note:"
        '
        'PCode_ckbx
        '
        Me.PCode_ckbx.AutoSize = True
        Me.PCode_ckbx.Checked = True
        Me.PCode_ckbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PCode_ckbx.Location = New System.Drawing.Point(6, 117)
        Me.PCode_ckbx.Name = "PCode_ckbx"
        Me.PCode_ckbx.Size = New System.Drawing.Size(156, 17)
        Me.PCode_ckbx.TabIndex = 4
        Me.PCode_ckbx.Text = "Include Product Code in Bill"
        Me.PCode_ckbx.UseVisualStyleBackColor = True
        '
        'Paper_cbx
        '
        Me.Paper_cbx.FormattingEnabled = True
        Me.Paper_cbx.Items.AddRange(New Object() {"Continuous", "Discrete"})
        Me.Paper_cbx.Location = New System.Drawing.Point(81, 21)
        Me.Paper_cbx.Name = "Paper_cbx"
        Me.Paper_cbx.Size = New System.Drawing.Size(86, 21)
        Me.Paper_cbx.TabIndex = 0
        '
        'Paper_lbl
        '
        Me.Paper_lbl.AutoSize = True
        Me.Paper_lbl.Location = New System.Drawing.Point(3, 24)
        Me.Paper_lbl.Name = "Paper_lbl"
        Me.Paper_lbl.Size = New System.Drawing.Size(75, 13)
        Me.Paper_lbl.TabIndex = 6
        Me.Paper_lbl.Text = "Paper Source:"
        '
        'FootPage_ckbx
        '
        Me.FootPage_ckbx.AutoSize = True
        Me.FootPage_ckbx.Checked = True
        Me.FootPage_ckbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FootPage_ckbx.Location = New System.Drawing.Point(6, 140)
        Me.FootPage_ckbx.Name = "FootPage_ckbx"
        Me.FootPage_ckbx.Size = New System.Drawing.Size(244, 17)
        Me.FootPage_ckbx.TabIndex = 5
        Me.FootPage_ckbx.Text = "Include Page No. in Footer (for discrete paper)"
        Me.FootPage_ckbx.UseMnemonic = False
        Me.FootPage_ckbx.UseVisualStyleBackColor = True
        '
        'FootText_tbx
        '
        Me.FootText_tbx.Location = New System.Drawing.Point(81, 161)
        Me.FootText_tbx.Name = "FootText_tbx"
        Me.FootText_tbx.Size = New System.Drawing.Size(222, 20)
        Me.FootText_tbx.TabIndex = 6
        '
        'FootText_lbl
        '
        Me.FootText_lbl.AutoSize = True
        Me.FootText_lbl.Location = New System.Drawing.Point(3, 164)
        Me.FootText_lbl.Name = "FootText_lbl"
        Me.FootText_lbl.Size = New System.Drawing.Size(64, 13)
        Me.FootText_lbl.TabIndex = 3
        Me.FootText_lbl.Text = "Footer Text:"
        '
        'HeadDate_ckbx
        '
        Me.HeadDate_ckbx.AutoSize = True
        Me.HeadDate_ckbx.Checked = True
        Me.HeadDate_ckbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeadDate_ckbx.Location = New System.Drawing.Point(6, 94)
        Me.HeadDate_ckbx.Name = "HeadDate_ckbx"
        Me.HeadDate_ckbx.Size = New System.Drawing.Size(171, 17)
        Me.HeadDate_ckbx.TabIndex = 3
        Me.HeadDate_ckbx.Text = "Include Date & Time in Header"
        Me.HeadDate_ckbx.UseMnemonic = False
        Me.HeadDate_ckbx.UseVisualStyleBackColor = True
        '
        'HeadPhone_ckbx
        '
        Me.HeadPhone_ckbx.AutoSize = True
        Me.HeadPhone_ckbx.Checked = True
        Me.HeadPhone_ckbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeadPhone_ckbx.Location = New System.Drawing.Point(6, 71)
        Me.HeadPhone_ckbx.Name = "HeadPhone_ckbx"
        Me.HeadPhone_ckbx.Size = New System.Drawing.Size(164, 17)
        Me.HeadPhone_ckbx.TabIndex = 2
        Me.HeadPhone_ckbx.Text = "Include Phone No. in Header"
        Me.HeadPhone_ckbx.UseVisualStyleBackColor = True
        '
        'HeadAdd_ckbx
        '
        Me.HeadAdd_ckbx.AutoSize = True
        Me.HeadAdd_ckbx.Checked = True
        Me.HeadAdd_ckbx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeadAdd_ckbx.Location = New System.Drawing.Point(6, 48)
        Me.HeadAdd_ckbx.Name = "HeadAdd_ckbx"
        Me.HeadAdd_ckbx.Size = New System.Drawing.Size(151, 17)
        Me.HeadAdd_ckbx.TabIndex = 1
        Me.HeadAdd_ckbx.Text = "Include Address in Header"
        Me.HeadAdd_ckbx.UseVisualStyleBackColor = True
        '
        'Apply_btn
        '
        Me.Apply_btn.Location = New System.Drawing.Point(268, 295)
        Me.Apply_btn.Name = "Apply_btn"
        Me.Apply_btn.Size = New System.Drawing.Size(50, 23)
        Me.Apply_btn.TabIndex = 20
        Me.Apply_btn.Text = "Apply"
        Me.Apply_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_btn.Location = New System.Drawing.Point(212, 295)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(50, 23)
        Me.Cancel_btn.TabIndex = 22
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'Ok_btn
        '
        Me.Ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Ok_btn.Location = New System.Drawing.Point(156, 295)
        Me.Ok_btn.Name = "Ok_btn"
        Me.Ok_btn.Size = New System.Drawing.Size(50, 23)
        Me.Ok_btn.TabIndex = 21
        Me.Ok_btn.Text = "Ok"
        Me.Ok_btn.UseVisualStyleBackColor = True
        '
        'General_gbx
        '
        Me.General_gbx.Controls.Add(Me.Website_tbx)
        Me.General_gbx.Controls.Add(Me.Website_lbl)
        Me.General_gbx.Controls.Add(Me.email_tbx)
        Me.General_gbx.Controls.Add(Me.email_lbl)
        Me.General_gbx.Controls.Add(Me.Currency_tbx)
        Me.General_gbx.Controls.Add(Me.Currency_cbx)
        Me.General_gbx.Controls.Add(Me.Currency_lbl)
        Me.General_gbx.Controls.Add(Me.State_tbx)
        Me.General_gbx.Controls.Add(Me.State_lbl)
        Me.General_gbx.Controls.Add(Me.Phone_tbx)
        Me.General_gbx.Controls.Add(Me.Phone_lbl)
        Me.General_gbx.Controls.Add(Me.Pin_tbx)
        Me.General_gbx.Controls.Add(Me.Pin_lbl)
        Me.General_gbx.Controls.Add(Me.City_tbx)
        Me.General_gbx.Controls.Add(Me.City_lbl)
        Me.General_gbx.Controls.Add(Me.Add2_tbx)
        Me.General_gbx.Controls.Add(Me.Add2_lbl)
        Me.General_gbx.Controls.Add(Me.Add1_tbx)
        Me.General_gbx.Controls.Add(Me.Add1_lbl)
        Me.General_gbx.Controls.Add(Me.Name_tbx)
        Me.General_gbx.Controls.Add(Me.Name_lbl)
        Me.General_gbx.Location = New System.Drawing.Point(12, 11)
        Me.General_gbx.Name = "General_gbx"
        Me.General_gbx.Size = New System.Drawing.Size(315, 278)
        Me.General_gbx.TabIndex = 1
        Me.General_gbx.TabStop = False
        Me.General_gbx.Text = "General"
        '
        'Website_tbx
        '
        Me.Website_tbx.Location = New System.Drawing.Point(89, 221)
        Me.Website_tbx.Name = "Website_tbx"
        Me.Website_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Website_tbx.TabIndex = 8
        '
        'Website_lbl
        '
        Me.Website_lbl.AutoSize = True
        Me.Website_lbl.Location = New System.Drawing.Point(6, 224)
        Me.Website_lbl.Name = "Website_lbl"
        Me.Website_lbl.Size = New System.Drawing.Size(49, 13)
        Me.Website_lbl.TabIndex = 19
        Me.Website_lbl.Text = "Website:"
        '
        'email_tbx
        '
        Me.email_tbx.Location = New System.Drawing.Point(89, 195)
        Me.email_tbx.Name = "email_tbx"
        Me.email_tbx.Size = New System.Drawing.Size(213, 20)
        Me.email_tbx.TabIndex = 7
        '
        'email_lbl
        '
        Me.email_lbl.AutoSize = True
        Me.email_lbl.Location = New System.Drawing.Point(6, 198)
        Me.email_lbl.Name = "email_lbl"
        Me.email_lbl.Size = New System.Drawing.Size(35, 13)
        Me.email_lbl.TabIndex = 17
        Me.email_lbl.Text = "Email:"
        '
        'Currency_tbx
        '
        Me.Currency_tbx.Enabled = False
        Me.Currency_tbx.Location = New System.Drawing.Point(189, 247)
        Me.Currency_tbx.Name = "Currency_tbx"
        Me.Currency_tbx.Size = New System.Drawing.Size(113, 20)
        Me.Currency_tbx.TabIndex = 10
        '
        'Currency_cbx
        '
        Me.Currency_cbx.FormattingEnabled = True
        Me.Currency_cbx.Items.AddRange(New Object() {"Rs.", "$", "€", "Other"})
        Me.Currency_cbx.Location = New System.Drawing.Point(89, 247)
        Me.Currency_cbx.Name = "Currency_cbx"
        Me.Currency_cbx.Size = New System.Drawing.Size(94, 21)
        Me.Currency_cbx.TabIndex = 9
        '
        'Currency_lbl
        '
        Me.Currency_lbl.AutoSize = True
        Me.Currency_lbl.Location = New System.Drawing.Point(6, 250)
        Me.Currency_lbl.Name = "Currency_lbl"
        Me.Currency_lbl.Size = New System.Drawing.Size(52, 13)
        Me.Currency_lbl.TabIndex = 13
        Me.Currency_lbl.Text = "Currency:"
        '
        'State_tbx
        '
        Me.State_tbx.Location = New System.Drawing.Point(89, 117)
        Me.State_tbx.Name = "State_tbx"
        Me.State_tbx.Size = New System.Drawing.Size(213, 20)
        Me.State_tbx.TabIndex = 4
        '
        'State_lbl
        '
        Me.State_lbl.AutoSize = True
        Me.State_lbl.Location = New System.Drawing.Point(6, 120)
        Me.State_lbl.Name = "State_lbl"
        Me.State_lbl.Size = New System.Drawing.Size(35, 13)
        Me.State_lbl.TabIndex = 12
        Me.State_lbl.Text = "State:"
        '
        'Phone_tbx
        '
        Me.Phone_tbx.Location = New System.Drawing.Point(89, 169)
        Me.Phone_tbx.Name = "Phone_tbx"
        Me.Phone_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Phone_tbx.TabIndex = 6
        '
        'Phone_lbl
        '
        Me.Phone_lbl.AutoSize = True
        Me.Phone_lbl.Location = New System.Drawing.Point(6, 172)
        Me.Phone_lbl.Name = "Phone_lbl"
        Me.Phone_lbl.Size = New System.Drawing.Size(41, 13)
        Me.Phone_lbl.TabIndex = 10
        Me.Phone_lbl.Text = "Phone:"
        '
        'Pin_tbx
        '
        Me.Pin_tbx.Location = New System.Drawing.Point(89, 143)
        Me.Pin_tbx.Name = "Pin_tbx"
        Me.Pin_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Pin_tbx.TabIndex = 5
        '
        'Pin_lbl
        '
        Me.Pin_lbl.AutoSize = True
        Me.Pin_lbl.Location = New System.Drawing.Point(6, 146)
        Me.Pin_lbl.Name = "Pin_lbl"
        Me.Pin_lbl.Size = New System.Drawing.Size(50, 13)
        Me.Pin_lbl.TabIndex = 8
        Me.Pin_lbl.Text = "PinCode:"
        '
        'City_tbx
        '
        Me.City_tbx.Location = New System.Drawing.Point(89, 91)
        Me.City_tbx.Name = "City_tbx"
        Me.City_tbx.Size = New System.Drawing.Size(213, 20)
        Me.City_tbx.TabIndex = 3
        '
        'City_lbl
        '
        Me.City_lbl.AutoSize = True
        Me.City_lbl.Location = New System.Drawing.Point(6, 94)
        Me.City_lbl.Name = "City_lbl"
        Me.City_lbl.Size = New System.Drawing.Size(27, 13)
        Me.City_lbl.TabIndex = 6
        Me.City_lbl.Text = "City:"
        '
        'Add2_tbx
        '
        Me.Add2_tbx.Location = New System.Drawing.Point(89, 65)
        Me.Add2_tbx.Name = "Add2_tbx"
        Me.Add2_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Add2_tbx.TabIndex = 2
        '
        'Add2_lbl
        '
        Me.Add2_lbl.AutoSize = True
        Me.Add2_lbl.Location = New System.Drawing.Point(6, 68)
        Me.Add2_lbl.Name = "Add2_lbl"
        Me.Add2_lbl.Size = New System.Drawing.Size(80, 13)
        Me.Add2_lbl.TabIndex = 4
        Me.Add2_lbl.Text = "Address Line 2:"
        '
        'Add1_tbx
        '
        Me.Add1_tbx.Location = New System.Drawing.Point(89, 39)
        Me.Add1_tbx.Name = "Add1_tbx"
        Me.Add1_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Add1_tbx.TabIndex = 1
        '
        'Add1_lbl
        '
        Me.Add1_lbl.AutoSize = True
        Me.Add1_lbl.Location = New System.Drawing.Point(6, 42)
        Me.Add1_lbl.Name = "Add1_lbl"
        Me.Add1_lbl.Size = New System.Drawing.Size(80, 13)
        Me.Add1_lbl.TabIndex = 2
        Me.Add1_lbl.Text = "Address Line 1:"
        '
        'Name_tbx
        '
        Me.Name_tbx.Location = New System.Drawing.Point(89, 13)
        Me.Name_tbx.Name = "Name_tbx"
        Me.Name_tbx.Size = New System.Drawing.Size(213, 20)
        Me.Name_tbx.TabIndex = 0
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Location = New System.Drawing.Point(6, 16)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(66, 13)
        Me.Name_lbl.TabIndex = 0
        Me.Name_lbl.Text = "Shop Name:"
        '
        'Billing_gbx
        '
        Me.Billing_gbx.Controls.Add(Me.ItmDisc_ckbx)
        Me.Billing_gbx.Controls.Add(Me.Start_tbx)
        Me.Billing_gbx.Controls.Add(Me.Step_tbx)
        Me.Billing_gbx.Controls.Add(Me.Step_lbl)
        Me.Billing_gbx.Controls.Add(Me.Start_lbl)
        Me.Billing_gbx.Controls.Add(Me.Prefix_tbx)
        Me.Billing_gbx.Controls.Add(Me.Prefix2_lbl)
        Me.Billing_gbx.Controls.Add(Me.Prefix_cbx)
        Me.Billing_gbx.Controls.Add(Me.Prefix1_lbl)
        Me.Billing_gbx.Controls.Add(Me.Prefix_ckbx)
        Me.Billing_gbx.Controls.Add(Me.Auto_ckbx)
        Me.Billing_gbx.Controls.Add(Me.BillNo_lbl)
        Me.Billing_gbx.Location = New System.Drawing.Point(12, 11)
        Me.Billing_gbx.Name = "Billing_gbx"
        Me.Billing_gbx.Size = New System.Drawing.Size(315, 200)
        Me.Billing_gbx.TabIndex = 5
        Me.Billing_gbx.TabStop = False
        Me.Billing_gbx.Text = "Billing"
        '
        'ItmDisc_ckbx
        '
        Me.ItmDisc_ckbx.AutoSize = True
        Me.ItmDisc_ckbx.Location = New System.Drawing.Point(9, 172)
        Me.ItmDisc_ckbx.Name = "ItmDisc_ckbx"
        Me.ItmDisc_ckbx.Size = New System.Drawing.Size(186, 17)
        Me.ItmDisc_ckbx.TabIndex = 13
        Me.ItmDisc_ckbx.Text = "Enable Discount for each Product"
        Me.ItmDisc_ckbx.UseVisualStyleBackColor = True
        '
        'Start_tbx
        '
        Me.Start_tbx.Location = New System.Drawing.Point(139, 120)
        Me.Start_tbx.Name = "Start_tbx"
        Me.Start_tbx.Size = New System.Drawing.Size(50, 20)
        Me.Start_tbx.TabIndex = 11
        Me.Start_tbx.Text = "00001"
        '
        'Step_tbx
        '
        Me.Step_tbx.Location = New System.Drawing.Point(139, 146)
        Me.Step_tbx.Name = "Step_tbx"
        Me.Step_tbx.Size = New System.Drawing.Size(50, 20)
        Me.Step_tbx.TabIndex = 12
        Me.Step_tbx.Text = "1"
        '
        'Step_lbl
        '
        Me.Step_lbl.AutoSize = True
        Me.Step_lbl.Location = New System.Drawing.Point(43, 149)
        Me.Step_lbl.Name = "Step_lbl"
        Me.Step_lbl.Size = New System.Drawing.Size(82, 13)
        Me.Step_lbl.TabIndex = 11
        Me.Step_lbl.Text = "Increment Step:"
        '
        'Start_lbl
        '
        Me.Start_lbl.AutoSize = True
        Me.Start_lbl.Location = New System.Drawing.Point(43, 123)
        Me.Start_lbl.Name = "Start_lbl"
        Me.Start_lbl.Size = New System.Drawing.Size(85, 13)
        Me.Start_lbl.TabIndex = 9
        Me.Start_lbl.Text = "Increment Seed:"
        '
        'Prefix_tbx
        '
        Me.Prefix_tbx.Location = New System.Drawing.Point(139, 94)
        Me.Prefix_tbx.Name = "Prefix_tbx"
        Me.Prefix_tbx.Size = New System.Drawing.Size(106, 20)
        Me.Prefix_tbx.TabIndex = 10
        '
        'Prefix2_lbl
        '
        Me.Prefix2_lbl.AutoSize = True
        Me.Prefix2_lbl.Location = New System.Drawing.Point(43, 97)
        Me.Prefix2_lbl.Name = "Prefix2_lbl"
        Me.Prefix2_lbl.Size = New System.Drawing.Size(65, 13)
        Me.Prefix2_lbl.TabIndex = 5
        Me.Prefix2_lbl.Text = "Other Prefix:"
        '
        'Prefix_cbx
        '
        Me.Prefix_cbx.FormattingEnabled = True
        Me.Prefix_cbx.Items.AddRange(New Object() {"None", "Date/Month", "Month/Date", "Date/Month/Year", "Month/Date/Year", "Year/Date/Month", "Year/Month/Date"})
        Me.Prefix_cbx.Location = New System.Drawing.Point(139, 67)
        Me.Prefix_cbx.Name = "Prefix_cbx"
        Me.Prefix_cbx.Size = New System.Drawing.Size(106, 21)
        Me.Prefix_cbx.TabIndex = 9
        '
        'Prefix1_lbl
        '
        Me.Prefix1_lbl.AutoSize = True
        Me.Prefix1_lbl.Location = New System.Drawing.Point(43, 70)
        Me.Prefix1_lbl.Name = "Prefix1_lbl"
        Me.Prefix1_lbl.Size = New System.Drawing.Size(90, 13)
        Me.Prefix1_lbl.TabIndex = 3
        Me.Prefix1_lbl.Text = "Predefined Prefix:"
        '
        'Prefix_ckbx
        '
        Me.Prefix_ckbx.AutoSize = True
        Me.Prefix_ckbx.Location = New System.Drawing.Point(46, 49)
        Me.Prefix_ckbx.Name = "Prefix_ckbx"
        Me.Prefix_ckbx.Size = New System.Drawing.Size(90, 17)
        Me.Prefix_ckbx.TabIndex = 8
        Me.Prefix_ckbx.Text = "Include Prefix"
        Me.Prefix_ckbx.UseVisualStyleBackColor = True
        '
        'Auto_ckbx
        '
        Me.Auto_ckbx.AutoSize = True
        Me.Auto_ckbx.Location = New System.Drawing.Point(27, 31)
        Me.Auto_ckbx.Name = "Auto_ckbx"
        Me.Auto_ckbx.Size = New System.Drawing.Size(134, 17)
        Me.Auto_ckbx.TabIndex = 7
        Me.Auto_ckbx.Text = "Enable Auto Increment"
        Me.Auto_ckbx.UseVisualStyleBackColor = True
        '
        'BillNo_lbl
        '
        Me.BillNo_lbl.AutoSize = True
        Me.BillNo_lbl.Location = New System.Drawing.Point(6, 16)
        Me.BillNo_lbl.Name = "BillNo_lbl"
        Me.BillNo_lbl.Size = New System.Drawing.Size(75, 13)
        Me.BillNo_lbl.TabIndex = 0
        Me.BillNo_lbl.Text = "Bill No. format:"
        '
        'OptionsDialog
        '
        Me.AcceptButton = Me.Apply_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_btn
        Me.ClientSize = New System.Drawing.Size(412, 331)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "OptionsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Printing_gbx.ResumeLayout(False)
        Me.Printing_gbx.PerformLayout()
        Me.General_gbx.ResumeLayout(False)
        Me.General_gbx.PerformLayout()
        Me.Billing_gbx.ResumeLayout(False)
        Me.Billing_gbx.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Opt_lbx As System.Windows.Forms.ListBox
    Friend WithEvents Apply_btn As System.Windows.Forms.Button
    Friend WithEvents Cancel_btn As System.Windows.Forms.Button
    Friend WithEvents Ok_btn As System.Windows.Forms.Button
    Friend WithEvents General_gbx As System.Windows.Forms.GroupBox
    Friend WithEvents State_tbx As System.Windows.Forms.TextBox
    Friend WithEvents State_lbl As System.Windows.Forms.Label
    Friend WithEvents Phone_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Phone_lbl As System.Windows.Forms.Label
    Friend WithEvents Pin_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Pin_lbl As System.Windows.Forms.Label
    Friend WithEvents City_tbx As System.Windows.Forms.TextBox
    Friend WithEvents City_lbl As System.Windows.Forms.Label
    Friend WithEvents Add2_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Add2_lbl As System.Windows.Forms.Label
    Friend WithEvents Add1_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Add1_lbl As System.Windows.Forms.Label
    Friend WithEvents Name_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Name_lbl As System.Windows.Forms.Label
    Friend WithEvents Billing_gbx As System.Windows.Forms.GroupBox
    Friend WithEvents BillNo_lbl As System.Windows.Forms.Label
    Friend WithEvents Prefix_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents Auto_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents Prefix_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Prefix1_lbl As System.Windows.Forms.Label
    Friend WithEvents Prefix_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Prefix2_lbl As System.Windows.Forms.Label
    Friend WithEvents Start_lbl As System.Windows.Forms.Label
    Friend WithEvents Start_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Step_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Step_lbl As System.Windows.Forms.Label
    Friend WithEvents ItmDisc_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents Printing_gbx As System.Windows.Forms.GroupBox
    Friend WithEvents HeadDate_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents HeadPhone_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents HeadAdd_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents Paper_lbl As System.Windows.Forms.Label
    Friend WithEvents FootPage_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents FootText_tbx As System.Windows.Forms.TextBox
    Friend WithEvents FootText_lbl As System.Windows.Forms.Label
    Friend WithEvents Paper_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents PCode_ckbx As System.Windows.Forms.CheckBox
    Friend WithEvents Currency_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Currency_lbl As System.Windows.Forms.Label
    Friend WithEvents Currency_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Note_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Note_lbl As System.Windows.Forms.Label
    Friend WithEvents Space_cbx As System.Windows.Forms.ComboBox
    Friend WithEvents Space_lbl As System.Windows.Forms.Label
    Friend WithEvents ForDisc_lbl As System.Windows.Forms.Label
    Friend WithEvents Template_btn As System.Windows.Forms.Button
    Friend WithEvents Template_lbl As System.Windows.Forms.Label
    Friend WithEvents Website_tbx As System.Windows.Forms.TextBox
    Friend WithEvents Website_lbl As System.Windows.Forms.Label
    Friend WithEvents email_tbx As System.Windows.Forms.TextBox
    Friend WithEvents email_lbl As System.Windows.Forms.Label
End Class
