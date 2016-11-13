Public Class EditInventoryForm

    Dim Index As Integer

    Private Sub EditInventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Details1' table. You can move, or remove it, as needed.
        Me.Details1TableAdapter.Fill(Me.MainInventoryDataSet.Details1)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Size' table. You can move, or remove it, as needed.
        Me.SizeTableAdapter.Fill(Me.MainInventoryDataSet.Size)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Materials' table. You can move, or remove it, as needed.
        Me.MaterialsTableAdapter.Fill(Me.MainInventoryDataSet.Materials)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Types' table. You can move, or remove it, as needed.
        Me.TypesTableAdapter.Fill(Me.MainInventoryDataSet.Types)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.MainInventoryDataSet.Items)
        'TODO: This line of code loads data into the 'InventoryDataSet.Groups' table. You can move, or remove it, as needed.
        Me.GroupsTableAdapter.Fill(Me.MainInventoryDataSet.Groups)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
    End Sub

    Private Sub EditInventoryForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
        MainForm.Visible = True
    End Sub

    Private Sub Grp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_btn.Click
        Me.AcceptButton = Me.EditGrp_btn
        Me.EditGrp_btn.Tag = ""
        Me.Grp_btn.BackColor = Color.PaleTurquoise
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.EditGrp_btn.Text = "Edit"
        Me.EditGrp_btn.Enabled = True
        Me.DelGrp_btn.Enabled = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelGrp_btn)
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Itm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itm_btn.Click
        Me.AcceptButton = Me.EditItm_btn
        Me.EditItm_btn.Tag = ""
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.PaleTurquoise
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        Me.EditItm_btn.Text = "Edit"
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
            Me.EditItm_btn.Enabled = True
            Me.DelItm_btn.Enabled = True
        ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
            Me.EditItm_btn.Enabled = False
            Me.DelItm_btn.Enabled = False
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        If Me.ItemsBindingSource.Count = 0 Then
            Me.EditItm_btn.Enabled = False
            Me.DelItm_btn.Enabled = False
        End If
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelItm_btn)
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Typ_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_btn.Click
        Me.AcceptButton = Me.EditTyp_btn
        Me.EditTyp_btn.Tag = ""
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.PaleTurquoise
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        Me.EditTyp_btn.Text = "Edit"
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
            Me.EditTyp_btn.Enabled = True
            Me.DelTyp_btn.Enabled = True
        ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
            Me.EditTyp_btn.Enabled = False
            Me.DelTyp_btn.Enabled = False
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
            Me.EditTyp_btn.Enabled = True
            Me.DelTyp_btn.Enabled = True
        ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & -1
            Me.EditTyp_btn.Enabled = False
            Me.DelTyp_btn.Enabled = False
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelTyp_btn)
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Mat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat_btn.Click
        Me.AcceptButton = Me.EditMat_btn
        Me.EditMat_btn.Tag = ""
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.PaleTurquoise
        Me.Size_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        Me.EditMat_btn.Text = "Edit"
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
            Me.EditMat_btn.Enabled = True
            Me.DelMat_btn.Enabled = True
        ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
            Me.EditMat_btn.Enabled = False
            Me.DelMat_btn.Enabled = False
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
            Me.EditMat_btn.Enabled = True
            Me.DelMat_btn.Enabled = True
        ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & -1
            Me.EditMat_btn.Enabled = False
            Me.DelMat_btn.Enabled = False
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
            Me.EditMat_btn.Enabled = True
            Me.DelMat_btn.Enabled = True
        ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
            Me.EditMat_btn.Enabled = False
            Me.DelMat_btn.Enabled = False
        End If
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelMat_btn)
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Size_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Size_btn.Click
        Me.AcceptButton = Me.EditSiz_btn
        Me.EditSiz_btn.Tag = ""
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.PaleTurquoise
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.DelSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        Me.EditSiz_btn.Text = "Edit"
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
            Me.EditSiz_btn.Enabled = True
            Me.DelSiz_btn.Enabled = True
        ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
            Me.EditSiz_btn.Enabled = False
            Me.DelSiz_btn.Enabled = False
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
            Me.EditSiz_btn.Enabled = True
            Me.DelSiz_btn.Enabled = True
        ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & -1
            Me.EditSiz_btn.Enabled = False
            Me.DelSiz_btn.Enabled = False
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
            Me.EditSiz_btn.Enabled = True
            Me.DelSiz_btn.Enabled = True
        ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
            Me.EditSiz_btn.Enabled = False
            Me.DelSiz_btn.Enabled = False
        End If
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_cbx)
        If Me.Mat_cbx.SelectedValue <> Nothing Then
            Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
            Me.EditSiz_btn.Enabled = True
            Me.DelSiz_btn.Enabled = True
        ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
            Me.SizeBindingSource.Filter = "MatID =" & -1
            Me.EditSiz_btn.Enabled = False
            Me.DelSiz_btn.Enabled = False
        End If
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DelSiz_btn)
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Grp_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_cbx.SelectedValueChanged
        If Me.Grp_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.GroupsBindingSource.Count = 0 Then
                    Me.EditGrp_btn.Enabled = False
                    Me.DelGrp_btn.Enabled = False
                ElseIf Me.GroupsBindingSource.Count > 0 Then
                    Me.EditGrp_btn.Enabled = True
                    Me.DelGrp_btn.Enabled = True
                End If
            End If
        ElseIf Me.Itm_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.Grp_cbx.SelectedValue <> Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & -1
                End If
            End If
            If Me.ItemsBindingSource.Count > 0 Then
                Me.EditItm_btn.Enabled = True
                Me.DelItm_btn.Enabled = True
            ElseIf Me.ItemsBindingSource.Count = 0 Then
                Me.EditItm_btn.Enabled = False
                Me.DelItm_btn.Enabled = False
            End If
        ElseIf Me.Typ_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.Grp_cbx.SelectedValue <> Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & -1
                End If
            End If
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.TypesBindingSource.Count > 0 Then
                Me.EditTyp_btn.Enabled = True
                Me.DelTyp_btn.Enabled = True
            ElseIf Me.TypesBindingSource.Count = 0 Then
                Me.EditTyp_btn.Enabled = False
                Me.DelTyp_btn.Enabled = False
            End If
        ElseIf Me.Mat_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.Grp_cbx.SelectedValue <> Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & -1
                End If
            End If
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.MaterialsBindingSource.Count > 0 Then
                Me.EditMat_btn.Enabled = True
                Me.DelMat_btn.Enabled = True
            ElseIf Me.MaterialsBindingSource.Count = 0 Then
                Me.EditMat_btn.Enabled = False
                Me.DelMat_btn.Enabled = False
            End If
        ElseIf Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.Grp_cbx.SelectedValue <> Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & -1
                End If
            End If
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
            If Me.SizeBindingSource.Count = 0 Then
                Me.EditSiz_btn.Enabled = False
                Me.DelSiz_btn.Enabled = False
            ElseIf Me.SizeBindingSource.Count > 0 Then
                Me.EditSiz_btn.Enabled = True
                Me.DelSiz_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Itm_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itm_cbx.SelectedValueChanged
        If Me.Itm_btn.BackColor = Color.PaleTurquoise Then
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.ItemsBindingSource.Count = 0 Then
                    Me.EditItm_btn.Enabled = False
                    Me.DelItm_btn.Enabled = False
                ElseIf Me.ItemsBindingSource.Count > 0 Then
                    Me.EditItm_btn.Enabled = True
                    Me.DelItm_btn.Enabled = True
                End If
            End If
        ElseIf Me.Typ_btn.BackColor = Color.PaleTurquoise Then
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.TypesBindingSource.Count > 0 Then
                Me.EditTyp_btn.Enabled = True
                Me.DelTyp_btn.Enabled = True
            ElseIf Me.TypesBindingSource.Count = 0 Then
                Me.EditTyp_btn.Enabled = False
                Me.DelTyp_btn.Enabled = False
            End If
        ElseIf Me.Mat_btn.BackColor = Color.PaleTurquoise Then
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.MaterialsBindingSource.Count > 0 Then
                Me.EditMat_btn.Enabled = True
                Me.DelMat_btn.Enabled = True
            ElseIf Me.MaterialsBindingSource.Count = 0 Then
                Me.EditMat_btn.Enabled = False
                Me.DelMat_btn.Enabled = False
            End If
        ElseIf Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
            End If
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
            If Me.SizeBindingSource.Count = 0 Then
                Me.EditSiz_btn.Enabled = False
                Me.DelSiz_btn.Enabled = False
            ElseIf Me.SizeBindingSource.Count > 0 Then
                Me.EditSiz_btn.Enabled = True
                Me.DelSiz_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Typ_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_cbx.SelectedValueChanged
        If Me.Typ_btn.BackColor = Color.PaleTurquoise Then
            If Me.TypesBindingSource.Count > 0 Then
                Me.EditTyp_btn.Enabled = True
                Me.DelTyp_btn.Enabled = True
            ElseIf Me.TypesBindingSource.Count = 0 Then
                Me.EditTyp_btn.Enabled = False
                Me.DelTyp_btn.Enabled = False
            End If
        ElseIf Me.Mat_btn.BackColor = Color.PaleTurquoise Then
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.MaterialsBindingSource.Count > 0 Then
                Me.EditMat_btn.Enabled = True
                Me.DelMat_btn.Enabled = True
            ElseIf Me.MaterialsBindingSource.Count = 0 Then
                Me.EditMat_btn.Enabled = False
                Me.DelMat_btn.Enabled = False
            End If
        ElseIf Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
            End If
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
            If Me.SizeBindingSource.Count = 0 Then
                Me.EditSiz_btn.Enabled = False
                Me.DelSiz_btn.Enabled = False
            ElseIf Me.SizeBindingSource.Count > 0 Then
                Me.EditSiz_btn.Enabled = True
                Me.DelSiz_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Mat_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat_cbx.SelectedValueChanged
        If Me.Mat_btn.BackColor = Color.PaleTurquoise Then
            If Me.MaterialsBindingSource.Count > 0 Then
                Me.EditMat_btn.Enabled = True
                Me.DelMat_btn.Enabled = True
            ElseIf Me.MaterialsBindingSource.Count = 0 Then
                Me.EditMat_btn.Enabled = False
                Me.DelMat_btn.Enabled = False
            End If
        ElseIf Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
            If Me.SizeBindingSource.Count = 0 Then
                Me.EditSiz_btn.Enabled = False
                Me.DelSiz_btn.Enabled = False
            ElseIf Me.SizeBindingSource.Count > 0 Then
                Me.EditSiz_btn.Enabled = True
                Me.DelSiz_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub Siz_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siz_cbx.SelectedValueChanged
        If Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.SizeBindingSource.Count = 0 Then
                Me.EditSiz_btn.Enabled = False
                Me.DelSiz_btn.Enabled = False
            ElseIf Me.SizeBindingSource.Count > 0 Then
                Me.EditSiz_btn.Enabled = True
                Me.DelSiz_btn.Enabled = True
            End If
        End If
    End Sub

    Private Sub EditGrp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditGrp_btn.Click
        If Me.EditGrp_btn.Tag = "" Then
            Index = Me.Grp_cbx.SelectedValue
            Me.Grp_tbx.Text = Me.Grp_cbx.Text
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
            Me.Grp_tbx.BackColor = Color.White
            Me.Grp_tbx.ReadOnly = False
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
            Me.DelGrp_btn.Enabled = False
            Me.EditGrp_btn.Text = "Save"
            Me.EditGrp_btn.Tag = "S"
            Me.Grp_tbx.Focus()
        ElseIf Me.EditGrp_btn.Tag = "S" Then
            Dim EditGrp As InventoryDataSet.GroupsRow
            EditGrp = Me.MainInventoryDataSet.Groups.FindByGroupID(Index)
            EditGrp.BeginEdit()
            EditGrp.Category = Me.Grp_tbx.Text
            EditGrp.EndEdit()
            Me.GroupsTableAdapter.Update(EditGrp)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
            Me.EditGrp_btn.Text = "Edit"
            Me.DelGrp_btn.Enabled = True
            Me.EditGrp_btn.Tag = ""
        End If
    End Sub

    Private Sub EditItm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditItm_btn.Click
        If Me.EditItm_btn.Tag = "" Then
            Index = Me.Itm_cbx.SelectedValue
            Me.Grp_tbx.Text = Me.Grp_cbx.Text
            Me.Itm_tbx.Text = Me.Itm_cbx.Text
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
            Me.Grp_tbx.BackColor = Color.LightYellow
            Me.Grp_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
            Me.Itm_tbx.BackColor = Color.White
            Me.Itm_tbx.ReadOnly = False
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_tbx)
            Me.DelItm_btn.Enabled = False
            Me.EditItm_btn.Text = "Save"
            Me.EditItm_btn.Tag = "S"
        ElseIf Me.EditItm_btn.Tag = "S" Then
            Dim EditItm As InventoryDataSet.ItemsRow
            EditItm = Me.MainInventoryDataSet.Items.FindByItemID(Index)
            EditItm.BeginEdit()
            EditItm.ItemName = Me.Itm_tbx.Text
            EditItm.EndEdit()
            Me.ItemsTableAdapter.Update(EditItm)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
            Me.EditItm_btn.Text = "Edit"
            Me.DelItm_btn.Enabled = True
            Me.EditItm_btn.Tag = ""
        End If
    End Sub

    Private Sub EditTyp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditTyp_btn.Click
        If Me.EditTyp_btn.Tag = "" Then
            Index = Me.Typ_cbx.SelectedValue
            Me.Grp_tbx.Text = Me.Grp_cbx.Text
            Me.Itm_tbx.Text = Me.Itm_cbx.Text
            Me.Typ_tbx.Text = Me.Typ_cbx.Text
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
            Me.Grp_tbx.BackColor = Color.LightYellow
            Me.Grp_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
            Me.Itm_tbx.BackColor = Color.LightYellow
            Me.Itm_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
            Me.Typ_tbx.BackColor = Color.White
            Me.Typ_tbx.ReadOnly = False
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_tbx)
            Me.DelTyp_btn.Enabled = False
            Me.EditTyp_btn.Text = "Save"
            Me.EditTyp_btn.Tag = "S"
        ElseIf Me.EditTyp_btn.Tag = "S" Then
            Dim EditTyp As InventoryDataSet.TypesRow
            EditTyp = Me.MainInventoryDataSet.Types.FindByTypeID(Index)
            EditTyp.BeginEdit()
            EditTyp.Type = Me.Typ_tbx.Text
            EditTyp.EndEdit()
            Me.TypesTableAdapter.Update(EditTyp)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
            Me.EditTyp_btn.Text = "Edit"
            Me.DelTyp_btn.Enabled = True
            Me.EditTyp_btn.Tag = ""
        End If
    End Sub

    Private Sub EditMat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMat_btn.Click
        If Me.EditMat_btn.Tag = "" Then
            Index = Me.Mat_cbx.SelectedValue
            Me.Grp_tbx.Text = Me.Grp_cbx.Text
            Me.Itm_tbx.Text = Me.Itm_cbx.Text
            Me.Typ_tbx.Text = Me.Typ_cbx.Text
            Me.Mat_tbx.Text = Me.Mat_cbx.Text
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
            Me.Grp_tbx.BackColor = Color.LightYellow
            Me.Grp_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
            Me.Itm_tbx.BackColor = Color.LightYellow
            Me.Itm_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
            Me.Typ_tbx.BackColor = Color.LightYellow
            Me.Typ_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
            Me.Mat_tbx.BackColor = Color.White
            Me.Mat_tbx.ReadOnly = False
            Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_tbx)
            Me.DelMat_btn.Enabled = False
            Me.EditMat_btn.Text = "Save"
            Me.EditMat_btn.Tag = "S"
        ElseIf Me.EditMat_btn.Tag = "S" Then
            Dim EditMat As InventoryDataSet.MaterialsRow
            EditMat = Me.MainInventoryDataSet.Materials.FindByMatID(Index)
            EditMat.BeginEdit()
            EditMat.Material = Me.Mat_tbx.Text
            EditMat.EndEdit()
            Me.MaterialsTableAdapter.Update(EditMat)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
            Me.EditMat_btn.Text = "Edit"
            Me.DelMat_btn.Enabled = True
            Me.EditMat_btn.Tag = ""
        End If
    End Sub

    Private Sub EditSiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSiz_btn.Click
        If Me.EditSiz_btn.Tag = "" Then
            Index = Me.Siz_cbx.SelectedValue
            Me.Grp_tbx.Text = Me.Grp_cbx.Text
            Me.Itm_tbx.Text = Me.Itm_cbx.Text
            Me.Typ_tbx.Text = Me.Typ_cbx.Text
            Me.Mat_tbx.Text = Me.Mat_cbx.Text
            Me.Siz_tbx.Text = Me.Siz_cbx.Text
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
            Me.Grp_tbx.BackColor = Color.LightYellow
            Me.Grp_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
            Me.Itm_tbx.BackColor = Color.LightYellow
            Me.Itm_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
            Me.Typ_tbx.BackColor = Color.LightYellow
            Me.Typ_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
            Me.Mat_tbx.BackColor = Color.LightYellow
            Me.Mat_tbx.ReadOnly = True
            Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
            Me.Siz_tbx.BackColor = Color.White
            Me.Siz_tbx.ReadOnly = False
            Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_tbx)
            Me.DelSiz_btn.Enabled = False
            Me.EditSiz_btn.Text = "Save"
            Me.EditSiz_btn.Tag = "S"
        ElseIf Me.EditSiz_btn.Tag = "S" Then
            Dim EditSiz As InventoryDataSet.SizeRow
            EditSiz = Me.MainInventoryDataSet.Size.FindBySizeID(Index)
            EditSiz.BeginEdit()
            EditSiz.Size = Me.Siz_tbx.Text
            EditSiz.EndEdit()
            Me.SizeTableAdapter.Update(EditSiz)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
            Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_cbx)
            Me.EditSiz_btn.Text = "Edit"
            Me.DelSiz_btn.Enabled = True
            Me.EditSiz_btn.Tag = ""
        End If
    End Sub

    Private Sub DelGrp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelGrp_btn.Click
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("The Group " + Me.Grp_cbx.Text + " will be deleted. Are you sure to delete it?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = System.Windows.Forms.DialogResult.OK Then
                Call DDetails("GroupID =" & Me.Grp_cbx.SelectedValue)
                Call DItems(Me.Grp_cbx.SelectedValue)
                Dim DGrp As InventoryDataSet.GroupsRow
                DGrp = Me.MainInventoryDataSet.Groups.FindByGroupID(Me.Grp_cbx.SelectedValue)
                DGrp.Delete()
                Me.GroupsTableAdapter.Update(Me.MainInventoryDataSet)
            End If
        End If
    End Sub

    Private Sub DelItm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelItm_btn.Click
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("The Item " + Me.Itm_cbx.Text + " will be deleted. Are you sure to delete it?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = System.Windows.Forms.DialogResult.OK Then
                Call DDetails("ItemID =" & Me.Itm_cbx.SelectedValue)
                Call DTypes(Me.Itm_cbx.SelectedValue)
                Dim DItem As InventoryDataSet.ItemsRow
                DItem = Me.MainInventoryDataSet.Items.FindByItemID(Me.Itm_cbx.SelectedValue)
                DItem.Delete()
                Me.ItemsTableAdapter.Update(Me.MainInventoryDataSet)
            End If
        End If
    End Sub

    Private Sub DelTyp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelTyp_btn.Click
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("The Type " + Me.Typ_cbx.Text + " will be deleted. Are you sure to delete it?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = System.Windows.Forms.DialogResult.OK Then
                Call DDetails("TypeID =" & Me.Typ_cbx.SelectedValue)
                Call DMats(Me.Typ_cbx.SelectedValue)
                Dim DType As InventoryDataSet.TypesRow
                DType = Me.MainInventoryDataSet.Types.FindByTypeID(Me.Typ_cbx.SelectedValue)
                DType.Delete()
                Me.TypesTableAdapter.Update(Me.MainInventoryDataSet)
            End If
        End If
    End Sub

    Private Sub DelMat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelMat_btn.Click
        If Me.Mat_cbx.SelectedValue <> Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("The Material " + Me.Mat_cbx.Text + " will be deleted. Are you sure to delete it?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = System.Windows.Forms.DialogResult.OK Then
                Call DDetails("MatID =" & Me.Mat_cbx.SelectedValue)
                Call DSizes(Me.Mat_cbx.SelectedValue)
                Dim DMat As InventoryDataSet.MaterialsRow
                DMat = Me.MainInventoryDataSet.Materials.FindByMatID(Me.Mat_cbx.SelectedValue)
                DMat.Delete()
                Me.MaterialsTableAdapter.Update(Me.MainInventoryDataSet)
            End If
        End If
    End Sub

    Private Sub DelSiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelSiz_btn.Click
        If Me.Siz_cbx.SelectedValue <> Nothing Then
            Dim result As DialogResult
            result = MessageBox.Show("The Size " + Me.Siz_cbx.Text + " will be deleted. Are you sure to delete it?", "Confirm delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = System.Windows.Forms.DialogResult.OK Then
                Call DDetails("SizeID =" & Me.Siz_cbx.SelectedValue)
                Dim DSiz As InventoryDataSet.SizeRow
                DSiz = Me.MainInventoryDataSet.Size.FindBySizeID(Me.Siz_cbx.SelectedValue)
                DSiz.Delete()
                Me.SizeTableAdapter.Update(Me.MainInventoryDataSet)
            End If
        End If
    End Sub

#Region "Methods"
    Private Sub DItems(ByVal GrpID As Integer)
        Dim DItems() As InventoryDataSet.ItemsRow
        DItems = Me.MainInventoryDataSet.Items.Select("GroupID =" & GrpID)
        If DItems.Length > 0 Then
            Dim DItem As InventoryDataSet.ItemsRow
            For Each DItem In DItems
                Call DTypes(DItem.ItemID)
                DItem.Delete()
            Next
            Me.ItemsTableAdapter.Update(Me.MainInventoryDataSet)
        End If
    End Sub

    Private Sub DTypes(ByVal ItmID As Integer)
        Dim DTypes() As InventoryDataSet.TypesRow
        DTypes = Me.MainInventoryDataSet.Types.Select("ItemID =" & ItmID)
        If DTypes.Length > 0 Then
            Dim DType As InventoryDataSet.TypesRow
            For Each DType In DTypes
                Call DMats(DType.TypeID)
                DType.Delete()
            Next
            Me.TypesTableAdapter.Update(Me.MainInventoryDataSet)
        End If
    End Sub

    Private Sub DMats(ByVal TypID As Integer)
        Dim DMats() As InventoryDataSet.MaterialsRow
        DMats = Me.MainInventoryDataSet.Materials.Select("TypeID =" & TypID)
        If DMats.Length > 0 Then
            Dim DMat As InventoryDataSet.MaterialsRow
            For Each DMat In DMats
                Call DSizes(DMat.MatID)
                DMat.Delete()
            Next
            Me.MaterialsTableAdapter.Update(Me.MainInventoryDataSet)
        End If
    End Sub

    Private Sub DSizes(ByVal MatID As Integer)
        Dim DSizes() As InventoryDataSet.SizeRow
        DSizes = Me.MainInventoryDataSet.Size.Select("MatID =" & MatID)
        If DSizes.Length > 0 Then
            Dim DSize As InventoryDataSet.SizeRow
            For Each DSize In DSizes
                DSize.Delete()
            Next
            Me.SizeTableAdapter.Update(Me.MainInventoryDataSet)
        End If
    End Sub

    Private Sub DDetails(ByVal ID As String)
        Dim DDetails() As InventoryDataSet.Details1Row
        DDetails = Me.MainInventoryDataSet.Details1.Select(ID)
        If DDetails.Length > 0 Then
            Dim DDetail As InventoryDataSet.Details1Row
            For Each DDetail In DDetails
                DDetail.Delete()
            Next
            Me.Details1TableAdapter.Update(Me.MainInventoryDataSet)
        End If
    End Sub

#End Region

End Class