Imports System.IO

Public Class StockForm

    Private Sub StockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainInventoryDataSet.StockEntry' table. You can move, or remove it, as needed.
        Me.StockEntryTableAdapter.Fill(Me.MainInventoryDataSet.StockEntry)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.StockDetails' table. You can move, or remove it, as needed.
        Me.StockDetailsTableAdapter.Fill(Me.MainInventoryDataSet.StockDetails)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.StockDetails' table. You can move, or remove it, as needed.
        Me.StockDetailsTableAdapter.Fill(Me.MainInventoryDataSet.StockDetails)
        'TODO: This line of code loads data into the 'MainVendorDataSet.CompanyDetails' table. You can move, or remove it, as needed.
        Me.CompanyDetailsTableAdapter.Fill(Me.MainVendorDataSet.CompanyDetails)
        'TODO: This line of code loads data into the 'MainVendorDataSet.Company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.MainVendorDataSet.Company)
        'TODO: This line of code loads data into the 'MainVendorDataSet.CompanyCountry' table. You can move, or remove it, as needed.
        Me.CompanyCountryTableAdapter.Fill(Me.MainVendorDataSet.CompanyCountry)
        'TODO: This line of code loads data into the 'MainVendorDataSet.CompanyPincode' table. You can move, or remove it, as needed.
        Me.CompanyPincodeTableAdapter.Fill(Me.MainVendorDataSet.CompanyPincode)
        'TODO: This line of code loads data into the 'MainVendorDataSet.CompanyState' table. You can move, or remove it, as needed.
        Me.CompanyStateTableAdapter.Fill(Me.MainVendorDataSet.CompanyState)
        'TODO: This line of code loads data into the 'MainVendorDataSet.CompanyCity' table. You can move, or remove it, as needed.
        Me.CompanyCityTableAdapter.Fill(Me.MainVendorDataSet.CompanyCity)
        'TODO: This line of code loads data into the 'VendorDataSet.Vendor' table. You can move, or remove it, as needed.
        Me.VendorTableAdapter.Fill(Me.MainVendorDataSet.Vendor)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.StockEntry' table. You can move, or remove it, as needed.
        Me.StockEntryTableAdapter.Fill(Me.MainInventoryDataSet.StockEntry)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
        'TODO: This line of code loads data into the 'InventoryDataSet.Groups' table. You can move, or remove it, as needed.
        Me.GroupsTableAdapter.Fill(Me.MainInventoryDataSet.Groups)
        'TODO: This line of code loads data into the 'InventoryDataSet.Types' table. You can move, or remove it, as needed.
        Me.TypesTableAdapter.Fill(Me.MainInventoryDataSet.Types)
        'TODO: This line of code loads data into the 'InventoryDataSet.Size' table. You can move, or remove it, as needed.
        Me.SizeTableAdapter.Fill(Me.MainInventoryDataSet.Size)
        'TODO: This line of code loads data into the 'InventoryDataSet.Materials' table. You can move, or remove it, as needed.
        Me.MaterialsTableAdapter.Fill(Me.MainInventoryDataSet.Materials)
        'TODO: This line of code loads data into the 'InventoryDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.MainInventoryDataSet.Items)
        'TODO: This line of code loads data into the 'InventoryDataSet.Details1' table. You can move, or remove it, as needed.
        Me.Details1TableAdapter.Fill(Me.MainInventoryDataSet.Details1)
        Me.SelVendor_cbx.SelectedIndex = -1
        Me.ViewVendor_cbx.SelectedIndex = -1
        Me.ViewPCode_cbx.SelectedIndex = -1
        Me.City_cbx.SelectedIndex = -1
        Me.Avl_lbx.DataSource = Me.GroupBindingSource
        Me.Avl_lbx.DisplayMember = "Category"
        Me.Avl_lbx.ValueMember = "GroupID"

        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price (" & Currency & ")"
        Me.StockPrice.HeaderText = "Price (" & Currency & ")"
        Me.LinePrice.HeaderText = "Line Price (" & Currency & ")"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price (" & Currency & ")"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Line Price (" & Currency & ")"

        Me.Price_lbl.Text = "Price (" & Currency & "):"
        Me.Rs_lbl.Text = "%         " & Currency
        Me.BillAmt_lbl.Text = "Bill Amount " & Currency
        Me.AmtPay_lbl.Text = "Amount Paid " & Currency
        Me.VRs_lbl.Text = "%         " & Currency
        Me.VBillAmt_lbl.Text = "Bill Amount " & Currency
        Me.VAmtPay_lbl.Text = "Amount Paid " & Currency

    End Sub

    Private Sub StockForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Visible = True
        MainForm.Enabled = True
    End Sub

    Private Sub Grp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_btn.Click
        Me.AcceptButton = Me.AddGrp_btn
        Me.Grp_btn.BackColor = Color.PaleTurquoise
        Me.Typ_btn.BackColor = Color.Transparent
        Me.Mat_btn.BackColor = Color.Transparent
        Me.Size_btn.BackColor = Color.Transparent
        Me.Dtl_btn.BackColor = Color.Transparent
        Me.Itm_btn.BackColor = Color.Transparent
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_lbl)
        Me.Grp_lbl.Text = "New Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddGrp_btn)
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
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_cbx)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "New Item:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddItm_btn)
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
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_cbx)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "New Type:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddTyp_btn)
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
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_cbx)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "New Material:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddMat_btn)
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
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_cbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Import_ckbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "Select a Material:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_cbx)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.Siz_lbl)
        Me.Siz_lbl.Text = "New Size:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddSiz_btn)
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
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Grp_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddGrp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Itm_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddItm_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Typ_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddTyp_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Mat_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddMat_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Siz_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.AddSiz_btn)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Remove(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Remove(Me.Desc_tbx)
        Me.Grp_lbl.Text = "Select a Category:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_cbx)
        If Me.Grp_cbx.SelectedValue <> Nothing Then
            Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
        Else
            Me.ItemsBindingSource.Filter = "GroupID =" & -1
        End If
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Itm_lbl)
        Me.Itm_lbl.Text = "Select an Item:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_lbl)
        Me.Typ_lbl.Text = "Select a Type:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Typ_cbx)
        If Me.Itm_cbx.SelectedValue <> Nothing Then
            Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
        Else
            Me.TypesBindingSource.Filter = "ItemID =" & -1
        End If
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_lbl)
        Me.Mat_lbl.Text = "Select a Material:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Mat_cbx)
        If Me.Typ_cbx.SelectedValue <> Nothing Then
            Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
        Else
            Me.MaterialsBindingSource.Filter = "TypeID =" & -1
        End If
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Siz_lbl)
        Me.Siz_lbl.Text = "Select a Size:"
        Me.SplitContainer3.Panel2.Controls.Add(Me.Siz_cbx)
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
        Me.SplitContainer3.Panel2.Controls.Add(Me.Code_lbl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Code_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Price_lbl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Price_tbx)
        'Me.SplitContainer3.Panel2.Controls.Add(Me.Nos_lbl)
        'Me.SplitContainer3.Panel2.Controls.Add(Me.Nos_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Desc_lbl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Desc_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.AddDtl_btn)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Ref_lbl)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Ref_tbx)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Browse_btn)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Import_ckbx)
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

    Private Sub Browse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse_btn.Click
        Dim Result As DialogResult
        Result = Me.RefFile_dbx.ShowDialog()
        If Result = System.Windows.Forms.DialogResult.OK Then
            Me.Ref_tbx.Text = Me.RefFile_dbx.FileName
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

    Private Sub ColSC2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColSC2_btn.Click
        If Me.ColSC2_btn.Text = ">>>" Then
            Me.SplitContainer2.Panel2Collapsed = True
            Me.ColSC2_btn.Text = "<<<"
            Me.DetailsDataGridView.Columns("SizeDataGridViewTextBoxColumn").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ElseIf Me.ColSC2_btn.Text = "<<<" Then
            Me.DetailsDataGridView.Columns("SizeDataGridViewTextBoxColumn").AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Me.SizeDataGridViewTextBoxColumn.Width = 100
            Me.SplitContainer2.Panel2Collapsed = False
            Me.ColSC2_btn.Text = ">>>"
        End If

    End Sub

    Private Sub ColSC1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColSC1_btn.Click
        If Me.ColSC1_btn.Text = "^ ^ ^" Then
            Me.SplitContainer1.Panel1Collapsed = True
            Me.ColSC1_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ColSC1_btn.Text = "v v v"
        ElseIf Me.ColSC1_btn.Text = "v v v" Then
            Me.SplitContainer1.Panel1Collapsed = False
            Me.ColSC1_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ColSC1_btn.Text = "^ ^ ^"
        End If
    End Sub

    Private Sub AddVendor_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddVendor_btn.Click

        If Me.CompanyName_tbx.Text = "" Then
            MessageBox.Show("Enter the Company to add.", "Company Name Missing!!!", MessageBoxButtons.OK)
        ElseIf Me.VendorName_tbx.Text = "" Then
            MessageBox.Show("Enter the name of the Company's Representative to add.", "Representative Name Missing!!!", MessageBoxButtons.OK)
        ElseIf Me.CompanyName_tbx.Text <> "" And Me.VendorName_tbx.Text <> "" Then
            AddVendor()
            Me.CompanyName_tbx.Text = ""
            Me.VendorName_tbx.Text = ""
            Me.Phone_tbx.Text = ""
            Me.Mobile_tbx.Text = ""
            Me.Fax_tbx.Text = ""
            Me.Email_tbx.Text = ""
            Me.Website_tbx.Text = ""
            Me.AddressLine1_tbx.Text = ""
            Me.AddressLine2_tbx.Text = ""
        End If

    End Sub

    Private Sub City_cbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_cbx.TextChanged
        If Me.City_cbx.SelectedValue = Nothing And Me.City_cbx.Focused Then
            Me.City_cbx.SelectedIndex = Me.City_cbx.FindString(Me.City_cbx.Text)
        End If
    End Sub

    Private Sub City_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles City_cbx.SelectedValueChanged
        If Me.City_cbx.ValueMember <> "" Then
            If Me.City_cbx.SelectedValue <> Nothing Then
                Dim FindState As VendorDataSet.CompanyCityRow
                FindState = Me.MainVendorDataSet.CompanyCity.FindByCityID(Me.City_cbx.SelectedValue)
                Me.CompanyPincodeBindingSource.Filter = "CityID =" & Me.City_cbx.SelectedValue
                Me.CompanyStateBindingSource.Filter = "StateID =" & FindState.StateID
                FindState = Nothing
            ElseIf Me.City_cbx.SelectedValue = Nothing Then
                Me.CompanyPincodeBindingSource.Filter = "CityID =" & -1
                Me.CompanyStateBindingSource.Filter = "StateID =" & -1
            End If
        End If
        If Me.State_cbx.ValueMember <> "" Then
            If Me.State_cbx.SelectedValue <> Nothing Then
                Me.CompanyCountryBindingSource.Filter = "CountryID =" & Me.State_cbx.SelectedValue
            ElseIf Me.State_cbx.SelectedValue = Nothing Then
                Me.CompanyCountryBindingSource.Filter = "CountryID =" & -1
            End If
        End If
        Me.City_cbx.Focus()
    End Sub

    Private Sub Edit_City_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_City_cbx.SelectedValueChanged
        If Me.Edit_City_cbx.ValueMember <> "" Then
            If Me.Edit_City_cbx.SelectedValue <> Nothing Then
                Dim FindState As VendorDataSet.CompanyCityRow
                FindState = Me.MainVendorDataSet.CompanyCity.FindByCityID(Me.Edit_City_cbx.SelectedValue)
                Me.EditPinCode_BS.Filter = "CityID =" & Me.Edit_City_cbx.SelectedValue
                Me.EditState_BS.Filter = "StateID =" & FindState.StateID
                FindState = Nothing
            ElseIf Me.Edit_City_cbx.SelectedValue = Nothing Then
                Me.EditPinCode_BS.Filter = Nothing
                Me.EditState_BS.Filter = Nothing
            End If
        End If
        If Me.Edit_State_cbx.ValueMember <> "" Then
            If Me.Edit_State_cbx.SelectedValue <> Nothing Then
                Me.EditCountry_bs.Filter = "CountryID =" & Me.Edit_State_cbx.SelectedValue
            ElseIf Me.Edit_State_cbx.SelectedValue = Nothing Then
                Me.EditCountry_bs.Filter = "CountryID =" & -1
            End If
        End If
        Me.Edit_City_cbx.Focus()
    End Sub

    Private Sub Edit_Website_llbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Edit_Website_llbl.LinkClicked
        System.Diagnostics.Process.Start(Me.Edit_Website_llbl.Text)
    End Sub

    Private Sub Edit_Vendor_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Vendor_btn.Click
        If Me.Edit_Vendor_btn.Text = "Edit" Then
            If Me.Edit_CompanyName_cbx.SelectedValue <> Nothing Then
                VendorEditReady()
                Me.Delete_Vendor_btn.Enabled = False
            End If
        ElseIf Me.Edit_Vendor_btn.Text = "Save Changes" Then
            Me.Edit_Vendor_btn.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            EditVendor()
            Me.VendorTableAdapter.GetData()
            Me.VendorTableAdapter.Fill(Me.MainVendorDataSet.Vendor)
            EditVendorInitialState()
            Me.Edit_CompanyName_cbx.SelectedIndex = Me.Edit_CompanyName_cbx.FindString(Me.Edit_CompanyName_tbx.Tag)
            Me.Delete_Vendor_btn.Enabled = True
            Me.Cursor = Cursors.Default
            Me.Edit_Vendor_btn.Enabled = True
        End If

    End Sub

    Private Sub Delete_Vendor_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_Vendor_btn.Click
        Me.Delete_Vendor_btn.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Try
            DeleteVendor()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
        Me.Delete_Vendor_btn.Enabled = True
    End Sub

    Private Sub Avl_lbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Avl_lbx.SelectedIndexChanged
        If Me.Avl_lbx.Focused = True And Me.Avl_lbx.ValueMember = "Code" Then
            Dim GetDetails As InventoryDataSet.Details1Row
            GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(Me.Avl_lbx.SelectedValue)
            If GetDetails IsNot Nothing Then
                If My.Computer.FileSystem.FileExists(GetDetails.Reference) Then
                    Try
                        Me.RefPic_pbx.Image = New Bitmap(GetDetails.Reference)

                        If Me.RefPic_pbx.Image.Height > 3000 Or Me.RefPic_pbx.Image.Width > 3000 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 10, Me.RefPic_pbx.Image.Height / 10, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 2000 Or Me.RefPic_pbx.Image.Width > 2000 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 8, Me.RefPic_pbx.Image.Height / 8, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 900 Or Me.RefPic_pbx.Image.Width > 900 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 4, Me.RefPic_pbx.Image.Height / 4, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height > 750 Or Me.RefPic_pbx.Image.Width > 750 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(CInt(CDbl(Me.RefPic_pbx.Image.Width) / 2.5), CInt(CDbl(Me.RefPic_pbx.Image.Height) / 2.5), Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height >= 400 Or Me.RefPic_pbx.Image.Width >= 400 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(Me.RefPic_pbx.Image.Width / 2, Me.RefPic_pbx.Image.Height / 2, Nothing, New IntPtr())
                        ElseIf Me.RefPic_pbx.Image.Height >= 300 Or Me.RefPic_pbx.Image.Width >= 300 Then
                            Me.RefPic_pbx.Image = Me.RefPic_pbx.Image.GetThumbnailImage(CInt(CDbl(Me.RefPic_pbx.Image.Width) / 1.2), CInt(CDbl(Me.RefPic_pbx.Image.Height) / 1.2), Nothing, New IntPtr())
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
            End If
        Else
            Me.RefPic_pbx.Hide()
        End If
    End Sub

    Private Sub DiscPer_tbx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscPer_tbx.Leave
        If Me.DiscPer_tbx.Text = "" Then
            Me.DiscAmt_tbx.Enabled = True
            Me.AmtPay_tbx.Text = Me.BillAmt_tbx.Text
            Exit Sub
        ElseIf Me.DiscPer_tbx.Text = 0 Then
            Me.DiscAmt_tbx.Enabled = True
            Me.AmtPay_tbx.Text = Me.BillAmt_tbx.Text
            Exit Sub
        End If
        If IsNumeric(Me.DiscPer_tbx.Text) = False Then
            MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DiscPer_tbx.Text = ""
            Me.DiscPer_tbx.Focus()
        ElseIf CDbl(Me.DiscPer_tbx.Text) > 100 Then
            MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DiscAmt_tbx.Enabled = False
            Me.DiscPer_tbx.Focus()
        ElseIf CDbl(Me.DiscPer_tbx.Text) < 0 Then
            MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DiscAmt_tbx.Enabled = False
            Me.DiscPer_tbx.Focus()
        ElseIf IsNumeric(Me.DiscPer_tbx.Text) = True And Me.BillAmt_tbx.Text <> "" And Me.DiscPer_tbx.Enabled = True Then
            Me.DiscAmt_tbx.Text = (CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.BillAmt_tbx.Text))).ToString("0.00")
            Me.AmtPay_tbx.Text = (CDbl(Me.BillAmt_tbx.Text) - CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.BillAmt_tbx.Text))).ToString("0.00")
            Me.DiscAmt_tbx.Enabled = False
        ElseIf IsNumeric(Me.DiscPer_tbx.Text) = True And Me.BillAmt_tbx.Text = "" And Me.DiscPer_tbx.Enabled = True Then
            Me.DiscAmt_tbx.Enabled = False
        End If
    End Sub

    Private Sub DiscPer_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscPer_tbx.TextChanged
        If Me.DiscPer_tbx.Text = "" Then
            Me.DiscAmt_tbx.Text = ""
            Me.DiscAmt_tbx.Enabled = True
        ElseIf Me.DiscPer_tbx.Text = 0 Then
            Me.DiscAmt_tbx.Enabled = True
        End If
    End Sub

    Private Sub DiscAmt_tbx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscAmt_tbx.Leave
        If Me.DiscAmt_tbx.Text = "" Then
            Me.DiscPer_tbx.Enabled = True
            Me.AmtPay_tbx.Text = Me.BillAmt_tbx.Text
            Exit Sub
        ElseIf Me.DiscAmt_tbx.Text = 0 Then
            Me.DiscPer_tbx.Enabled = True
            Me.AmtPay_tbx.Text = Me.BillAmt_tbx.Text
            Exit Sub
        End If
        If IsNumeric(Me.DiscAmt_tbx.Text) = False Then
            MessageBox.Show("Enter only number as discount on total.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DiscAmt_tbx.Text = ""
            Me.DiscAmt_tbx.Focus()
        ElseIf CDbl(Me.DiscAmt_tbx.Text) < 0 Then
            MessageBox.Show("Enter a positve number as discount on total.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DiscPer_tbx.Enabled = False
            Me.DiscAmt_tbx.Focus()
        ElseIf IsNumeric(Me.DiscAmt_tbx.Text) = True And Me.BillAmt_tbx.Text <> "" And Me.DiscAmt_tbx.Enabled = True Then
            Me.AmtPay_tbx.Text = CDbl(CDbl(Me.BillAmt_tbx.Text) - CDbl(Me.DiscAmt_tbx.Text)).ToString("0.00")
            Me.DiscPer_tbx.Enabled = False
        ElseIf IsNumeric(Me.DiscAmt_tbx.Text) = True And Me.BillAmt_tbx.Text = "" And Me.DiscAmt_tbx.Enabled = True Then
            Me.DiscPer_tbx.Enabled = False
        End If
    End Sub

    Private Sub DiscAmt_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscAmt_tbx.TextChanged
        If Me.DiscAmt_tbx.Text = "" Then
            Me.DiscPer_tbx.Text = ""
            Me.DiscPer_tbx.Enabled = True
        ElseIf Me.DiscAmt_tbx.Text = 0 Then
            Me.DiscPer_tbx.Enabled = True
        End If
    End Sub

    Private Sub DetailsDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DetailsDataGridView.KeyPress
        If e.KeyChar = "r" Or e.KeyChar = "R" Then
            ShowRef()
        ElseIf e.KeyChar = ChrW(Keys.Space) Then
            Me.TabControl3.SelectTab(0)
            Me.Add_StockDataGridView.Rows.Add()
            Me.Add_StockDataGridView.CurrentCell = Me.Add_StockDataGridView.Rows(Me.Add_StockDataGridView.Rows.Count - 2).Cells(0)
            FillRow(Me.DetailsDataGridView.CurrentRow.Cells(0).Value.ToString)
            Me.Add_StockDataGridView.Focus()
            Me.Add_StockDataGridView.CurrentCell = Me.Add_StockDataGridView.CurrentRow.Cells(4)
        End If
    End Sub

    Private Sub Add_StockDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Add_StockDataGridView.CellEndEdit
        If e.ColumnIndex = 1 Then
            Dim PCode As String = Me.Add_StockDataGridView.CurrentCell.Value
            If PCode <> "" Then
                FillRow(PCode)
            End If
        ElseIf e.ColumnIndex = 2 Then
            Dim PCode As String = ""
            If Me.Add_StockDataGridView.Focused = True Then
                PCode = Me.DetailsDataGridView.CurrentRow.Cells(0).Value.ToString
            End If
            If Me.Add_StockDataGridView.CurrentCell.Value <> "" And PCode <> "" Then
                FillRow(PCode)
            End If
        ElseIf e.ColumnIndex = 3 Then
            CalcLinePrice()
        ElseIf e.ColumnIndex = 4 Then
            CalcLinePrice()
        ElseIf e.ColumnIndex = 5 Then
            If IsNumeric(Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value) = False Then
                MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value > 100 Or Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value < 0 Then
                MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value <> 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl((Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value - Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value / 100 * Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value) * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            ElseIf Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value = 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            End If
            MakeTotal()
        End If
    End Sub

    Private Sub Add_StockDataGridView_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Add_StockDataGridView.RowHeaderMouseClick
        Me.Add_StockDataGridView.CurrentCell = Me.Add_StockDataGridView.CurrentRow.Cells(0)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        If Me.TabControl2.SelectedIndex = 1 Then
            Me.DetailsDataGridView.Focus()
        End If
    End Sub

    Private Sub AddToStock_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToStock_btn.Click
        If Me.AddToStock_btn.Text = "Add to Stock" Then
            If Me.SelVendor_cbx.SelectedValue = Nothing Then
                MessageBox.Show("Select the Vendor from whom the Products are bought. If nothing is listed use the 'Add Vendor' tab to add new vendor.", "Vendor!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Me.Add_StockDataGridView.Rows.Count = 1 Then
                MessageBox.Show("You have not added any product to the list.", "Nothing to add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.StatusLabel.Text = "Adding to Stock"
                Me.AddToStock_btn.Enabled = False
                AddStockEntry()
                Me.AddToStock_btn.Enabled = True
                Me.StatusLabel.Text = "Ready"
            End If
        ElseIf Me.AddToStock_btn.Text = "Save" Then
            If Me.SelVendor_cbx.SelectedValue = Nothing Then
                MessageBox.Show("Select the Vendor from whom the Products are bought. If nothing is listed use the 'Add Vendor' tab to add new vendor.", "Vendor!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Me.Add_StockDataGridView.Rows.Count = 1 Then
                MessageBox.Show("You have not added any product to the list.", "Nothing to add", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.StatusLabel.Text = "Saving Changes"
                Me.AddToStock_btn.Enabled = False
                EditStock()
                Me.AddToStock_btn.Enabled = True
                Me.AddToStock_btn.Text = "Add to Stock"
                Me.StatusLabel.Text = "Ready"
            End If
        End If
    End Sub

    Private Sub BrowseStockRef_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseStockRef_btn.Click
        If Me.BrowseStockRef_btn.Text = "Browse" Then
            Dim Result As DialogResult
            Result = Me.RefFile_dbx.ShowDialog()
            If Result = System.Windows.Forms.DialogResult.OK Then
                Me.Add_Ref_tbx.Text = Me.RefFile_dbx.FileName
            End If
        ElseIf Me.BrowseStockRef_btn.Text = "Remove" Then
            If My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).DirectoryName <> My.Application.Info.DirectoryPath + "\Ref" Then
                Editref(Me.ViewEntryNo_cbx.SelectedValue)
                Me.Add_Ref_tbx.Text = ""
            ElseIf My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                Dim refile As String = My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).Name
                Dim result As DialogResult
                result = MessageBox.Show("The reference associated with this Stock Entry will be removed. Would you like to delete the  file " + refile + "? If 'Yes' the file will be sent to the recycle bin.", "Delete file!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Editref(Me.ViewEntryNo_cbx.SelectedValue)
                    Try
                        My.Computer.FileSystem.DeleteFile(Me.Add_Ref_tbx.Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                        Me.Add_Ref_tbx.Text = ""
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf result = System.Windows.Forms.DialogResult.No Then
                    Editref(Me.ViewEntryNo_cbx.SelectedValue)
                    Me.Add_Ref_tbx.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub ViewVendor_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewVendor_cbx.SelectedValueChanged
        Me.ViewStockDataGridView.Rows.Clear()
        If Me.ViewVendor_cbx.SelectedIndex <> -1 Then
            Me.ViewPCode_cbx.SelectedIndex = -1
        End If
        Me.StockEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockEntryBindingSource.DataSource = Me.MainInventoryDataSet
        Me.StockEntryBindingSource.DataMember = "StockEntry"
        Me.ViewRefBillNo_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewRefBillNo_cbx.DisplayMember = "RefBillNo"
        Me.ViewRefBillNo_cbx.ValueMember = "EntryNo"
        Me.ViewDate_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewDate_cbx.DisplayMember = "Date"
        Me.ViewDate_cbx.ValueMember = "EntryNo"
        Me.ViewEntryNo_cbx.SelectedIndex = -1
        Me.ViewEntryNo_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewEntryNo_cbx.DisplayMember = "EntryNo"
        Me.ViewEntryNo_cbx.ValueMember = "EntryNo"
        If Me.ViewVendor_cbx.SelectedValue <> Nothing Then
            Me.StockEntryBindingSource.Filter = "Vendor ='" & Me.ViewVendor_cbx.SelectedValue & "'"
        ElseIf Me.ViewVendor_cbx.SelectedValue = Nothing Then
            Me.StockEntryBindingSource.Filter = "Vendor =" & -1
        End If
        If Me.ViewEntryNo_cbx.Items.Count > 0 Then
            Me.ViewEntryNo_cbx.SelectedIndex = 0
            Me.ViewEntryNo_cbx.Focus()
        End If
    End Sub

    Private Sub ViewPCode_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPCode_cbx.SelectedValueChanged
        If Me.ViewPCode_cbx.SelectedIndex <> -1 Then
            Me.ViewVendor_cbx.SelectedIndex = -1
        End If
        Me.ViewStockDataGridView.Rows.Clear()
        Dim FindinStock() As InventoryDataSet.StockDetailsRow
        FindinStock = Me.MainInventoryDataSet.StockDetails.Select("ProductCode ='" & Me.ViewPCode_cbx.SelectedValue & "'")
        Dim Iteminstock As InventoryDataSet.StockDetailsRow
        Me.StockEntryBindingSource.DataSource = Nothing
        Me.StockEntryBindingSource.Clear()
        For Each Iteminstock In FindinStock
            Me.StockEntryBindingSource.Add(Me.MainInventoryDataSet.StockEntry.FindByEntryNo(Iteminstock.EntryNo))
        Next
        Me.ViewRefBillNo_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewRefBillNo_cbx.DisplayMember = "RefBillNo"
        Me.ViewRefBillNo_cbx.ValueMember = "EntryNo"
        Me.ViewDate_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewDate_cbx.DisplayMember = "Date"
        Me.ViewDate_cbx.ValueMember = "EntryNo"
        Me.ViewEntryNo_cbx.SelectedIndex = -1
        Me.ViewEntryNo_cbx.DataSource = Me.StockEntryBindingSource
        Me.ViewEntryNo_cbx.DisplayMember = "EntryNo"
        Me.ViewEntryNo_cbx.ValueMember = "EntryNo"
        If Me.ViewEntryNo_cbx.Items.Count > 0 Then
            Me.ViewEntryNo_cbx.SelectedIndex = 0
            Me.ViewEntryNo_cbx.Focus()
        End If
    End Sub

    Private Sub Edit_CompanyName_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_CompanyName_cbx.SelectedIndexChanged
        If Me.Edit_CompanyName_cbx.SelectedValue <> Nothing Then
            Me.Delete_Vendor_btn.Enabled = True
            Me.Edit_Vendor_btn.Enabled = True
        ElseIf Me.Edit_CompanyName_cbx.SelectedValue = Nothing Then
            Me.Delete_Vendor_btn.Enabled = False
            Me.Edit_Vendor_btn.Enabled = False
        End If
    End Sub

    Private Sub ViewSRef_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSRef_tbx.TextChanged
        If Me.ViewSRef_tbx.Text = "" Then
            Me.Open_btn.Enabled = False
        ElseIf Me.ViewSRef_tbx.Text <> "" Then
            Me.Open_btn.Enabled = True
        End If
    End Sub

    Private Sub ViewEntryNo_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewEntryNo_cbx.SelectedValueChanged
        If TabControl3.SelectedIndex = 1 Then
            If Me.ViewEntryNo_cbx.SelectedValue <> Nothing Then
                Me.Del_btn.Enabled = True
                Me.ViewStockDataGridView.Rows.Clear()
                Me.ViewStockDataGridView.AllowUserToAddRows = True
                Dim GetSDetails() As InventoryDataSet.StockDetailsRow
                GetSDetails = Me.MainInventoryDataSet.StockDetails.Select("EntryNo =" & Me.ViewEntryNo_cbx.SelectedValue)
                Dim GetSDetail As InventoryDataSet.StockDetailsRow
                For Each GetSDetail In GetSDetails
                    Me.ViewStockDataGridView.Rows.Add()
                    Me.ViewStockDataGridView.CurrentCell = Me.ViewStockDataGridView.Rows(Me.ViewStockDataGridView.Rows.Count - 2).Cells(0)
                    Me.ViewStockDataGridView.CurrentRow.Cells(0).Value = CInt(Microsoft.VisualBasic.Mid(GetSDetail.SlNo, GetSDetail.EntryNo.ToString.Length + 1))
                    Me.ViewStockDataGridView.CurrentRow.Cells(1).Value = GetSDetail.ProductCode.ToString
                    Dim GetDetail As InventoryDataSet.DetailsRow
                    GetDetail = Me.MainInventoryDataSet.Details.FindByCode(GetSDetail.ProductCode)
                    If GetDetail IsNot Nothing Then
                        Me.ViewStockDataGridView.CurrentRow.Cells(2).Value = GetDetail.Description
                        GetDetail = Nothing
                    End If

                    Me.ViewStockDataGridView.CurrentRow.Cells(3).Value = GetSDetail.Price.ToString("0.00")
                    Me.ViewStockDataGridView.CurrentRow.Cells(4).Value = GetSDetail.Quantity
                    Me.ViewStockDataGridView.CurrentRow.Cells(5).Value = GetSDetail.Discount.ToString("0.00")
                    If Me.ViewStockDataGridView.CurrentRow.Cells.Item(5).Value <> 0 Then
                        Me.ViewStockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl((Me.ViewStockDataGridView.CurrentRow.Cells.Item(3).Value - Me.ViewStockDataGridView.CurrentRow.Cells.Item(5).Value / 100 * Me.ViewStockDataGridView.CurrentRow.Cells.Item(3).Value) * Me.ViewStockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    ElseIf Me.ViewStockDataGridView.CurrentRow.Cells.Item(5).Value = 0 Then
                        Me.ViewStockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.ViewStockDataGridView.CurrentRow.Cells.Item(3).Value * Me.ViewStockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    End If
                Next
                GetSDetails = Nothing

                If Me.ViewStockDataGridView.Rows.Count > 1 Then
                    Dim Total As Double
                    For i As Integer = 0 To Me.ViewStockDataGridView.Rows.Count - 2
                        Total = Total + CDbl(Me.ViewStockDataGridView.Rows.Item(i).Cells(6).Value)
                    Next
                    Me.VBillAmt_tbx.Text = Total.ToString("0.00")
                ElseIf Me.ViewStockDataGridView.RowCount = 1 Then
                    Me.VBillAmt_tbx.Text = "0.00"
                    Me.VAmtPay_tbx.Text = "0.00"
                End If

                Dim GetSEntry As InventoryDataSet.StockEntryRow
                GetSEntry = Me.MainInventoryDataSet.StockEntry.FindByEntryNo(Me.ViewEntryNo_cbx.SelectedValue)
                If GetSEntry.DiscOnTotal = "0" Then
                    Me.VDiscAmt_tbx.Text = "0"
                    Me.VDiscPer_tbx.Text = "0"
                ElseIf Microsoft.VisualBasic.Mid(GetSEntry.DiscOnTotal, 1, 1) = "%" Then
                    Me.VDiscPer_tbx.Text = Microsoft.VisualBasic.Mid(GetSEntry.DiscOnTotal, 2)
                    Me.VDiscAmt_tbx.Text = CDbl(CDbl(Me.VDiscPer_tbx.Text) / 100 * CDbl(Me.VBillAmt_tbx.Text)).ToString("0.00")
                ElseIf Microsoft.VisualBasic.Mid(GetSEntry.DiscOnTotal, 1, 1) <> "%" Then
                    Me.VDiscAmt_tbx.Text = CDbl(GetSEntry.DiscOnTotal).ToString("0.00")
                End If
                Me.VAmtPay_tbx.Text = (CDbl(Me.VBillAmt_tbx.Text) - CDbl(Me.VDiscAmt_tbx.Text)).ToString("0.00")
                Me.ViewStockDataGridView.AllowUserToAddRows = False
            ElseIf Me.ViewEntryNo_cbx.SelectedValue = Nothing Then
                Me.Del_btn.Enabled = False
            End If

            If Me.ViewStockDataGridView.RowCount > 0 Then
                Me.Edit_btn.Enabled = True
                Me.ViewStockDataGridView.Sort(Me.DataGridViewTextBoxColumn4, System.ComponentModel.ListSortDirection.Ascending)
            End If
        End If

    End Sub

    Private Sub Open_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open_btn.Click
        If Me.Open_btn.Text = "Open" Then
            If My.Computer.FileSystem.FileExists(Me.ViewSRef_tbx.Text.Trim) Then
                System.Diagnostics.Process.Start(Me.ViewSRef_tbx.Text.Trim)
            ElseIf My.Computer.FileSystem.FileExists(Me.ViewSRef_tbx.Text.Trim) = False Then
                MessageBox.Show("The specified file does not exist.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_btn.Click
        Me.Add_StockDataGridView.Rows.Clear()
        Dim GetSDetails() As InventoryDataSet.StockDetailsRow
        GetSDetails = Me.MainInventoryDataSet.StockDetails.Select("EntryNo =" & Me.ViewEntryNo_cbx.SelectedValue)
        Dim GetSDetail As InventoryDataSet.StockDetailsRow
        For Each GetSDetail In GetSDetails
            Me.Add_StockDataGridView.Rows.Add()
            Me.Add_StockDataGridView.CurrentCell = Me.Add_StockDataGridView.Rows(Me.Add_StockDataGridView.Rows.Count - 2).Cells(0)
            Me.Add_StockDataGridView.CurrentRow.Cells(0).Value = CInt(Microsoft.VisualBasic.Mid(GetSDetail.SlNo, GetSDetail.EntryNo.ToString.Length + 1))
            Me.Add_StockDataGridView.CurrentRow.Cells(1).Value = GetSDetail.ProductCode.ToString
            Dim GetDetail As InventoryDataSet.DetailsRow
            GetDetail = Me.MainInventoryDataSet.Details.FindByCode(GetSDetail.ProductCode)
            Me.Add_StockDataGridView.CurrentRow.Cells(2).Value = GetDetail.Description
            GetDetail = Nothing
            Me.Add_StockDataGridView.CurrentRow.Cells(3).Value = GetSDetail.Price.ToString("0.00")
            Me.Add_StockDataGridView.CurrentRow.Cells(4).Value = GetSDetail.Quantity
            Me.Add_StockDataGridView.CurrentRow.Cells(5).Value = GetSDetail.Discount.ToString("0.00")
            If Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value <> 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl((Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value - Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value / 100 * Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value) * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            ElseIf Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value = 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            End If
        Next
        GetSDetails = Nothing

        Me.SelVendor_cbx.SelectedIndex = Me.ViewVendor_cbx.SelectedIndex
        Me.Add_Date_tbx.Text = Me.ViewDate_cbx.Text
        Me.Add_RefBillNo_tbx.Text = Me.ViewRefBillNo_cbx.Text
        Me.Add_Ref_tbx.Text = Me.ViewSRef_tbx.Text
        If Me.Add_Ref_tbx.Text <> "" Then
            If My.Computer.FileSystem.FileExists(Me.Add_Ref_tbx.Text) Then
                Me.BrowseStockRef_btn.Text = "Remove"
                Me.ImportSRef_ckbx.Enabled = False
            ElseIf My.Computer.FileSystem.FileExists(Me.Add_Ref_tbx.Text) = False Then
                MessageBox.Show("The specified reference file doesnot exist, browse to add a reference.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Add_Ref_tbx.Text = ""
                Me.BrowseStockRef_btn.Text = "Browse"
                Me.ImportSRef_ckbx.Enabled = True
            End If
        End If
        Me.DiscAmt_tbx.Text = Me.VDiscAmt_tbx.Text
        Me.DiscPer_tbx.Text = Me.VDiscPer_tbx.Text
        If Me.DiscPer_tbx.Text = "" Or Me.DiscPer_tbx.Text = "0" Then
            Me.DiscPer_tbx.Enabled = False
            Me.DiscAmt_tbx.Enabled = True
        ElseIf Me.DiscPer_tbx.Text <> "" Or Me.DiscPer_tbx.Text = "0" Then
            Me.DiscPer_tbx.Enabled = True
            Me.DiscAmt_tbx.Enabled = False
        End If
        Me.BillAmt_tbx.Text = Me.VBillAmt_tbx.Text
        Me.AmtPay_tbx.Text = Me.VAmtPay_tbx.Text
        Me.AddToStock_btn.Text = "Save"
        Me.TabControl3.SelectTab(0)

    End Sub

    Private Sub Del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_btn.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("Do you wish to Delete this Stock Entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Try
                DelStockDetails(Me.ViewEntryNo_cbx.SelectedValue)
                Dim DelSEntry As InventoryDataSet.StockEntryRow
                DelSEntry = Me.MainInventoryDataSet.StockEntry.FindByEntryNo(Me.ViewEntryNo_cbx.SelectedValue)
                DelSEntry.Delete()
                Me.StockEntryTableAdapter.Update(Me.MainInventoryDataSet.StockEntry)
                DelSEntry = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

#Region "Methods"

    Private Sub MakeTotal()
        If Me.Add_StockDataGridView.Rows.Count = 1 Then
            Me.BillAmt_tbx.Text = "0.00"
            Me.AmtPay_tbx.Text = "0.00"
            Exit Sub
        End If
        Dim Total As Double
        For i As Integer = 0 To Me.Add_StockDataGridView.Rows.Count - 2
            Total = Total + CDbl(Me.Add_StockDataGridView.Rows.Item(i).Cells(6).Value)
        Next
        Me.BillAmt_tbx.Text = Total.ToString("0.00")
        If Me.DiscAmt_tbx.Text = "" And Me.DiscPer_tbx.Text = "" Then
            Me.AmtPay_tbx.Text = Me.BillAmt_tbx.Text
        ElseIf Me.DiscAmt_tbx.Enabled = True And Me.DiscAmt_tbx.Text <> "" Then
            Me.AmtPay_tbx.Text = (Total - CDbl(Me.DiscAmt_tbx.Text)).ToString("0.00")
        ElseIf Me.DiscPer_tbx.Enabled = True And Me.DiscPer_tbx.Text <> "" Then
            Me.DiscAmt_tbx.Text = CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * Total).ToString("0.00")
            Me.AmtPay_tbx.Text = (Total - CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * Total)).ToString("0.00")
        End If
    End Sub

    Private Sub CalcLinePrice()
        Try
            If Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value <> 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl((Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value - Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value / 100 * Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value) * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            ElseIf Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value = 0 Then
                Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value * Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            End If
        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
            Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value)).ToString("0.00")
            Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value = "1"
        Catch ex As NullReferenceException
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MakeTotal()
    End Sub

    Private Sub FillRow(ByVal Code As String)
        Dim GetDetails As InventoryDataSet.DetailsRow
        GetDetails = MainInventoryDataSet.Details.FindByCode(Code)
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(0).Value = (Me.Add_StockDataGridView.CurrentRow.Index + 1).ToString
        Me.Add_StockDataGridView.CurrentRow.Cells(1).Value = GetDetails.Code
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(2).Value = GetDetails.Description
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(3).Value = CDbl(GetDetails.Price).ToString("0.00")
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(4).Value = 1
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(5).Value = 0
        Me.Add_StockDataGridView.CurrentRow.Cells.Item(6).Value = CDbl(GetDetails.Price).ToString("0.00")

        MakeTotal()
    End Sub

    Private Sub ShowRef()
        Dim PCode As String = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Dim GetRef As InventoryDataSet.Details1Row
        GetRef = Me.MainInventoryDataSet.Details1.FindByCode(PCode)
        Dim FileName As String = GetRef.Reference
        If My.Computer.FileSystem.FileExists(FileName) Then
            Me.Cursor = Cursors.WaitCursor
            System.Diagnostics.Process.Start(FileName)
            Me.Cursor = Cursors.Default
        ElseIf My.Computer.FileSystem.FileExists(FileName) = False Then
            MessageBox.Show("No reference is associated with this product", "Reference not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub AddStockEntry()
        Dim NewSEntry As InventoryDataSet.StockEntryRow
        NewSEntry = Me.MainInventoryDataSet.StockEntry.NewStockEntryRow
        NewSEntry.RefBillNo = Me.Add_RefBillNo_tbx.Text
        NewSEntry.Vendor = Me.SelVendor_cbx.SelectedValue
        NewSEntry.Amount = Me.AmtPay_tbx.Text
        NewSEntry.ThisDate = Me.Add_Date_tbx.Text
        If Me.DiscAmt_tbx.Enabled = False Then
            NewSEntry.DiscOnTotal = "%" + Me.DiscPer_tbx.Text
        ElseIf Me.DiscPer_tbx.Enabled = False Then
            NewSEntry.DiscOnTotal = Me.DiscAmt_tbx.Text
        Else
            NewSEntry.DiscOnTotal = 0
        End If
        If Me.ImportSRef_ckbx.Checked And My.Computer.FileSystem.FileExists(Me.Add_Ref_tbx.Text) Then
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).Extension
            If My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                NewSEntry.Reference = Me.Add_Ref_tbx.Text
            ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ref") Then
                My.Computer.FileSystem.CopyFile(Me.Add_Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + NewSEntry.EntryNo.ToString + ext, True)
                NewSEntry.Reference = My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + NewSEntry.EntryNo.ToString + ext
            Else
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\Ref")
                My.Computer.FileSystem.CopyFile(Me.Add_Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + NewSEntry.EntryNo.ToString + ext, True)
                NewSEntry.Reference = My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + NewSEntry.EntryNo.ToString + ext
            End If
        ElseIf Me.ImportSRef_ckbx.Checked = False Then
            NewSEntry.Reference = Me.Add_Ref_tbx.Text
        End If
        Dim ENo As Integer = NewSEntry.EntryNo
        Try
            Me.MainInventoryDataSet.StockEntry.AddStockEntryRow(NewSEntry)
            Me.StockEntryTableAdapter.Update(NewSEntry)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        NewSEntry = Nothing

        AddStockDetails(ENo)

    End Sub

    Private Sub AddStockDetails(ByVal EntryNo As Integer)
        For i As Integer = 0 To Me.Add_StockDataGridView.RowCount - 2
            Dim NewSDetails As InventoryDataSet.StockDetailsRow
            NewSDetails = Me.MainInventoryDataSet.StockDetails.NewStockDetailsRow
            NewSDetails.SlNo = EntryNo.ToString + Me.Add_StockDataGridView.Rows(i).Cells(0).Value.ToString
            NewSDetails.ProductCode = Me.Add_StockDataGridView.Rows(i).Cells(1).Value.ToString
            NewSDetails.Price = CDbl(Me.Add_StockDataGridView.Rows(i).Cells(3).Value)
            NewSDetails.Quantity = CInt(Me.Add_StockDataGridView.Rows(i).Cells(4).Value)
            Dim EditDetails As InventoryDataSet.Details1Row
            EditDetails = Me.MainInventoryDataSet.Details1.FindByCode(NewSDetails.ProductCode)
            EditDetails.BeginEdit()
            EditDetails.Available_Nos = EditDetails.Available_Nos + CInt(Me.Add_StockDataGridView.Rows(i).Cells(4).Value)
            EditDetails.EndEdit()
            NewSDetails.Discount = CDbl(Me.Add_StockDataGridView.Rows(i).Cells(5).Value)
            NewSDetails.EntryNo = EntryNo
            Try
                Me.MainInventoryDataSet.StockDetails.AddStockDetailsRow(NewSDetails)
                Me.StockDetailsTableAdapter.Update(NewSDetails)
                Me.Details1TableAdapter.Update(EditDetails)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Try
            End Try
        Next
        Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
        Me.SelVendor_cbx.SelectedIndex = -1
        Me.Add_RefBillNo_tbx.Text = ""
        Me.Add_Date_tbx.Text = ""
        Me.Add_Ref_tbx.Text = ""
        Me.Add_StockDataGridView.Rows.Clear()
        Me.StatusLabel.Text = "Products have been added to the Stock."
    End Sub

    Private Sub DelStockDetails(ByVal EntryNo As String)
        Dim DelSDetails() As InventoryDataSet.StockDetailsRow
        DelSDetails = Me.MainInventoryDataSet.StockDetails.Select("EntryNo =" & EntryNo)
        If DelSDetails.Length > 0 Then
            Dim StockDetail As InventoryDataSet.StockDetailsRow
            For Each StockDetail In DelSDetails
                StockDetail.Delete()
            Next
            Me.StockDetailsTableAdapter.Update(Me.MainInventoryDataSet)
            StockDetail = Nothing
        End If
        DelSDetails = Nothing
    End Sub

    Private Sub EditStock()

        DelStockDetails(Me.ViewEntryNo_cbx.SelectedValue)

        Dim ENo As Integer = Me.ViewEntryNo_cbx.SelectedValue
        Dim EditSEntry As InventoryDataSet.StockEntryRow
        EditSEntry = Me.MainInventoryDataSet.StockEntry.FindByEntryNo(ENo)
        EditSEntry.BeginEdit()
        EditSEntry.RefBillNo = Me.Add_RefBillNo_tbx.Text
        EditSEntry.Vendor = Me.SelVendor_cbx.SelectedValue
        EditSEntry.Amount = Me.AmtPay_tbx.Text
        EditSEntry.ThisDate = Me.Add_Date_tbx.Text
        If Me.DiscAmt_tbx.Enabled = False Then
            EditSEntry.DiscOnTotal = "%" + Me.DiscPer_tbx.Text
        ElseIf Me.DiscPer_tbx.Enabled = False Then
            EditSEntry.DiscOnTotal = Me.DiscAmt_tbx.Text
        Else
            EditSEntry.DiscOnTotal = 0
        End If
        If Me.ImportSRef_ckbx.Checked And My.Computer.FileSystem.FileExists(Me.Add_Ref_tbx.Text) Then
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).Extension
            If My.Computer.FileSystem.GetFileInfo(Me.Add_Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                EditSEntry.Reference = Me.Add_Ref_tbx.Text
            ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ref") Then
                My.Computer.FileSystem.CopyFile(Me.Add_Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + EditSEntry.EntryNo.ToString + ext, True)
                EditSEntry.Reference = My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + EditSEntry.EntryNo.ToString + ext
            Else
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\Ref")
                My.Computer.FileSystem.CopyFile(Me.Add_Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + EditSEntry.EntryNo.ToString + ext, True)
                EditSEntry.Reference = My.Application.Info.DirectoryPath + "\Ref\" + "SRef" + EditSEntry.EntryNo.ToString + ext
            End If
        ElseIf Me.ImportSRef_ckbx.Checked = False Then
            EditSEntry.Reference = Me.Add_Ref_tbx.Text
        End If
        EditSEntry.EndEdit()
        Try
            Me.StockEntryTableAdapter.Update(EditSEntry)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        EditSEntry = Nothing

        AddStockDetails(ENo)

    End Sub

    Public Sub VendorEditReady()
        Me.Edit_Vendor_gbx.Controls.Remove(Me.Edit_CompanyName_cbx)
        Me.Edit_Vendor_gbx.Controls.Add(Me.Edit_CompanyName_tbx)
        Me.Edit_CompanyName_tbx.Text = Me.Edit_CompanyName_cbx.Text
        Me.Edit_CompanyName_tbx.Tag = Me.Edit_CompanyName_cbx.Text
        Me.Edit_VendorName_tbx.ReadOnly = False
        Me.Edit_VendorName_tbx.BackColor = Color.White
        Me.Edit_AddressLine1_tbx.ReadOnly = False
        Me.Edit_AddressLine1_tbx.BackColor = Color.White
        Me.Edit_AddressLine2_tbx.ReadOnly = False
        Me.Edit_AddressLine2_tbx.BackColor = Color.White
        Me.Edit_Phone_tbx.ReadOnly = False
        Me.Edit_Phone_tbx.BackColor = Color.White
        Me.Edit_Mobile_tbx.ReadOnly = False
        Me.Edit_Mobile_tbx.BackColor = Color.White
        Me.Edit_Fax_tbx.ReadOnly = False
        Me.Edit_Fax_tbx.BackColor = Color.White
        Me.Edit_Email_tbx.ReadOnly = False
        Me.Edit_Email_tbx.BackColor = Color.White
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_City_tbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_City_cbx)
        Me.Edit_City_cbx.SelectedIndex = Me.Edit_City_cbx.FindString(Me.Edit_City_tbx.Text)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_State_tbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_State_cbx)
        Me.Edit_State_cbx.SelectedIndex = Me.Edit_State_cbx.FindString(Me.Edit_State_tbx.Text)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_Country_tbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_Country_cbx)
        Me.Edit_Country_cbx.SelectedIndex = Me.Edit_Country_cbx.FindString(Me.Edit_Country_tbx.Text)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_Pincode_tbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_Pincode_cbx)
        Me.Edit_Pincode_cbx.SelectedIndex = Me.Edit_Pincode_cbx.FindString(Me.Edit_Pincode_tbx.Text)
        Me.Edit_City_cbx.Focus()
        Me.Edit_Vendor_gbx.Controls.Remove(Me.Edit_Website_llbl)
        Me.Edit_Vendor_gbx.Controls.Add(Me.Edit_Website_tbx)
        Me.Edit_Website_tbx.Text = Me.Edit_Website_llbl.Text
        Me.Edit_CompanyName_tbx.Focus()
        Me.Edit_Vendor_btn.Text = "Save Changes"
    End Sub

    Public Sub EditVendorInitialState()
        Me.Edit_Vendor_gbx.Controls.Add(Me.Edit_CompanyName_cbx)
        Me.Edit_Vendor_gbx.Controls.Remove(Me.Edit_CompanyName_tbx)
        Me.Edit_CompanyName_tbx.Text = ""
        Me.Edit_VendorName_tbx.ReadOnly = True
        Me.Edit_VendorName_tbx.BackColor = Color.LightYellow
        Me.Edit_AddressLine1_tbx.ReadOnly = True
        Me.Edit_AddressLine1_tbx.BackColor = Color.LightYellow
        Me.Edit_AddressLine2_tbx.ReadOnly = True
        Me.Edit_AddressLine2_tbx.BackColor = Color.LightYellow
        Me.Edit_Phone_tbx.ReadOnly = True
        Me.Edit_Phone_tbx.BackColor = Color.LightYellow
        Me.Edit_Mobile_tbx.ReadOnly = True
        Me.Edit_Mobile_tbx.BackColor = Color.LightYellow
        Me.Edit_Fax_tbx.ReadOnly = True
        Me.Edit_Fax_tbx.BackColor = Color.LightYellow
        Me.Edit_Email_tbx.ReadOnly = True
        Me.Edit_Email_tbx.BackColor = Color.LightYellow
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_City_tbx)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_City_cbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_State_tbx)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_State_cbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_Country_tbx)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_Country_cbx)
        Me.Edit_Address_gbx.Controls.Add(Me.Edit_Pincode_tbx)
        Me.Edit_Address_gbx.Controls.Remove(Me.Edit_Pincode_cbx)
        Me.Edit_Vendor_gbx.Controls.Add(Me.Edit_Website_llbl)
        Me.Edit_Vendor_gbx.Controls.Remove(Me.Edit_Website_tbx)
        Me.Edit_Website_llbl.Update()
        Me.Edit_CompanyName_tbx.Focus()
        Me.Edit_Vendor_btn.Text = "Edit"
    End Sub

    Public Sub AddVendor()
        Dim NewCompDetails As VendorDataSet.CompanyDetailsRow
        NewCompDetails = Me.MainVendorDataSet.CompanyDetails.NewCompanyDetailsRow()
        NewCompDetails.Representative = Me.VendorName_tbx.Text
        NewCompDetails.AddressLine1 = Me.AddressLine1_tbx.Text
        NewCompDetails.AddressLine2 = Me.AddressLine2_tbx.Text
        NewCompDetails.Phone = Me.Phone_tbx.Text
        NewCompDetails.Mobile = Me.Mobile_tbx.Text
        NewCompDetails.Fax = Me.Fax_tbx.Text
        NewCompDetails.Email = Me.Email_tbx.Text
        NewCompDetails.Website = Me.Website_tbx.Text
        Try
            Dim NewCompany As VendorDataSet.CompanyRow
            NewCompany = MainVendorDataSet.Company.NewCompanyRow
            NewCompany.CompanyName = Me.CompanyName_tbx.Text
            NewCompDetails.CompanyName = NewCompany.CompanyName
            NewCompany.AddressID = NewCompDetails.AddressID
            Me.MainVendorDataSet.Company.AddCompanyRow(NewCompany)
            Me.CompanyTableAdapter.Update(NewCompany)
            NewCompany = Nothing
        Catch ex As ConstraintException
            MessageBox.Show(ex.Message)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If Me.State_cbx.SelectedValue = Nothing Then
            Dim NewCompState As VendorDataSet.CompanyStateRow
            NewCompState = Me.MainVendorDataSet.CompanyState.NewCompanyStateRow
            NewCompState.StateName = Me.State_cbx.Text

            If Me.City_cbx.SelectedValue = Nothing Then
                Dim NewCompCity As VendorDataSet.CompanyCityRow
                NewCompCity = Me.MainVendorDataSet.CompanyCity.NewCompanyCityRow
                NewCompCity.City = Me.City_cbx.Text
                NewCompCity.StateID = NewCompState.StateID
                NewCompDetails.CityID = NewCompCity.CityID
                If Me.Pincode_cbx.SelectedValue = Nothing Then
                    Dim NewCompPin As VendorDataSet.CompanyPincodeRow
                    NewCompPin = Me.MainVendorDataSet.CompanyPincode.NewCompanyPincodeRow
                    NewCompPin.Pincode = Me.Pincode_cbx.Text
                    NewCompPin.CityID = NewCompCity.CityID
                    NewCompDetails.PincodeID = NewCompPin.PincodeID
                    Me.MainVendorDataSet.CompanyPincode.AddCompanyPincodeRow(NewCompPin)
                    Me.CompanyPincodeTableAdapter.Update(NewCompPin)
                    NewCompPin = Nothing
                ElseIf Me.Pincode_cbx.SelectedValue <> Nothing Then
                    NewCompDetails.PincodeID = Me.Pincode_cbx.SelectedValue
                End If
                Me.MainVendorDataSet.CompanyCity.AddCompanyCityRow(NewCompCity)
                Me.CompanyCityTableAdapter.Update(NewCompCity)
                NewCompCity = Nothing
            ElseIf Me.City_cbx.SelectedValue <> Nothing Then
                NewCompDetails.CityID = Me.City_cbx.SelectedValue
            End If

            If Me.Country_cbx.SelectedValue = Nothing Then
                Dim NewCompCount As VendorDataSet.CompanyCountryRow
                NewCompCount = Me.MainVendorDataSet.CompanyCountry.NewCompanyCountryRow
                NewCompCount.Country = Me.Country_cbx.Text
                NewCompCount.StateID = NewCompState.StateID
                NewCompState.CountryID = NewCompCount.CountryID
                Me.MainVendorDataSet.CompanyCountry.AddCompanyCountryRow(NewCompCount)
                Me.CompanyCountryTableAdapter.Update(NewCompCount)
                NewCompCount = Nothing
            ElseIf Me.Country_cbx.SelectedValue <> Nothing Then
                NewCompState.CountryID = Me.Country_cbx.SelectedValue
            End If
            Me.MainVendorDataSet.CompanyState.AddCompanyStateRow(NewCompState)
            Me.CompanyStateTableAdapter.Update(NewCompState)
            NewCompState = Nothing

        ElseIf Me.State_cbx.SelectedValue <> Nothing Then

            If Me.City_cbx.SelectedValue = Nothing Then
                Dim NewCompCity As VendorDataSet.CompanyCityRow
                NewCompCity = Me.MainVendorDataSet.CompanyCity.NewCompanyCityRow
                NewCompCity.City = Me.City_cbx.Text
                NewCompCity.StateID = Me.State_cbx.SelectedValue
                NewCompDetails.CityID = NewCompCity.CityID
                If Me.Pincode_cbx.SelectedValue = Nothing Then
                    Dim NewCompPin As VendorDataSet.CompanyPincodeRow
                    NewCompPin = Me.MainVendorDataSet.CompanyPincode.NewCompanyPincodeRow
                    NewCompPin.Pincode = Me.Pincode_cbx.Text
                    NewCompPin.CityID = NewCompCity.CityID
                    NewCompDetails.PincodeID = NewCompPin.PincodeID
                    Me.MainVendorDataSet.CompanyPincode.AddCompanyPincodeRow(NewCompPin)
                    Me.CompanyPincodeTableAdapter.Update(NewCompPin)
                    NewCompPin = Nothing
                ElseIf Me.Pincode_cbx.SelectedValue <> Nothing Then
                    NewCompDetails.PincodeID = Me.Pincode_cbx.SelectedValue
                End If
                Me.MainVendorDataSet.CompanyCity.AddCompanyCityRow(NewCompCity)
                Me.CompanyCityTableAdapter.Update(NewCompCity)
                NewCompCity = Nothing
            ElseIf Me.City_cbx.SelectedValue <> Nothing Then
                NewCompDetails.CityID = Me.City_cbx.SelectedValue
                If Me.Pincode_cbx.SelectedValue = Nothing Then
                    Dim NewCompPin As VendorDataSet.CompanyPincodeRow
                    NewCompPin = Me.MainVendorDataSet.CompanyPincode.NewCompanyPincodeRow
                    NewCompPin.Pincode = Me.Pincode_cbx.Text
                    NewCompPin.CityID = Me.City_cbx.SelectedValue
                    NewCompDetails.PincodeID = NewCompPin.PincodeID
                    Me.MainVendorDataSet.CompanyPincode.AddCompanyPincodeRow(NewCompPin)
                    Me.CompanyPincodeTableAdapter.Update(NewCompPin)
                    NewCompPin = Nothing
                ElseIf Me.Pincode_cbx.SelectedValue <> Nothing Then
                    NewCompDetails.PincodeID = Me.Pincode_cbx.SelectedValue
                End If
            End If

            If Me.Country_cbx.SelectedValue = Nothing Then
                Dim NewCompCount As VendorDataSet.CompanyCountryRow
                NewCompCount = Me.MainVendorDataSet.CompanyCountry.NewCompanyCountryRow
                NewCompCount.Country = Me.Country_cbx.Text
                NewCompCount.StateID = Me.State_cbx.SelectedValue
                Me.MainVendorDataSet.CompanyCountry.AddCompanyCountryRow(NewCompCount)
                Me.CompanyCountryTableAdapter.Update(NewCompCount)
                NewCompCount = Nothing
            End If

        End If
        Me.MainVendorDataSet.CompanyDetails.AddCompanyDetailsRow(NewCompDetails)
        Me.CompanyDetailsTableAdapter.Update(NewCompDetails)
        NewCompDetails = Nothing
        Me.VendorTableAdapter.GetData()
        Me.VendorTableAdapter.Fill(Me.MainVendorDataSet.Vendor)

    End Sub

    Public Sub EditVendor()
        If Me.Edit_CompanyName_tbx.Text = "" Then
            MessageBox.Show("Enter the name of the Company.", "Company Name Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Edit failed, no changes were made to the data.", "Edit Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf Me.Edit_VendorName_tbx.Text = "" Then
            MessageBox.Show("Enter the name of the Company's representative.", "Representative Name Missing!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Edit failed, no changes were made to the data.", "Edit Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim EditCompany As VendorDataSet.CompanyRow
        EditCompany = Me.MainVendorDataSet.Company.FindByCompanyName(Me.Edit_CompanyName_tbx.Tag)
        Dim ID As Integer = EditCompany.AddressID
        If Me.Edit_CompanyName_cbx.Text <> Me.Edit_CompanyName_tbx.Text Then
            EditCompany.BeginEdit()
            EditCompany.CompanyName = Me.Edit_CompanyName_tbx.Text
            EditCompany.EndEdit()
            Me.CompanyTableAdapter.Update(EditCompany)
            Me.CompanyTableAdapter.Fill(Me.MainVendorDataSet.Company)
            EditCompany = Nothing
        End If
        Dim EditCompDetails As VendorDataSet.CompanyDetailsRow
        EditCompDetails = Me.MainVendorDataSet.CompanyDetails.FindByAddressID(ID)
        EditCompDetails.BeginEdit()
        EditCompDetails.Representative = Me.Edit_VendorName_tbx.Text
        EditCompDetails.AddressLine1 = Me.Edit_AddressLine1_tbx.Text
        EditCompDetails.AddressLine2 = Me.Edit_AddressLine2_tbx.Text
        EditCompDetails.Phone = Me.Edit_Phone_tbx.Text
        EditCompDetails.Mobile = Me.Edit_Mobile_tbx.Text
        EditCompDetails.Fax = Me.Edit_Fax_tbx.Text
        EditCompDetails.Email = Me.Edit_Email_tbx.Text
        EditCompDetails.Website = Me.Edit_Website_tbx.Text
        If Me.Edit_CompanyName_cbx.Text <> Me.Edit_CompanyName_tbx.Text Then
            EditCompDetails.CompanyName = Me.Edit_CompanyName_tbx.Text
        End If

        If Me.Edit_City_cbx.SelectedValue = Nothing Then
            Dim EditCompCity As VendorDataSet.CompanyCityRow
            EditCompCity = Me.MainVendorDataSet.CompanyCity.FindByCityID(EditCompDetails.CityID)
            ID = EditCompCity.StateID
            EditCompCity.BeginEdit()
            EditCompCity.City = Me.Edit_City_cbx.Text
            If Me.Edit_State_cbx.SelectedValue = Nothing Then
                Dim EditCompState As VendorDataSet.CompanyStateRow
                EditCompState = Me.MainVendorDataSet.CompanyState.FindByStateID(ID)
                ID = EditCompState.CountryID
                EditCompState.BeginEdit()
                EditCompState.StateName = Me.Edit_State_cbx.Text
                If Me.Edit_Country_cbx.SelectedValue = Nothing Then
                    Dim EditCompCountry As VendorDataSet.CompanyCountryRow
                    EditCompCountry = Me.MainVendorDataSet.CompanyCountry.FindByCountryID(ID)
                    EditCompCountry.BeginEdit()
                    EditCompCountry.Country = Me.Edit_Country_cbx.Text
                    EditCompCountry.EndEdit()
                    Me.CompanyCountryTableAdapter.Update(EditCompCountry)
                    Me.CompanyCountryTableAdapter.Fill(Me.MainVendorDataSet.CompanyCountry)
                    EditCompCountry = Nothing
                ElseIf Me.Edit_Country_cbx.SelectedValue <> Nothing Then
                    EditCompState.CountryID = Me.Edit_Country_cbx.SelectedValue
                End If
                EditCompState.EndEdit()
                Me.CompanyStateTableAdapter.Update(EditCompState)
                Me.CompanyStateTableAdapter.Fill(Me.MainVendorDataSet.CompanyState)
                EditCompState = Nothing
            ElseIf Me.Edit_State_cbx.SelectedValue <> Nothing Then
                EditCompCity.StateID = Me.Edit_State_cbx.SelectedValue
            End If
            EditCompCity.EndEdit()
            Me.CompanyCityTableAdapter.Update(EditCompCity)
            Me.CompanyCityTableAdapter.Fill(Me.MainVendorDataSet.CompanyCity)
            EditCompCity = Nothing
        ElseIf Me.Edit_City_cbx.SelectedValue <> Nothing Then
            EditCompDetails.CityID = Me.Edit_City_cbx.SelectedValue
        End If
        If Me.Edit_Pincode_cbx.SelectedValue = Nothing And Me.Edit_Pincode_cbx.Text <> "" Then

            Dim EditCompPincode As VendorDataSet.CompanyPincodeRow
            EditCompPincode = Me.MainVendorDataSet.CompanyPincode.FindByPincodeID(EditCompDetails.PincodeID)
            EditCompPincode.BeginEdit()
            EditCompPincode.Pincode = Me.Edit_Pincode_cbx.Text
            Me.Edit_Pincode_tbx.Text = ""
            EditCompPincode.CityID = EditCompDetails.CityID
            EditCompPincode.EndEdit()
            Me.CompanyPincodeTableAdapter.Update(EditCompPincode)
            Me.CompanyPincodeTableAdapter.Fill(Me.MainVendorDataSet.CompanyPincode)
            EditCompPincode = Nothing
        ElseIf Me.Edit_Pincode_cbx.SelectedValue <> Nothing Then
            EditCompDetails.PincodeID = Me.Edit_Pincode_cbx.SelectedValue
        End If
        EditCompDetails.EndEdit()
        Me.CompanyDetailsTableAdapter.Update(EditCompDetails)
        Me.CompanyDetailsTableAdapter.Fill(Me.MainVendorDataSet.CompanyDetails)
        EditCompDetails = Nothing
    End Sub

    Private Sub Editref(ByVal EntryNo As Integer)
        Dim EditStockRef As InventoryDataSet.StockEntryRow
        EditStockRef = Me.MainInventoryDataSet.StockEntry.FindByEntryNo(EntryNo)
        EditStockRef.BeginEdit()
        EditStockRef.Reference = ""
        EditStockRef.EndEdit()
        Me.StockEntryTableAdapter.Update(EditStockRef)
        Me.Browse_btn.Text = "Browse"
        Me.ImportSRef_ckbx.Checked = False
        Me.ImportSRef_ckbx.Enabled = True
    End Sub

    Public Sub DeleteVendor()
        Dim DelComp As VendorDataSet.CompanyRow
        DelComp = Me.MainVendorDataSet.Company.FindByCompanyName(Me.Edit_CompanyName_cbx.SelectedValue)
        Dim ID As Integer = DelComp.AddressID
        Dim DelAdd As VendorDataSet.CompanyDetailsRow
        DelAdd = Me.MainVendorDataSet.CompanyDetails.FindByAddressID(ID)
        Me.CompanyDetailsBindingSource.Filter = "CityID =" & DelAdd.CityID
        If Me.CompanyDetailsBindingSource.Count = 1 Then
            Dim DelCity As VendorDataSet.CompanyCityRow
            DelCity = Me.MainVendorDataSet.CompanyCity.FindByCityID(DelAdd.CityID)
            ID = DelCity.StateID
            DelCity.Delete()
            Me.CompanyCityTableAdapter.Update(Me.MainVendorDataSet)
            DelCity = Nothing
            Me.CompanyCityBindingSource.Filter = "StateID =" & ID
            If Me.CompanyCityBindingSource.Count = 0 Then
                Dim DelState As VendorDataSet.CompanyStateRow
                DelState = Me.MainVendorDataSet.CompanyState.FindByStateID(ID)
                ID = DelState.CountryID
                DelState.Delete()
                Me.CompanyStateTableAdapter.Update(Me.MainVendorDataSet)
                DelState = Nothing
                Me.CompanyStateBindingSource.Filter = "CountryID =" & ID
                If Me.CompanyStateBindingSource.Count = 0 Then
                    Dim DelCount As VendorDataSet.CompanyCountryRow
                    DelCount = Me.MainVendorDataSet.CompanyCountry.FindByCountryID(ID)
                    DelCount.Delete()
                    Me.CompanyCountryTableAdapter.Update(Me.MainVendorDataSet)
                    DelCount = Nothing
                End If
            End If
        End If
        Me.CompanyDetailsBindingSource.Filter = "PincodeID =" & DelAdd.PincodeID
        If Me.CompanyDetailsBindingSource.Count = 1 Then
            Dim DelPin As VendorDataSet.CompanyPincodeRow
            DelPin = Me.MainVendorDataSet.CompanyPincode.FindByPincodeID(DelAdd.PincodeID)
            DelPin.Delete()
            Me.CompanyPincodeTableAdapter.Update(Me.MainVendorDataSet)
        End If
        DelAdd.Delete()
        Me.CompanyDetailsTableAdapter.Update(Me.MainVendorDataSet)
        DelAdd = Nothing
        DelComp.Delete()
        Me.CompanyTableAdapter.Update(Me.MainVendorDataSet)
        DelComp = Nothing
        Me.CompanyCityBindingSource.Filter = Nothing
        Me.CompanyDetailsBindingSource.Filter = Nothing
        Me.CompanyStateBindingSource.Filter = Nothing
        Me.City_cbx.SelectedValue = -1
        Me.VendorTableAdapter.GetData()
        Me.VendorTableAdapter.Fill(Me.MainVendorDataSet.Vendor)
    End Sub

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
        NewDetails.Price = Me.Price_tbx.Text
        'If Me.Nos_tbx.Text <> "" Then
        '    NewDetails.Available_Nos = Me.Nos_tbx.Text
        'ElseIf Me.Nos_tbx.Text = "" Then
        NewDetails.Available_Nos = 0
        'End If
        NewDetails.Description = Me.Desc_tbx.Text
        If Me.Import_ckbx.Checked Then
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).Extension
            If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ref") Then
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
        'Me.Nos_tbx.Text = ""
        Me.Desc_tbx.Text = ""
    End Sub

#End Region

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.StockEntryTableAdapter.Fill(Me.MainInventoryDataSet.StockEntry)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class