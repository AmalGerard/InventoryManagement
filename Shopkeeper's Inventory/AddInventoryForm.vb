Public Class AddInventoryForm

    Private Sub Grp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_btn.Click
        Me.AcceptButton = Me.AddGrp_btn
        Me.Grp_btn.BackColor = Color.PaleTurquoise
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_lbl)
        Me.Grp_lbl.Text = "New Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddGrp_btn)
        Me.Avl_lbl.Text = "Available Categories:"
        Me.Avl_lbx.DataSource = Me.GroupBindingSource
        Me.Avl_lbx.DisplayMember = "Category"
        Me.Avl_lbx.ValueMember = "GroupID"
        Me.Grp_tbx.Focus()
    End Sub

    Private Sub Itm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itm_btn.Click
        Me.AcceptButton = Me.AddItm_btn
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.PaleTurquoise
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Avl_lbx.DataSource = Me.ItemsBindingSource
        Me.Avl_lbx.DisplayMember = "ItemName"
        Me.Avl_lbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "New Item:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddItm_btn)
        Me.Avl_lbl.Text = "Available Items:"
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Typ_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_btn.Click
        Me.AcceptButton = Me.AddTyp_btn
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.PaleTurquoise
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Avl_lbx.DataSource = Me.TypesBindingSource
        Me.Avl_lbx.DisplayMember = "Type"
        Me.Avl_lbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "New Type:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddTyp_btn)
        Me.Avl_lbl.Text = "Available Types:"
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Mat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat_btn.Click
        Me.AcceptButton = Me.AddMat_btn
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.PaleTurquoise
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
        Else
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
        End If
        Me.Avl_lbx.DataSource = Me.MaterialsBindingSource
        Me.Avl_lbx.DisplayMember = "Material"
        Me.Avl_lbx.ValueMember = "MatID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "New Material:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddMat_btn)
        Me.Avl_lbl.Text = "Available Materials:"
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Size_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Size_btn.Click
        Me.AcceptButton = Me.AddSiz_btn
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.PaleTurquoise
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "Select a Material:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
        Else
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
        End If
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        If Me.Mat_cbx.SelectedValue <> Nothing Then
            Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
        Else
            Me.SizeBindingSource.Filter = "MatID =" & -1
        End If
        Me.Avl_lbx.DataSource = Me.SizeBindingSource
        Me.Avl_lbx.DisplayMember = "Size"
        Me.Avl_lbx.ValueMember = "SizeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_lbl)
        Me.Siz_lbl.Text = "New Size:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddSiz_btn)
        Me.Avl_lbl.Text = "Available Sizes:"
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub Dtl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtl_btn.Click
        Me.AcceptButton = Me.AddDtl_btn
        Me.Grp_btn.BackColor = Color.Transparent
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.PaleTurquoise
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "Select a Material:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Mat_cbx)
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
        Else
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
        End If
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_lbl)
        Me.Siz_lbl.Text = "Select a Size:"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Siz_cbx)
        If Me.Mat_cbx.SelectedValue <> Nothing Then
            Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
        Else
            Me.SizeBindingSource.Filter = "MatID =" & -1
        End If
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        If Me.Siz_cbx.SelectedValue <> Nothing Then
            Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
        Else
            Me.Details1BindingSource.Filter = "SizeID =" & -1
        End If
        Me.Avl_lbx.DataSource = Me.Details1BindingSource
        Me.Avl_lbx.DisplayMember = "Code"
        Me.Avl_lbx.ValueMember = "Code"
        Me.SplitContainer1.Panel2.Controls.Add(Me.Code_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Code_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Price_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Price_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Nos_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Nos_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Desc_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Desc_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddDtl_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Ref_lbl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Ref_tbx)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Browse_btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Import_ckbx)
        Me.Avl_lbl.Text = "Available Products:"
        Me.Grp_cbx.Focus()
    End Sub

    Private Sub AddGrp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddGrp_btn.Click
        Dim Index As Integer = Me.GroupBindingSource.Find("Category", Me.Grp_tbx.Text)
        If Me.Grp_tbx.Text <> "" And Index = -1 Then
            Call AddGroup()
        ElseIf Index <> -1 Then
            MessageBox.Show("The Category '" & Me.Grp_tbx.Text & "' already exists.")
        ElseIf Me.Grp_tbx.Text = "" Then
            MessageBox.Show("Enter a name for the Category to be added.", "Enter Category", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub AddItm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItm_btn.Click
        Dim Index As Integer = Me.ItemsBindingSource.Find("ItemName", Me.Itm_tbx.Text)
        If Me.Grp_cbx.SelectedIndex < 0 Then
            MessageBox.Show("Select a group to which you need to add the item. If there are no groups listed add one using the 'Add Category' tab.", "Select Group", MessageBoxButtons.OK)
        ElseIf Me.Itm_tbx.Text = "" Then
            MessageBox.Show("Enter a name for the item to be added.", "Item Name missing", MessageBoxButtons.OK)
        ElseIf Index <> -1 Then
            MessageBox.Show("The Item '" & Me.Itm_tbx.Text & "' already exists.")
        ElseIf Me.Itm_tbx.Text <> "" And Index = -1 Then
            Call AddItem()
        End If
    End Sub

    Private Sub AddTyp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTyp_btn.Click
        Dim Index As Integer = Me.TypesBindingSource.Find("Type", Me.Typ_tbx.Text)
        If Me.Itm_cbx.SelectedIndex < 0 Then
            MessageBox.Show("Select an item to which you need to add the type. If there are no items listed add one using the 'Add Item' tab.", "Select Item", MessageBoxButtons.OK)
        ElseIf Me.Typ_tbx.Text = "" Then
            MessageBox.Show("Specify a name for the item type to be added.", "Type Name missing", MessageBoxButtons.OK)
        ElseIf Index <> -1 Then
            MessageBox.Show("The Type'" & Me.Typ_tbx.Text & "' already exists.")
        ElseIf Me.Typ_tbx.Text <> "" And Index = -1 Then
            Call AddType()
        End If
    End Sub

    Private Sub AddMat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMat_btn.Click
        Dim Index As Integer = Me.MaterialsBindingSource.Find("Material", Me.Mat_tbx.Text)
        If Me.Typ_cbx.SelectedIndex < 0 Then
            MessageBox.Show("Select an item type to which you need to add the material. If there are no items types listed add one using the 'Add Type' tab.", "Select Type", MessageBoxButtons.OK)
        ElseIf Me.Mat_tbx.Text = "" Then
            MessageBox.Show("Specify a name for the material to be added.", "Material Name missing", MessageBoxButtons.OK)
        ElseIf Index <> -1 Then
            MessageBox.Show("The Material'" & Me.Mat_tbx.Text & "' already exists.")
        ElseIf Me.Mat_tbx.Text <> "" And Index = -1 Then
            Call AddMat()
        End If
    End Sub

    Private Sub AddSiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSiz_btn.Click
        Dim Index As Integer = Me.SizeBindingSource.Find("Size", Me.Siz_tbx.Text)
        If Me.Mat_cbx.SelectedIndex < 0 Then
            MessageBox.Show("Select a material to which you need to add the size. If there are no materials listed add one using the 'Add Material' tab.", "Select Material", MessageBoxButtons.OK)
        ElseIf Me.Siz_tbx.Text = "" Then
            MessageBox.Show("Specify the size to be added.", "Size missing", MessageBoxButtons.OK)
        ElseIf Index <> -1 Then
            MessageBox.Show("The Size'" & Me.Siz_tbx.Text & "' already exists.")
        ElseIf Me.Siz_tbx.Text <> "" And Index = -1 Then
            Call AddSize()
        End If
    End Sub

    Private Sub AddDtl_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDtl_btn.Click
        Dim Index As Integer = Me.Details1BindingSource.Find("Code", Me.Code_tbx.Text)
        If Me.Siz_cbx.SelectedIndex < 0 Then
            MessageBox.Show("Select a size for the product. If there are no size listed, add one using the 'Add a Size' tab.", "Select Size", MessageBoxButtons.OK)
        ElseIf Me.Code_tbx.Text = "" Then
            MessageBox.Show("Enter an unique code for the product.", "Product Code missing", MessageBoxButtons.OK)
        ElseIf Index <> -1 Then
            MessageBox.Show("The Product'" & Me.Code_tbx.Text & "' already exists.")
        ElseIf Me.Price_tbx.Text = "" Then
            MessageBox.Show("Specify the Item price to be added.", "Item price missing", MessageBoxButtons.OK)
        ElseIf Me.Code_tbx.Text <> "" And Me.Price_tbx.Text <> "" And Index = -1 Then
            If IsNumeric(Me.Price_tbx.Text.Trim) = False Then
                MessageBox.Show("Enter only numbers as price, do not include alphabets.", "Price!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            Call AddDetails()
        End If
    End Sub

#Region "Methods"

    Public Sub AddGroup()
        Dim NewGroup As InventoryDataSet.GroupsRow
        NewGroup = MainInventoryDataSet.Groups.NewGroupsRow
        NewGroup.Category = Me.Grp_tbx.Text
        Me.MainInventoryDataSet.Groups.AddGroupsRow(NewGroup)
        Me.GroupsTableAdapter.Update(NewGroup)
        NewGroup = Nothing
        Me.StatusLabel.Text = "The Group '" + Me.Grp_tbx.Text + "' has been added successfully."
        Me.Grp_tbx.Text = ""
    End Sub

    Public Sub AddItem()
        Dim NewItem As InventoryDataSet.ItemsRow
        NewItem = Me.MainInventoryDataSet.Items.NewItemsRow
        NewItem.ItemName = Me.Itm_tbx.Text
        NewItem.GroupID = Me.Grp_cbx.SelectedValue
        Me.MainInventoryDataSet.Items.AddItemsRow(NewItem)
        Me.ItemsTableAdapter.Update(NewItem)
        NewItem = Nothing
        Me.StatusLabel.Text = "The Item '" + Me.Itm_tbx.Text + "' has been added successfully."
        Me.Itm_tbx.Text = ""
    End Sub

    Public Sub AddType()
        Dim NewType As InventoryDataSet.TypesRow
        NewType = Me.MainInventoryDataSet.Types.NewTypesRow
        NewType.Type = Me.Typ_tbx.Text
        NewType.ItemID = Me.Itm_cbx.SelectedValue
        Me.MainInventoryDataSet.Types.AddTypesRow(NewType)
        Me.TypesTableAdapter.Update(NewType)
        NewType = Nothing
        Me.StatusLabel.Text = "The Item Type '" + Me.Typ_tbx.Text + "' has been added successfully."
        Me.Typ_tbx.Text = ""
    End Sub

    Public Sub AddMat()
        Dim NewMat As InventoryDataSet.MaterialsRow
        NewMat = Me.MainInventoryDataSet.Materials.NewMaterialsRow
        NewMat.Material = Me.Mat_tbx.Text
        NewMat.TypeID = Me.Typ_cbx.SelectedValue
        Me.MainInventoryDataSet.Materials.AddMaterialsRow(NewMat)
        Me.MaterialsTableAdapter.Update(NewMat)
        NewMat = Nothing
        Me.StatusLabel.Text = "The Material '" + Me.Mat_tbx.Text + "' has been added successfully."
        Me.Mat_tbx.Text = ""
    End Sub

    Public Sub AddSize()
        Dim NewSize As InventoryDataSet.SizeRow
        NewSize = Me.MainInventoryDataSet.Size.NewSizeRow
        NewSize.Size = Me.Siz_tbx.Text
        NewSize.MatID = Me.Mat_cbx.SelectedValue
        Me.MainInventoryDataSet.Size.AddSizeRow(NewSize)
        Me.SizeTableAdapter.Update(NewSize)
        NewSize = Nothing
        Me.StatusLabel.Text = "The Size '" + Me.Siz_tbx.Text + "' has been added successfully."
        Me.Siz_tbx.Text = ""
    End Sub

    Public Sub AddDetails()
        Dim NewDetails As InventoryDataSet.Details1Row
        NewDetails = Me.MainInventoryDataSet.Details1.NewDetails1Row
        NewDetails.Code = Me.Code_tbx.Text
        NewDetails.GroupID = Me.Grp_cbx.SelectedValue
        NewDetails.ItemID = Me.Itm_cbx.SelectedValue
        NewDetails.TypeID = Me.Typ_cbx.SelectedValue
        NewDetails.MatID = Me.Mat_cbx.SelectedValue
        NewDetails.SizeID = Me.Siz_cbx.SelectedValue
        NewDetails.Price = CDbl(Me.Price_tbx.Text)
        If Me.Nos_tbx.Text <> "" Then
            NewDetails.Available_Nos = CInt(Me.Nos_tbx.Text)
        ElseIf Me.Nos_tbx.Text = "" Then
            NewDetails.Available_Nos = 0
        End If
        NewDetails.Description = Me.Desc_tbx.Text
        If Me.Import_ckbx.Checked And My.Computer.FileSystem.FileExists(Me.Ref_tbx.Text) Then
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).Extension
            If My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                NewDetails.Reference = Me.Ref_tbx.Text
            ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ref") Then
                My.Computer.FileSystem.CopyFile(Me.Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext, True)
                NewDetails.Reference = My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext
            Else
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\Ref")
                My.Computer.FileSystem.CopyFile(Me.Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext, True)
                NewDetails.Reference = My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext
            End If
        ElseIf Me.Import_ckbx.Checked = False Then
            NewDetails.Reference = Me.Ref_tbx.Text
        End If
        Me.MainInventoryDataSet.Details1.AddDetails1Row(NewDetails)
        Me.Details1TableAdapter.Update(NewDetails)
        NewDetails = Nothing
        Me.StatusLabel.Text = "The Product has been added to your inventory."
        Me.Code_tbx.Text = ""
        Me.Price_tbx.Text = ""
        Me.Nos_tbx.Text = ""
        Me.Desc_tbx.Text = ""
        Me.Ref_tbx.Text = ""
        Me.Import_ckbx.Checked = False
    End Sub

#End Region

    Private Sub AddInventoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Details1' table. You can move, or remove it, as needed.
        Me.Details1TableAdapter.Fill(Me.MainInventoryDataSet.Details1)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Details' table. You can move, or remove it, as needed.
        'Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
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
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.MainInventoryDataSet.Items)
        Me.Avl_lbx.DataSource = Me.GroupBindingSource
        Me.Avl_lbx.DisplayMember = "Category"
        Me.Avl_lbx.ValueMember = "GroupID"

        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        Me.Price_lbl.Text = "Price (" & Currency & "):"

    End Sub

    Private Sub AddInventoryForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Visible = True
        MainForm.Enabled = True
    End Sub

    Private Sub Browse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse_btn.Click
        Dim Result As DialogResult
        Result = Me.RefFile_dbx.ShowDialog()
        If Result = System.Windows.Forms.DialogResult.OK Then
            Me.Ref_tbx.Text = Me.RefFile_dbx.FileName
            Me.Ref_tbx.Focus()
        End If
    End Sub

    Private Sub Grp_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_cbx.SelectedValueChanged
        If Me.Itm_btn.BackColor = Color.PaleTurquoise Then
            If Me.Grp_cbx.ValueMember <> "" Then
                If Me.Grp_cbx.SelectedValue <> Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                ElseIf Me.Grp_cbx.SelectedValue = Nothing Then
                    Me.ItemsBindingSource.Filter = "GroupID =" & -1
                End If
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
        ElseIf Me.Dtl_btn.BackColor = Color.PaleTurquoise Then
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
            If Me.Siz_cbx.ValueMember <> "" Then
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                ElseIf Me.Siz_cbx.SelectedValue = Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Itm_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itm_cbx.SelectedValueChanged
        
        If Me.Typ_btn.BackColor = Color.PaleTurquoise Then
            If Me.Itm_cbx.ValueMember <> "" Then
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                ElseIf Me.Itm_cbx.SelectedValue = Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & -1
                End If
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
        ElseIf Me.Dtl_btn.BackColor = Color.PaleTurquoise Then
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
            If Me.Siz_cbx.ValueMember <> "" Then
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                ElseIf Me.Siz_cbx.SelectedValue = Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Typ_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_cbx.SelectedValueChanged
        If Me.Mat_btn.BackColor = Color.PaleTurquoise Then
            If Me.Typ_cbx.ValueMember <> "" Then
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                ElseIf Me.Typ_cbx.SelectedValue = Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & -1
                End If
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
        ElseIf Me.Dtl_btn.BackColor = Color.PaleTurquoise Then
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
            If Me.Siz_cbx.ValueMember <> "" Then
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                ElseIf Me.Siz_cbx.SelectedValue = Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Mat_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat_cbx.SelectedValueChanged
        If Me.Size_btn.BackColor = Color.PaleTurquoise Then
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
        ElseIf Me.Dtl_btn.BackColor = Color.PaleTurquoise Then
            If Me.Mat_cbx.ValueMember <> "" Then
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                ElseIf Me.Mat_cbx.SelectedValue = Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & -1
                End If
            End If
            If Me.Siz_cbx.ValueMember <> "" Then
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                ElseIf Me.Siz_cbx.SelectedValue = Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Siz_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siz_cbx.SelectedValueChanged
        If Me.Dtl_btn.BackColor = Color.PaleTurquoise Then
            If Me.Siz_cbx.ValueMember <> "" Then
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                ElseIf Me.Siz_cbx.SelectedValue = Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Avl_lbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Avl_lbx.SelectedValueChanged
        If Me.Dtl_btn.BackColor = Color.PaleTurquoise And Me.Avl_lbx.ValueMember = "Code" Then
            Dim GetDetails As InventoryDataSet.Details1Row
            GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(Me.Avl_lbx.SelectedValue)
            If GetDetails IsNot Nothing Then
                If My.Computer.FileSystem.FileExists(GetDetails.Reference) Then
                    Try
                        Me.RefPic_pbx.Image = New Bitmap(GetDetails.Reference)

                        If Me.RefPic_pbx.Image.Height > 3000 Or Me.RefPic_pbx.Image.Width > 3000 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 15, Me.RefPic_pbx.Image.Height / 15, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 2000 Or Me.RefPic_pbx.Image.Width > 2000 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 12, Me.RefPic_pbx.Image.Height / 12, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 900 Or Me.RefPic_pbx.Image.Width > 900 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 6, Me.RefPic_pbx.Image.Height / 6, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 750 Or Me.RefPic_pbx.Image.Width > 750 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(CInt(CDbl(Me.RefPic_pbx.Image.Width) / 4), CInt(CDbl(Me.RefPic_pbx.Image.Height) / 4), Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height >= 400 Or Me.RefPic_pbx.Image.Width >= 400 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 3, Me.RefPic_pbx.Image.Height / 3, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height >= 300 Or Me.RefPic_pbx.Image.Width >= 300 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(CInt(CDbl(Me.RefPic_pbx.Image.Width) / 2), CInt(CDbl(Me.RefPic_pbx.Image.Height) / 2), Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height >= 225 Or Me.RefPic_pbx.Image.Width >= 225 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(CInt(CDbl(Me.RefPic_pbx.Image.Width) / 1.5), CInt(CDbl(Me.RefPic_pbx.Image.Height) / 1.5), Nothing, New IntPtr())
                        End If
                        Me.RefPic_pbx.Show()
                    Catch ex As ArgumentException
                        Me.RefPic_pbx.Hide()
                        Exit Sub
                    Catch ex As Exception
                        Me.RefPic_pbx.Hide()
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    Me.RefPic_pbx.Hide()
                End If
            ElseIf GetDetails Is Nothing Then
                Me.RefPic_pbx.Hide()
            End If
        Else
            Me.RefPic_pbx.Hide()
        End If
    End Sub

    
End Class