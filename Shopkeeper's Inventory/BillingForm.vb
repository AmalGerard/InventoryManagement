Imports System.IO
Imports Microsoft.Office.Interop
Public Class BillingForm
    Dim Code As String
    Dim GrpID As Integer
    Dim ItmID As Integer
    Dim TypID As Integer
    Dim MatID As Integer
    Dim SizID As Integer
    Dim BDGVObj(0) As Object
    Dim SplitContObj(0) As Object

    Private Sub BillingForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Visible = True
        MainForm.Enabled = True
    End Sub

    Private Sub BillingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ShortBillTableAdapter.Fill(Me.MainBillingDataSet.ShortBill)
        'TODO: This line of code loads data into the 'BillingDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.MainBillingDataSet.Invoice)
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
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Groups' table. You can move, or remove it, as needed.
        Me.GroupsTableAdapter.Fill(Me.MainInventoryDataSet.Groups)
        'TODO: This line of code loads data into the 'InventoryDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
        Me.DetailsDataGridView.Sort(Me.DataGridViewTextBoxColumn1, System.ComponentModel.ListSortDirection.Ascending)
        Me.DetailsDataGridView.Columns(8).DisplayIndex = 1
        Me.DetailsDataGridView.Columns(6).DisplayIndex = 2
        Me.DetailsDataGridView.Columns(7).DisplayIndex = 3
        Me.Sav_btn.Enabled = False
        Me.Thisday_lbl.Text = Now.Date.ToString("dd/MM/yyyy")
        AddBill()
        GetBillNo()
        Me.BillNo_tbx.Text = Me.BillNo_tbx.Tag
        Me.DetailsDataGridView.Focus()
        BDGVObj(0) = Me.BDGV
        SplitContObj(0) = Me.SplitContainer3

        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        Me.DataGridViewTextBoxColumn2.HeaderText = "Price (" & Currency & ")"
        Me.Price_lbl.Text = "Price (" & Currency & "):"
        Me.Ttl_lbl.Text = "Bill Total " & Currency
        Me.Pay_lbl.Text = "Amt. Payable " & Currency
        Me.Per_lbl.Text = "%    or    " & Currency
        Me.Receive_lbl.Text = "Received " & Currency
        Me.Balance_lbl.Text = "Balance " & Currency
    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        If Me.TabControl.SelectedIndex = 0 Then
            Me.Edit_itm.Enabled = True
            Me.Del_Itm.Enabled = True
            Me.BindingNavigatorDeleteItem.Enabled = True
            Me.BindingNavigatorEditItem.Enabled = True
            Me.CloseToolStripMenuItem.Enabled = False
            Me.ClearBillToolStripMenuItem.Enabled = False
            Me.PrintPreviewToolStripMenuItem.Enabled = False
            Me.BillToExcelToolStripMenuItem.Enabled = False
        ElseIf Me.TabControl.SelectedIndex >= 1 Then
            If Me.TabControl.SelectedIndex = 1 Then
                Me.CloseToolStripMenuItem.Enabled = False
                Me.ClearBillToolStripMenuItem.Enabled = True
                Me.PrintPreviewToolStripMenuItem.Enabled = True
                Me.BillToExcelToolStripMenuItem.Enabled = True
            Else
                Me.CloseToolStripMenuItem.Enabled = True
                Me.ClearBillToolStripMenuItem.Enabled = True
                Me.PrintPreviewToolStripMenuItem.Enabled = True
                Me.BillToExcelToolStripMenuItem.Enabled = True
            End If
            Me.BDGV = CType(BDGVObj(Me.TabControl.SelectedIndex - 1), DataGridView)
            Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
            Me.BDGV.Columns(3).HeaderText = "Rate (" & Currency & ")"
            If Me.BDGV.ColumnCount = 7 Then
                Me.BDGV.Columns(6).HeaderText = "Amount (" & Currency & ")"
            ElseIf Me.BDGV.ColumnCount = 6 Then
                Me.BDGV.Columns(5).HeaderText = "Amount (" & Currency & ")"
            End If

            Me.SplitContainer3 = CType(SplitContObj(Me.TabControl.SelectedIndex - 1), SplitContainer)
            SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel1)
            MakeTotal()
            Me.Edit_itm.Enabled = False
            Me.Del_Itm.Enabled = False
            Me.BindingNavigatorDeleteItem.Enabled = False
            Me.BindingNavigatorEditItem.Enabled = False

            If Microsoft.VisualBasic.Left(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 16) = "New Billing List" Then
                Me.BillNo_tbx.Text = Me.BillNo_tbx.Tag
            Else
                Me.BillNo_tbx.Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Tag
            End If

        End If

    End Sub

    Private Sub DetailsDataGridView_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DetailsDataGridView.CellContentDoubleClick
        Me.TabControl.SelectTab(0)

        EditReady()

        Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString

        FillDetails()

        Me.Sav_btn.Enabled = False

    End Sub

    Private Sub Srch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Srch_btn.Click
        EditReady()

        Code = Me.Srch_tbx.Text.Trim

        Try

            FillDetails()

            Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource
            Dim Index As Integer = Me.DetailsBindingSource.Find("Code", Code)
            Me.DetailsDataGridView.CurrentCell = Me.DetailsDataGridView.Rows(Index).Cells(0)
        Catch ex As Exception
            MessageBox.Show("No such Product exists. Verify the entered Prdoduct Code.", "Product not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Sav_btn.Enabled = False

    End Sub

    Private Sub BindingNavigatorEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorEditItem.Click, Edit_itm.Click

        Me.TabControl.SelectTab(0)

        EditReady()

        Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString

        FillDetails()

        Me.Sav_btn.Enabled = False

    End Sub

    Private Sub ShowReferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowReferenceToolStripMenuItem.Click, ShowRef_btn.Click
        ShowRef()
    End Sub

    Private Sub DetailsDataGridView_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DetailsDataGridView.KeyPress
        If e.KeyChar = "e" Or e.KeyChar = "E" Then
            Me.TabControl.SelectTab(0)

            EditReady()

            Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString

            FillDetails()

            Me.Sav_btn.Enabled = False

        ElseIf e.KeyChar = "r" Or e.KeyChar = "R" Then
            ShowRef()
        ElseIf e.KeyChar = ChrW(Keys.Space) Then
            Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString
            AddItemtoBill()
        End If
    End Sub

    Private Sub CGrp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CGrp_btn.Click
        Me.TabPage1.Controls.Remove(Me.Grp_tbx)
        Me.TabPage1.Controls.Add(Me.Grp_cbx)
        Me.Grp_cbx.DataSource = Me.GroupsBindingSource
        Me.Grp_cbx.DisplayMember = "Category"
        Me.Grp_cbx.ValueMember = "GroupID"
        Me.Grp_cbx.SelectedValue = GrpID
        Me.CGrp_btn.Enabled = False
        Me.Sav_btn.Tag = "G"
        Me.TabPage1.Controls.Remove(Me.Itm_tbx)
        Me.TabPage1.Controls.Add(Me.Itm_cbx)
        Me.ItemsBindingSource.Filter = "GroupID =" & GrpID
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.Itm_cbx.SelectedValue = ItmID
        Me.CItm_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Typ_tbx)
        Me.TabPage1.Controls.Add(Me.Typ_cbx)
        Me.TypesBindingSource.Filter = "ItemID =" & ItmID
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.Typ_cbx.SelectedValue = TypID
        Me.CTyp_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_cbx)
        Me.MaterialsBindingSource.Filter = "TypeID =" & TypID
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.Mat_cbx.SelectedValue = MatID
        Me.CMat_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Siz_cbx)
        Me.SizeBindingSource.Filter = "MatID =" & MatID
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.Siz_cbx.SelectedValue = SizID
        Me.CSiz_btn.Enabled = False
    End Sub

    Private Sub CItm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CItm_btn.Click
        Me.TabPage1.Controls.Remove(Me.Itm_tbx)
        Me.TabPage1.Controls.Add(Me.Itm_cbx)
        Me.ItemsBindingSource.Filter = "GroupID =" & GrpID
        Me.Itm_cbx.DataSource = Me.ItemsBindingSource
        Me.Itm_cbx.DisplayMember = "ItemName"
        Me.Itm_cbx.ValueMember = "ItemID"
        Me.Itm_cbx.SelectedValue = ItmID
        Me.CItm_btn.Enabled = False
        Me.Sav_btn.Tag = "I"
        Me.TabPage1.Controls.Remove(Me.Typ_tbx)
        Me.TabPage1.Controls.Add(Me.Typ_cbx)
        Me.TypesBindingSource.Filter = "ItemID =" & ItmID
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.Typ_cbx.SelectedValue = TypID
        Me.CTyp_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_cbx)
        Me.MaterialsBindingSource.Filter = "TypeID =" & TypID
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.Mat_cbx.SelectedValue = MatID
        Me.CMat_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Siz_cbx)
        Me.SizeBindingSource.Filter = "MatID =" & MatID
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.Siz_cbx.SelectedValue = SizID
        Me.CSiz_btn.Enabled = False
    End Sub

    Private Sub CTyp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTyp_btn.Click
        Me.TabPage1.Controls.Remove(Me.Typ_tbx)
        Me.TabPage1.Controls.Add(Me.Typ_cbx)
        Me.TypesBindingSource.Filter = "ItemID =" & ItmID
        Me.Typ_cbx.DataSource = Me.TypesBindingSource
        Me.Typ_cbx.DisplayMember = "Type"
        Me.Typ_cbx.ValueMember = "TypeID"
        Me.Typ_cbx.SelectedValue = TypID
        Me.CTyp_btn.Enabled = False
        Me.Sav_btn.Tag = "T"
        Me.TabPage1.Controls.Remove(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_cbx)
        Me.MaterialsBindingSource.Filter = "TypeID =" & TypID
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.Mat_cbx.SelectedValue = MatID
        Me.CMat_btn.Enabled = False
        Me.TabPage1.Controls.Remove(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Siz_cbx)
        Me.SizeBindingSource.Filter = "MatID =" & MatID
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.Siz_cbx.SelectedValue = SizID
        Me.CSiz_btn.Enabled = False
    End Sub

    Private Sub CMat_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMat_btn.Click
        Me.TabPage1.Controls.Remove(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_cbx)
        Me.MaterialsBindingSource.Filter = "TypeID =" & TypID
        Me.Mat_cbx.DataSource = Me.MaterialsBindingSource
        Me.Mat_cbx.DisplayMember = "Material"
        Me.Mat_cbx.ValueMember = "MatID"
        Me.Mat_cbx.SelectedValue = MatID
        Me.CMat_btn.Enabled = False
        Me.Sav_btn.Tag = "M"
        Me.TabPage1.Controls.Remove(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Siz_cbx)
        Me.SizeBindingSource.Filter = "MatID =" & MatID
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.Siz_cbx.SelectedValue = SizID
        Me.CSiz_btn.Enabled = False
    End Sub

    Private Sub CSiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSiz_btn.Click
        Me.TabPage1.Controls.Remove(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Siz_cbx)
        Me.SizeBindingSource.Filter = "MatID =" & MatID
        Me.Siz_cbx.DataSource = Me.SizeBindingSource
        Me.Siz_cbx.DisplayMember = "Size"
        Me.Siz_cbx.ValueMember = "SizeID"
        Me.Siz_cbx.SelectedValue = SizID
        Me.CSiz_btn.Enabled = False
        Me.Sav_btn.Tag = "S"
    End Sub

    Private Sub Grp_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_cbx.SelectedValueChanged
        If Me.CGrp_btn.Enabled = False Then
            If Me.Grp_cbx.SelectedValue <> GrpID Then
                Me.Sav_btn.Enabled = True
            End If
            If Me.Grp_cbx.SelectedValue <> Nothing Then
                Me.ItemsBindingSource.Filter = "GroupID =" & Me.Grp_cbx.SelectedValue
                If Me.Itm_cbx.SelectedValue <> Nothing Then
                    Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                    If Me.Typ_cbx.SelectedValue <> Nothing Then
                        Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                        If Me.Mat_cbx.SelectedValue <> Nothing Then
                            Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                            If Me.Siz_cbx.SelectedValue <> Nothing Then
                                Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                            Else
                                Me.Details1BindingSource.Filter = "SizeID =" & -1
                            End If
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub Itm_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Itm_cbx.SelectedValueChanged
        If Me.CItm_btn.Enabled = False Then
            If Me.Itm_cbx.SelectedValue <> ItmID Then
                Me.Sav_btn.Enabled = True
            End If
            If Me.Itm_cbx.SelectedValue <> Nothing Then
                Me.TypesBindingSource.Filter = "ItemID =" & Me.Itm_cbx.SelectedValue
                If Me.Typ_cbx.SelectedValue <> Nothing Then
                    Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                    If Me.Mat_cbx.SelectedValue <> Nothing Then
                        Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                        If Me.Siz_cbx.SelectedValue <> Nothing Then
                            Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                        Else
                            Me.Details1BindingSource.Filter = "SizeID =" & -1
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Typ_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Typ_cbx.SelectedValueChanged
        If Me.CTyp_btn.Enabled = False Then
            If Me.Typ_cbx.SelectedValue <> TypID Then
                Me.Sav_btn.Enabled = True
            End If

            If Me.Typ_cbx.SelectedValue <> Nothing Then
                Me.MaterialsBindingSource.Filter = "TypeID =" & Me.Typ_cbx.SelectedValue
                If Me.Mat_cbx.SelectedValue <> Nothing Then
                    Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                    If Me.Siz_cbx.SelectedValue <> Nothing Then
                        Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                    Else
                        Me.Details1BindingSource.Filter = "SizeID =" & -1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Mat_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mat_cbx.SelectedValueChanged
        If Me.CMat_btn.Enabled = False Then
            If Me.Mat_cbx.SelectedValue <> MatID Then
                Me.Sav_btn.Enabled = True
            End If
            If Me.Mat_cbx.SelectedValue <> Nothing Then
                Me.SizeBindingSource.Filter = "MatID =" & Me.Mat_cbx.SelectedValue
                If Me.Siz_cbx.SelectedValue <> Nothing Then
                    Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
                Else
                    Me.Details1BindingSource.Filter = "SizeID =" & -1
                End If
            End If
        End If
    End Sub

    Private Sub Siz_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Siz_cbx.SelectedValueChanged
        If Me.CSiz_btn.Enabled = False Then
            If Me.Siz_cbx.SelectedValue <> SizID Then
                Me.Sav_btn.Enabled = True
            End If

            If Me.Siz_cbx.SelectedValue <> Nothing Then
                Me.Details1BindingSource.Filter = "SizeID =" & Me.Siz_cbx.SelectedValue
            Else
                Me.Details1BindingSource.Filter = "SizeID =" & -1
            End If
        End If
    End Sub

    Private Sub Sav_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sav_btn.Click

        Me.Cursor = Cursors.WaitCursor
        Me.Status_lbl.Text = "Saving Changes"
        If IsNumeric(CDbl(Me.Price_tbx.Text)) = False Then
            MessageBox.Show("The entered price is invalid, please check", "Invalid Input", MessageBoxButtons.OK)
            Me.Price_tbx.Focus()
            Exit Sub
        ElseIf IsNumeric(CInt(Me.Nos_tbx.Text)) = False Then
            MessageBox.Show("The entered available nos. is invalid, please check", "Invalid Input", MessageBoxButtons.OK)
            Me.Nos_tbx.Focus()
            Exit Sub
        End If
        Dim EditDetails As InventoryDataSet.Details1Row
        EditDetails = Me.MainInventoryDataSet.Details1.FindByCode(Code)
        EditDetails.BeginEdit()
        EditDetails.Code = Me.Code_tbx.Text.Trim
        EditDetails.Price = CDbl(Me.Price_tbx.Text)
        EditDetails.Available_Nos = CInt(Me.Nos_tbx.Text)
        Dim Desc As String = EditDetails.Description
        EditDetails.Description = Me.Desc_tbx.Text
        If Me.Import_ckbx.Checked And My.Computer.FileSystem.FileExists(Me.Ref_tbx.Text) Then
            Dim ext As String = My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).Extension
            If My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                EditDetails.Reference = Me.Ref_tbx.Text
            ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Ref") Then
                My.Computer.FileSystem.CopyFile(Me.Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext, True)
                EditDetails.Reference = My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext
            Else
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath + "\Ref")
                My.Computer.FileSystem.CopyFile(Me.Ref_tbx.Text, My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext, True)
                EditDetails.Reference = My.Application.Info.DirectoryPath + "\Ref\" + Me.Code_tbx.Text + ext
            End If
        Else
            EditDetails.Reference = Me.Ref_tbx.Text
        End If

        If Me.Sav_btn.Tag = "G" Then
            EditDetails.GroupID = Me.Grp_cbx.SelectedValue
            EditDetails.ItemID = Me.Itm_cbx.SelectedValue
            EditDetails.TypeID = Me.Typ_cbx.SelectedValue
            EditDetails.MatID = Me.Mat_cbx.SelectedValue
            EditDetails.SizeID = Me.Siz_cbx.SelectedValue
        ElseIf Me.Sav_btn.Tag = "I" Then
            EditDetails.ItemID = Me.Itm_cbx.SelectedValue
            EditDetails.TypeID = Me.Typ_cbx.SelectedValue
            EditDetails.MatID = Me.Mat_cbx.SelectedValue
            EditDetails.SizeID = Me.Siz_cbx.SelectedValue
        ElseIf Me.Sav_btn.Tag = "T" Then
            EditDetails.TypeID = Me.Typ_cbx.SelectedValue
            EditDetails.MatID = Me.Mat_cbx.SelectedValue
            EditDetails.SizeID = Me.Siz_cbx.SelectedValue
        ElseIf Me.Sav_btn.Tag = "M" Then
            EditDetails.MatID = Me.Mat_cbx.SelectedValue
            EditDetails.SizeID = Me.Siz_cbx.SelectedValue
        ElseIf Me.Sav_btn.Tag = "S" Then
            EditDetails.SizeID = Me.Siz_cbx.SelectedValue
        End If

        Try
            EditDetails.EndEdit()
            Me.Details1TableAdapter.Update(EditDetails)
            EditDetails = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        If Desc <> Me.Desc_tbx.Text Or Code <> Me.Code_tbx.Text Then
            Me.Status_lbl.Text = "Updating Billing lists"
            UpdateBill(Code, Me.Code_tbx.Text.Trim)
        End If

        If Desc <> Me.Desc_tbx.Text Or Code <> Me.Code_tbx.Text Then
            Me.Status_lbl.Text = "Updating Saved Bills"
            UpdateSavedBills(Code)
        End If

        If Code <> Me.Code_tbx.Text Then
            Me.Status_lbl.Text = "Updating Stock Entries"
            UpdateStock(Code)
        End If

        EditReady()
        Me.DetailsTableAdapter.GetData()
        Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
        Code = Me.Code_tbx.Text.Trim

        Try

            FillDetails()

            Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource
            Dim Index As Integer = Me.DetailsBindingSource.Find("Code", Code)
            Me.DetailsDataGridView.CurrentCell = Me.DetailsDataGridView.Rows(Index).Cells(0)

        Catch ex As Exception
            MessageBox.Show("No such Product exists. Verify the entered Prdoduct Code.", "Product not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.Status_lbl.Text = "Edit Successful"
        Me.Cursor = Cursors.Default
        Me.Sav_btn.Enabled = False
    End Sub

    Private Sub Del_Itm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_Itm.Click, BindingNavigatorDeleteItem.Click

        Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Dim Result As DialogResult
        Result = MessageBox.Show("Are you sure to delete the Product with Code """ + Code + """.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Dim DelDetails As InventoryDataSet.Details1Row
            DelDetails = Me.MainInventoryDataSet.Details1.FindByCode(Code)
            DelDetails.Delete()
            Me.Details1TableAdapter.Update(Me.MainInventoryDataSet)
            Me.DetailsTableAdapter.GetData()
            Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)

            InitialState()

        End If
    End Sub

    Private Sub Code_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code_tbx.TextChanged
        If Code <> "" Then
            Me.Sav_btn.Enabled = True
        End If
    End Sub

    Private Sub Price_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Price_tbx.TextChanged
        If Code <> "" Then
            Me.Sav_btn.Enabled = True
        End If
    End Sub

    Private Sub Nos_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nos_tbx.TextChanged
        If Code <> "" Then
            Me.Sav_btn.Enabled = True
        End If
    End Sub

    Private Sub Desc_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desc_tbx.TextChanged
        If Code <> "" Then
            Me.Sav_btn.Enabled = True
        End If
    End Sub

    Private Sub Ref_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ref_tbx.TextChanged
        If Code <> "" Then
            Me.Sav_btn.Enabled = True
            Me.Import_ckbx.Enabled = True
        End If
    End Sub

    Private Sub Browse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse_btn.Click
        If Me.Browse_btn.Tag = "B" Then
            Dim result As DialogResult
            result = Me.RefFile_dbx.ShowDialog()
            If result = System.Windows.Forms.DialogResult.OK Then
                Me.Ref_tbx.Text = Me.RefFile_dbx.FileName
            End If
        ElseIf Me.Browse_btn.Tag = "R" Then
            If My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).DirectoryName <> My.Application.Info.DirectoryPath + "\Ref" Then
                Editref()
                Me.Ref_tbx.Text = ""
            ElseIf My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).DirectoryName = My.Application.Info.DirectoryPath + "\Ref" Then
                Dim refile As String = My.Computer.FileSystem.GetFileInfo(Me.Ref_tbx.Text).Name
                Dim result As DialogResult
                result = MessageBox.Show("The reference associated with the Product will be removed. Would you like to delete the  file " + refile + "? If 'Yes' the file will be sent to the recycle bin.", "Delete file!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Editref()
                    Try
                        My.Computer.FileSystem.DeleteFile(Me.Ref_tbx.Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
                        Me.Ref_tbx.Text = ""
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                ElseIf result = System.Windows.Forms.DialogResult.No Then
                    Editref()
                    Me.Ref_tbx.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub Filter_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter_cbx.SelectedIndexChanged
        If Me.Filter_cbx.SelectedIndex <> 0 Then
            Me.Filter_tbx.Enabled = True
            Me.Filter_tbx.ForeColor = Color.Gray
            If Me.Filter_cbx.Text = "Item" Then
                Me.Filter_tbx.Text = "Enter an " + Me.Filter_cbx.Text
            ElseIf Me.Filter_cbx.Text <> "Item" Then
                Me.Filter_tbx.Text = "Enter a " + Me.Filter_cbx.Text
            End If
            Me.Filter_btn.Enabled = True
        ElseIf Me.Filter_cbx.SelectedIndex = 0 Then
            Me.Filter_tbx.Enabled = False
            Me.Filter_btn.Enabled = False
            Me.DetailsBindingSource.RemoveFilter()
            Me.DetailsDataGridView.DataSource = Me.DetailsBindingSource
        End If
    End Sub

    Private Sub Filter_tbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter_tbx.Click
        If Me.Filter_tbx.Text = "Enter a Category" Then
            Me.Filter_tbx.Text = ""
            Me.Filter_tbx.ForeColor = Color.Black
        ElseIf Me.Filter_tbx.Text = "Enter an Item" Then
            Me.Filter_tbx.Text = ""
            Me.Filter_tbx.ForeColor = Color.Black
        ElseIf Me.Filter_tbx.Text = "Enter a Type" Then
            Me.Filter_tbx.Text = ""
            Me.Filter_tbx.ForeColor = Color.Black
        ElseIf Me.Filter_tbx.Text = "Enter a Material" Then
            Me.Filter_tbx.Text = ""
            Me.Filter_tbx.ForeColor = Color.Black
        ElseIf Me.Filter_tbx.Text = "Enter a Size" Then
            Me.Filter_tbx.Text = ""
            Me.Filter_tbx.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Filter_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter_btn.Click

        Dim filt As String
        If Me.Filter_cbx.Text = "Item" Then
            filt = "ItemName= '" + Me.Filter_tbx.Text + "'"
        Else
            filt = Me.Filter_cbx.Text + "= '" + Me.Filter_tbx.Text + "'"
        End If

        Dim Dv As DataView = New DataView(Me.MainInventoryDataSet.Details, filt, "Code", DataViewRowState.CurrentRows)
        Me.DetailsDataGridView.DataSource = Dv.ToTable().DefaultView

    End Sub

    Private Sub BindingNavigatorAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddItem.Click, Add_Itm.Click
        Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        AddItemtoBill()
    End Sub

    Private Sub BillingDataGridView_RowHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BDGV.RowHeaderMouseClick
        Me.BDGV.CurrentCell = Me.BDGV.CurrentRow.Cells(0)
        'Me.BillingDataGridView.CurrentRow.Selected = True
    End Sub

    Private Sub BillingDataGridView_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles BDGV.RowsRemoved
        Dim index As Integer = e.RowIndex
        Do While index + 1 < Me.BDGV.Rows.Count
            Me.BDGV.CurrentCell = Me.BDGV.Rows(index).Cells(0)
            Me.BDGV.CurrentCell.Value = (index + 1).ToString
            index += 1
        Loop
        MakeTotal()
        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If
    End Sub

    Private Sub RAmt_tbx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RAmt_tbx.Leave
        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If
        ShowBal()
    End Sub

    Private Sub DiscPer_tbx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscPer_tbx.Leave
        If Me.DiscPer_tbx.Text = "" Then
            Me.DiscAmt_tbx.Enabled = True
            Me.Pay_tbx.Text = Me.Ttl_tbx.Text
            ShowBal()
            Exit Sub
        ElseIf Me.DiscPer_tbx.Text = 0 Then
            Me.DiscAmt_tbx.Enabled = True
            Me.Pay_tbx.Text = Me.Ttl_tbx.Text
            ShowBal()
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
        ElseIf IsNumeric(Me.DiscPer_tbx.Text) = True And Me.Ttl_tbx.Text <> "" And Me.DiscPer_tbx.Enabled = True Then
            Me.DiscAmt_tbx.Text = (CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.Ttl_tbx.Text))).ToString("0.00")
            Me.Pay_tbx.Text = (CDbl(Me.Ttl_tbx.Text) - CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.Ttl_tbx.Text))).ToString("0.00")
            Me.DiscAmt_tbx.Enabled = False
        ElseIf IsNumeric(Me.DiscPer_tbx.Text) = True And Me.Ttl_tbx.Text = "" And Me.DiscPer_tbx.Enabled = True Then
            Me.DiscAmt_tbx.Enabled = False
        End If
        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If
        ShowBal()
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
            Me.Pay_tbx.Text = Me.Ttl_tbx.Text
            ShowBal()
            Exit Sub
        ElseIf Me.DiscAmt_tbx.Text = 0 Then
            Me.DiscPer_tbx.Enabled = True
            Me.Pay_tbx.Text = Me.Ttl_tbx.Text
            ShowBal()
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
        ElseIf IsNumeric(Me.DiscAmt_tbx.Text) = True And Me.Ttl_tbx.Text <> "" And Me.DiscAmt_tbx.Enabled = True Then
            Me.Pay_tbx.Text = CDbl(CDbl(Me.Ttl_tbx.Text) - CDbl(Me.DiscAmt_tbx.Text)).ToString("0.00")
            Me.DiscPer_tbx.Enabled = False
        ElseIf IsNumeric(Me.DiscAmt_tbx.Text) = True And Me.Ttl_tbx.Text = "" And Me.DiscAmt_tbx.Enabled = True Then
            Me.DiscPer_tbx.Enabled = False
        End If
        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If
        ShowBal()
    End Sub

    Private Sub DiscAmt_tbx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscAmt_tbx.TextChanged
        If Me.DiscAmt_tbx.Text = "" Then
            Me.DiscPer_tbx.Text = ""
            Me.DiscPer_tbx.Enabled = True
        ElseIf Me.DiscAmt_tbx.Text = 0 Then
            Me.DiscPer_tbx.Enabled = True
        End If
    End Sub

    Private Sub Prv_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prv_btn.Click, PrintPreviewToolStripMenuItem.Click
        MakeTotal()
        'Call Me.GenHtm()
        'PreviewForm.Preview_wbr.Navigate("file:\\\C:/Print/Temp.htm")
        PreviewForm.Tag = "B"
        PreviewForm.ShowDialog()
    End Sub

    Private Sub BDGV_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BDGV.CellEndEdit
        If e.ColumnIndex = 1 Then
            Code = Me.BDGV.CurrentCell.Value
            If Code <> "" Then
                FillRow()
            End If
        ElseIf e.ColumnIndex = 2 Then
            If Me.BDGV.Focused = True Then
                Code = Me.DetailsDataGridView.CurrentRow.Cells(0).Value.ToString
            End If
            Try
                If Me.BDGV.CurrentCell.Value <> "" And Code <> "" Then
                    FillRow()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            
        ElseIf e.ColumnIndex = 3 Then
            If IsNumeric(Me.BDGV.CurrentRow.Cells.Item(3).Value) = False Then
                Me.BDGV.CurrentRow.Cells.Item(3).Value = "0.00"
            End If
            LinePrice()
        ElseIf e.ColumnIndex = 4 Then
            If IsNumeric(Me.BDGV.CurrentRow.Cells.Item(4).Value) = False Then
                Me.BDGV.CurrentRow.Cells.Item(4).Value = 1
            End If
            LinePrice()
        ElseIf Me.BDGV.Columns.Count = 7 And e.ColumnIndex = 5 Then
            If IsNumeric(Me.BDGV.CurrentRow.Cells.Item(5).Value) = False Then
                MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.BDGV.CurrentRow.Cells.Item(5).Value = "0.00"
            ElseIf CDbl(Me.BDGV.CurrentRow.Cells.Item(5).Value) > 100 Or Me.BDGV.CurrentRow.Cells.Item(5).Value < 0 Then
                MessageBox.Show("Enter a number from 0 to 100 as discount percent.", "Discount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.BDGV.CurrentRow.Cells.Item(5).Value = "0.00"
            ElseIf CDbl(Me.BDGV.CurrentRow.Cells.Item(5).Value) <> 0 Then
                Me.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl((Me.BDGV.CurrentRow.Cells.Item(3).Value - Me.BDGV.CurrentRow.Cells.Item(5).Value / 100 * Me.BDGV.CurrentRow.Cells.Item(3).Value) * Me.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            ElseIf CDbl(Me.BDGV.CurrentRow.Cells.Item(5).Value) = 0 Then
                Me.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl(Me.BDGV.CurrentRow.Cells.Item(3).Value * Me.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
            End If
            MakeTotal()
        End If

        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If

    End Sub

    Private Sub BDGV_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles BDGV.CellBeginEdit
        If Me.BDGV.CurrentCell.ColumnIndex > 0 Then
            Me.DetailsBindingSource.Sort = Me.DetailsDataGridView.SortedColumn.DataPropertyName.ToString
        End If
    End Sub

    Private Sub Col_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Col_btn.Click
        If Me.Col_btn.Text = ">>>" Then
            Me.DetailsDataGridView.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Me.SplitContainer4.Panel2Collapsed = True
            Me.Col_btn.Text = "<<<"
        ElseIf Me.Col_btn.Text = "<<<" Then
            Me.DetailsDataGridView.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Me.DataGridViewTextBoxColumn4.Width = 200
            Me.SplitContainer4.Panel2Collapsed = False
            Me.Col_btn.Text = ">>>"
        End If
    End Sub

    Private Sub DetailsDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsDataGridView.Click, DetailsDataGridView.SelectionChanged
        If Me.DetailsDataGridView.RowCount > 0 Then
            Code = Me.DetailsDataGridView.CurrentRow.Cells(0).Value.ToString
            Dim GetDetails As InventoryDataSet.Details1Row
            GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(Code)
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
        End If
    End Sub

#Region "MenuStrip Items"

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        AddBill()

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        If Me.BDGV.Columns.Count = 6 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 0)
        ElseIf Me.BDGV.Columns.Count = 7 Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 1)
        End If
        Dim result As DialogResult = OptionsDialog.ShowDialog()
        If result = System.Windows.Forms.DialogResult.OK Then

            Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
            Me.DataGridViewTextBoxColumn2.HeaderText = "Price (" & Currency & ")"
            Me.Price_lbl.Text = "Price (" & Currency & "):"
            Me.Ttl_lbl.Text = "Bill Total " & Currency
            Me.Pay_lbl.Text = "Amt. Payable " & Currency
            Me.Per_lbl.Text = "%    or    " & Currency
            Me.Receive_lbl.Text = "Received " & Currency
            Me.Balance_lbl.Text = "Balance " & Currency
            Me.Column4.HeaderText = "Rate (" & Currency & ")"
            Me.Column6.HeaderText = "Amount (" & Currency & ")"

            Dim Checked As Integer
            Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 1))
            If Checked = 0 And Me.BDGV.Columns.Count = 7 Then
                Me.BDGV.Columns.Remove("Discount")
                For i As Integer = 0 To (Me.BDGV.Rows.Count - 2)
                    Me.BDGV.Rows(i).Cells(5).Value = CDbl(CDbl(Me.BDGV.Rows(i).Cells(3).Value) * CDbl(Me.BDGV.Rows(i).Cells(4).Value)).ToString("0.00")
                    MakeTotal()
                Next
            ElseIf Checked = 1 Then
                If Me.BDGV.Columns.Count = 6 Then
                    Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn
                    Me.Discount.HeaderText = "Disc. %"
                    Me.Discount.Name = "Discount"
                    Me.Discount.Width = 50
                    Me.BDGV.Columns.Insert(5, Me.Discount)
                    For i As Integer = 0 To (Me.BDGV.Rows.Count - 2)
                        Me.BDGV.Rows(i).Cells(5).Value = 0
                    Next
                End If
            End If
            GetBillNo()
            If Microsoft.VisualBasic.Left(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 16) = "New Billing List" Then
                Me.BillNo_tbx.Text = Me.BillNo_tbx.Tag
            Else
                Me.BillNo_tbx.Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Tag
            End If
            Dim Opt As String = MainForm.FillGenPref()
            Dim GenOpt() As String = Opt.Split(vbCrLf)
            Me.Text = GenOpt(0).ToString + " - Billing"
            MainForm.Text = GenOpt(0).ToString + "'s Inventory Managment"
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If Me.TabControl.SelectedIndex > 1 Then
            Me.TabControl.TabPages.RemoveAt(Me.TabControl.SelectedIndex)
            Me.TabControl.SelectTab(1)
        End If
    End Sub

    Private Sub ProductsToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsToExcelToolStripMenuItem.Click
        ExportDtl()
    End Sub

    Private Sub BillToExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToExcelToolStripMenuItem.Click
        ExportBill()
    End Sub

    Private Sub ClearBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearBillToolStripMenuItem.Click
        Me.BDGV.Rows.Clear()
        If Me.TabControl.SelectedIndex = 1 And Me.TabControl.Tag = "History" Then
            Me.TabControl.Tag = ""
        End If
        Me.DiscAmt_tbx.Text = ""
        Me.DiscPer_tbx.Text = ""
        Me.RAmt_tbx.Text = ""
        Me.BAmt_tbx.Text = ""
        MakeTotal()
        Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List"
        Me.BillNo_tbx.Text = Me.BillNo_tbx.Tag
    End Sub

#End Region

#Region "Methods"
    Private Sub GetDetails()
        Dim GetDetails As InventoryDataSet.Details1Row
        GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(Me.Code_tbx.Text)
        GrpID = GetDetails.GroupID
        ItmID = GetDetails.ItemID
        TypID = GetDetails.TypeID
        MatID = GetDetails.MatID
        SizID = GetDetails.SizeID
    End Sub

    Private Sub ShowBal()
        If Me.RAmt_tbx.Text = "" Then
            Exit Sub
        ElseIf IsNumeric(Me.RAmt_tbx.Text) = True Then
            Me.BAmt_tbx.Text = (CDbl(Me.RAmt_tbx.Text) - CDbl(Me.Pay_tbx.Text)).ToString("0.00")
        ElseIf IsNumeric(Me.RAmt_tbx.Text) = False Then
            MessageBox.Show("Enter a valid number in the Received amount Box.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MakeTotal()
        If Me.BDGV.Rows.Count = 1 Then
            Me.Ttl_tbx.Text = "0.00"
            Me.Pay_tbx.Text = "0.00"
            Exit Sub
        End If
        Dim Total As Double
        For i As Integer = 0 To Me.BDGV.Rows.Count - 2
            If Me.BDGV.Columns.Count = 7 Then
                Total = Total + CDbl(Me.BDGV.Rows.Item(i).Cells(6).Value)
            ElseIf Me.BDGV.Columns.Count = 6 Then
                Total = Total + CDbl(Me.BDGV.Rows.Item(i).Cells(5).Value)
            End If
        Next
        Me.Ttl_tbx.Text = Total.ToString("0.00")
        If Me.DiscAmt_tbx.Text = "" And Me.DiscPer_tbx.Text = "" Then
            Me.Pay_tbx.Text = Me.Ttl_tbx.Text
        ElseIf Me.DiscAmt_tbx.Enabled = True And Me.DiscAmt_tbx.Text <> "" Then
            Me.Pay_tbx.Text = (Total - CDbl(Me.DiscAmt_tbx.Text)).ToString("0.00")
        ElseIf Me.DiscPer_tbx.Enabled = True And Me.DiscPer_tbx.Text <> "" Then
            Me.DiscAmt_tbx.Text = CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * Total).ToString("0.00")
            Me.Pay_tbx.Text = Total - CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * Total).ToString("0.00")
        End If
        
        ShowBal()
    End Sub

    Private Sub ShowRef()
        Code = Me.DetailsDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        Dim GetRef As InventoryDataSet.Details1Row
        GetRef = Me.MainInventoryDataSet.Details1.FindByCode(Code)
        Dim FileName As String = GetRef.Reference
        If My.Computer.FileSystem.FileExists(FileName) Then
            Me.Cursor = Cursors.WaitCursor
            System.Diagnostics.Process.Start(FileName)
            Me.Cursor = Cursors.Default
        ElseIf My.Computer.FileSystem.FileExists(FileName) = False Then
            MessageBox.Show("No reference is associated with this product", "Reference not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FillDetails()
        Dim GetDetails As InventoryDataSet.DetailsRow
        GetDetails = MainInventoryDataSet.Details.FindByCode(Code)
        Me.Grp_tbx.Text = GetDetails.Category
        Me.Itm_tbx.Text = GetDetails.ItemName
        Me.Typ_tbx.Text = GetDetails.Type
        Me.Mat_tbx.Text = GetDetails.Material
        Me.Siz_tbx.Text = GetDetails.Size
        Me.Code_tbx.Text = GetDetails.Code
        Me.Price_tbx.Text = GetDetails.Price
        Me.Nos_tbx.Text = GetDetails.Available_Nos
        Me.Desc_tbx.Text = GetDetails.Description
        Me.Ref_tbx.Text = GetDetails.Reference
        If Me.Ref_tbx.Text <> "" Then
            If My.Computer.FileSystem.FileExists(Me.Ref_tbx.Text) Then
                Me.Browse_btn.Text = "Remove"
                Me.Browse_btn.Tag = "R"
                Me.Import_ckbx.Enabled = False
            ElseIf My.Computer.FileSystem.FileExists(Me.Ref_tbx.Text) = False Then
                MessageBox.Show("The specified reference file doesnot exist, browse to add a reference.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Ref_tbx.Text = ""
                Me.Browse_btn.Text = "Browse"
                Me.Browse_btn.Tag = "B"
                Me.Import_ckbx.Enabled = True
            End If
        End If

        Me.GetDetails()
    End Sub

    Private Sub EditReady()
        Me.Sav_btn.Tag = ""
        Me.TabPage1.Controls.Remove(Me.Siz_cbx)
        Me.TabPage1.Controls.Remove(Me.Mat_cbx)
        Me.TabPage1.Controls.Remove(Me.Typ_cbx)
        Me.TabPage1.Controls.Remove(Me.Itm_cbx)
        Me.TabPage1.Controls.Remove(Me.Grp_cbx)
        Me.TabPage1.Controls.Add(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Typ_tbx)
        Me.TabPage1.Controls.Add(Me.Itm_tbx)
        Me.TabPage1.Controls.Add(Me.Grp_tbx)
        Me.CGrp_btn.Enabled = True
        Me.CItm_btn.Enabled = True
        Me.CTyp_btn.Enabled = True
        Me.CMat_btn.Enabled = True
        Me.CSiz_btn.Enabled = True
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.Tag = "B"
        Me.Browse_btn.Enabled = True
        Me.Import_ckbx.Enabled = True
    End Sub

    Private Sub Editref()
        Dim EditDetails As InventoryDataSet.Details1Row
        EditDetails = Me.MainInventoryDataSet.Details1.FindByCode(Code)
        EditDetails.BeginEdit()
        EditDetails.Reference = ""
        EditDetails.EndEdit()
        Me.Details1TableAdapter.Update(EditDetails)
        Me.DetailsTableAdapter.GetData()
        Me.DetailsTableAdapter.Fill(Me.MainInventoryDataSet.Details)
        Try
            Me.RefPic_pbx.Image.Dispose()
        Catch ex As Exception

        End Try
        Me.Browse_btn.Text = "Browse"
        Me.Browse_btn.Tag = "B"
        Me.Sav_btn.Enabled = False
        Me.Import_ckbx.Checked = False
        Me.Import_ckbx.Enabled = True
        Code = Me.Code_tbx.Text.Trim
    End Sub

    Private Sub InitialState()
        Me.TabPage1.Controls.Remove(Me.Siz_cbx)
        Me.TabPage1.Controls.Remove(Me.Mat_cbx)
        Me.TabPage1.Controls.Remove(Me.Typ_cbx)
        Me.TabPage1.Controls.Remove(Me.Itm_cbx)
        Me.TabPage1.Controls.Remove(Me.Grp_cbx)
        Me.TabPage1.Controls.Add(Me.Siz_tbx)
        Me.TabPage1.Controls.Add(Me.Mat_tbx)
        Me.TabPage1.Controls.Add(Me.Typ_tbx)
        Me.TabPage1.Controls.Add(Me.Itm_tbx)
        Me.TabPage1.Controls.Add(Me.Grp_tbx)
        Me.CGrp_btn.Enabled = False
        Me.CItm_btn.Enabled = False
        Me.CTyp_btn.Enabled = False
        Me.CMat_btn.Enabled = False
        Me.CSiz_btn.Enabled = False
        Me.Browse_btn.Enabled = False
        Me.Import_ckbx.Enabled = False
        Code = ""
        Me.Grp_tbx.Text = ""
        Me.Itm_tbx.Text = ""
        Me.Typ_tbx.Text = ""
        Me.Mat_tbx.Text = ""
        Me.Siz_tbx.Text = ""
        Me.Code_tbx.Text = ""
        Me.Price_tbx.Text = ""
        Me.Nos_tbx.Text = ""
        Me.Desc_tbx.Text = ""
        Me.Ref_tbx.Text = ""
    End Sub

    Private Sub GenHtm()
        Using sw As StreamWriter = File.CreateText("/Print/Temp.htm")
            sw.WriteLine("<HTML>")
            sw.WriteLine("<Head>")
            sw.WriteLine("<Title>")
            sw.WriteLine("Billing Details" + Now)
            sw.WriteLine("</Title> </Head>")
            sw.WriteLine("<Body>")
            sw.WriteLine("<TABLE cellspacing=0 cellpadding=0 style='border-collapse:collapse;border-top:solid windowtext 1.0pt;border-bottom:solid windowtext 1.0pt;border-left:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'>")
            sw.WriteLine("<THead>")
            sw.WriteLine("<TR height = 30>")
            sw.WriteLine("<TH width = 25  style = 'border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>Sl. No.</span></TH>")
            sw.WriteLine("<TH width = 40  style = 'border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>P. Code</span></font></TH>")
            sw.WriteLine("<TH width = 150  style = 'border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>Description</span></font></TH>")
            sw.WriteLine("<TH width = 50  style = 'border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>Price/piece</span></font></TH>")
            sw.WriteLine("<TH width = 30  style = 'border-bottom:solid windowtext 1.0pt; border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>Quant.</span></font></TH>")
            sw.WriteLine("<TH width = 60  style = 'border-bottom:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>Line Price</span></font></TH>")
            sw.WriteLine("</TR>")
            sw.WriteLine("</THEAD>")
            sw.WriteLine("<TBody>")
            For i As Integer = 0 To Me.BDGV.Rows.Count - 1
                If i = Me.BDGV.Rows.Count - 1 Then
                    sw.WriteLine("<TR height = 25>")
                    sw.WriteLine("<TD width = 25 Align = center style = 'border-right:solid windowtext 1.0pt;border-top:solid windowtext 1.0pt'><span style ='font-size:6.0pt'></span></TD>")
                    sw.WriteLine("<TD width = 40 Align = center style = 'border-right:solid windowtext 1.0pt;border-top:solid windowtext 1.0pt'><span style ='font-size:6.0pt'></span></TD>")
                    sw.WriteLine("<TD width = 150 align = center style = 'border-right:solid windowtext 1.0pt;border-top:solid windowtext 1.0pt'><span style ='font-size:7.0pt;font:Bold'>Total</span></TD>")
                    sw.WriteLine("<TD width = 50 align = right style = 'border-right:solid windowtext 1.0pt;border-top:solid windowtext 1.0pt'><span style ='font-size:6.0pt'></span></TD>")
                    sw.WriteLine("<TD width = 30 align = center style = 'border-right:solid windowtext 1.0pt;border-top:solid windowtext 1.0pt'><span style ='font-size:6.0pt'></span></TD>")
                    sw.WriteLine("<TD width = 60 align = right style = 'border-top:solid windowtext 1.0pt'><span style ='font-size:7.0pt;font:Bold'>" & Me.Ttl_tbx.Text & "&nbsp</span></TD>")
                    sw.WriteLine("</TR>")
                ElseIf i < Me.BDGV.Rows.Count - 1 Then
                    sw.WriteLine("<TR height = 25>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(0)
                    sw.WriteLine("<TD width = 25 Align = center style = 'border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>" & Me.BDGV.CurrentCell.Value & "</span></TD>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(1)
                    sw.WriteLine("<TD width = 40 Align = center style = 'border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>&nbsp&nbsp" & Me.BDGV.CurrentCell.Value & "</span></TD>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(2)
                    sw.WriteLine("<TD width = 150 style = 'border-right:solid windowtext 1.0pt'><span style ='font-size:5.0pt'>&nbsp&nbsp" & Me.BDGV.CurrentCell.Value & "</span></TD>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(3)
                    sw.WriteLine("<TD width = 50 align = right style = 'border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>" & Me.BDGV.CurrentCell.Value & "&nbsp</span></TD>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(4)
                    sw.WriteLine("<TD width = 30 align = center style = 'border-right:solid windowtext 1.0pt'><span style ='font-size:6.0pt'>" & Me.BDGV.CurrentCell.Value & "</span></TD>")
                    Me.BDGV.CurrentCell = Me.BDGV.Rows.Item(i).Cells(5)
                    sw.WriteLine("<TD width = 60 align = right><span style ='font-size:7.0pt'>" & Me.BDGV.CurrentCell.Value & "&nbsp</span></TD>")
                    sw.WriteLine("</TR>")
                End If
            Next
            sw.WriteLine("</Tbody>")
            sw.WriteLine("</TABLE></Body></Html>")
            sw.Close()
        End Using
    End Sub

    Private Sub ExportBill()
        Me.Cursor = Cursors.WaitCursor
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oXL = New Excel.Application
        oWB = oXL.Workbooks.Add()
        oSheet = oWB.ActiveSheet

        Dim r As Integer
        Dim c As Integer

        For r = 0 To Me.BDGV.Rows.Count - 2
            For c = 0 To Me.BDGV.Rows(r).Cells.Count - 1
                Dim s As String = Me.BDGV.Rows(r).Cells(c).Value
                oSheet.Cells(r + 1, c + 1).Value = s
            Next
        Next

        Dim Result As DialogResult = Me.SaveFile_dbx.ShowDialog()
        If Result = System.Windows.Forms.DialogResult.OK Then
            Dim xlfile As String = Me.SaveFile_dbx.FileName
            oWB.SaveAs(xlfile)
        End If
        oXL.Visible = True
        oXL.UserControl = True
        oSheet = Nothing
        oWB = Nothing
        oXL = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ExportDtl()
        Me.Cursor = Cursors.WaitCursor
        Dim oXL As Excel.Application
        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oXL = New Excel.Application
        oWB = oXL.Workbooks.Add()
        oSheet = oWB.ActiveSheet

        Dim r As Integer
        Dim c As Integer

        For r = 0 To Me.DetailsDataGridView.Rows.Count - 1
            For c = 0 To Me.DetailsDataGridView.Rows(r).Cells.Count - 1
                Dim s As String = Me.DetailsDataGridView.Rows(r).Cells(c).Value
                oSheet.Cells(r + 1, c + 1).Value = s
            Next
        Next

        Dim Result As DialogResult = Me.SaveFile_dbx.ShowDialog()
        If Result = System.Windows.Forms.DialogResult.OK Then
            Dim xlfile As String = Me.SaveFile_dbx.FileName
            oWB.SaveAs(xlfile)
        End If
        oXL.Visible = True
        oXL.UserControl = True
        oSheet = Nothing
        oWB = Nothing
        oXL = Nothing
        Me.Cursor = Cursors.Default
    End Sub

    Public Sub AddBill()
        Dim Checked As Integer
        Checked = CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifItemDisc", 1))
        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        SplitContainer3 = New System.Windows.Forms.SplitContainer
        SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        SplitContainer3.IsSplitterFixed = True
        SplitContainer3.Location = New System.Drawing.Point(3, 3)
        SplitContainer3.Name = "SplitContainer3"
        SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        SplitContainer3.Size = New System.Drawing.Size(963, 371)
        SplitContainer3.SplitterDistance = 313
        SplitContainer3.SplitterWidth = 2

        Me.TabControl.TabPages.Add(Me.TabControl.TabPages.Count + 1, "New Billing List")
        Me.TabControl.TabPages(Me.TabControl.TabPages.Count - 1).Location = New System.Drawing.Point(4, 22)
        Me.TabControl.TabPages(Me.TabControl.TabPages.Count - 1).Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl.TabPages(Me.TabControl.TabPages.Count - 1).Size = New System.Drawing.Size(969, 377)
        Me.TabControl.TabPages(Me.TabControl.TabPages.Count - 1).UseVisualStyleBackColor = True

        If Me.TabControl.TabPages.Count > 1 Then
            Array.Resize(BDGVObj, CInt(Me.TabControl.TabPages.Count - 1))
            Array.Resize(SplitContObj, CInt(Me.TabControl.TabPages.Count - 1))
        End If

        BDGV = New System.Windows.Forms.DataGridView
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.BDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.BDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BDGV.ColumnHeadersHeight = 34
        Me.BDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Sl. No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70

        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column2.DataSource = Me.DetailsBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.DisplayMember = "Code"
        Me.Column2.DisplayStyleForCurrentCellOnly = True
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.ValueMember = "Code"

        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.DataSource = Me.DetailsBindingSource
        Me.Column3.DisplayMember = "Description"
        Me.Column3.DisplayStyleForCurrentCellOnly = True
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.ValueMember = "Description"

        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "Rate (" & Currency & ")"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 110

        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = "1"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70

        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.Discount.DefaultCellStyle = DataGridViewCellStyle10
        Me.Discount.HeaderText = "Disc. %"
        Me.Discount.Name = "Discount"
        Me.Discount.Width = 50


        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column6.HeaderText = "Amount (" & Currency & ")"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 110
        If Checked = 0 Then
            Me.BDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        ElseIf Checked = 1 Then
            Me.BDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Discount, Me.Column6})
        End If

        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BDGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.BDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.BDGV.Location = New System.Drawing.Point(0, 0)
        Me.BDGV.Name = "BillingDataGridView"
        Me.BDGV.RowHeadersWidth = 40
        Me.BDGV.Size = New System.Drawing.Size(963, 320)


        Me.TabControl.TabPages(Me.TabControl.TabPages.Count - 1).Controls.Add(SplitContainer3)
        SplitContainer3.Panel1.Controls.Add(BDGV)
        SplitContainer3.Panel2.Controls.Add(Me.TableLayoutPanel1)
        If Me.TabControl.TabPages.Count >= 2 Then
            BDGVObj(Me.TabControl.TabPages.Count - 2) = Me.BDGV
            SplitContObj(Me.TabControl.TabPages.Count - 2) = Me.SplitContainer3
            Me.TabControl.SelectTab(Me.TabControl.TabPages.Count - 1)
        End If
        Me.BDGV.ClearSelection()

    End Sub

    Private Sub AddItemtoBill()
        If Me.TabControl.TabCount = 2 Then
            Me.TabControl.SelectTab(1)
        End If
        Me.BDGV.Select()
        Me.BDGV.Rows.Add()
        Me.BDGV.CurrentCell = Me.BDGV.Rows(Me.BDGV.Rows.Count - 2).Cells(0)

        FillRow()

        Me.BDGV.CurrentCell = Me.BDGV.CurrentRow.Cells(4)

        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If

    End Sub

    Private Sub FillRow()
        Dim GetDetails As InventoryDataSet.DetailsRow
        GetDetails = MainInventoryDataSet.Details.FindByCode(Code)
        Me.BDGV.CurrentRow.Cells.Item(0).Value = (Me.BDGV.CurrentRow.Index + 1).ToString
        Me.BDGV.CurrentRow.Cells(1).Value = GetDetails.Code
        Me.BDGV.CurrentRow.Cells.Item(2).Value = GetDetails.Description
        Me.BDGV.CurrentRow.Cells.Item(3).Value = CDbl(GetDetails.Price).ToString("0.00")
        Me.BDGV.CurrentRow.Cells.Item(4).Value = 1
        If Me.BDGV.Columns.Count = 7 Then
            Me.BDGV.CurrentRow.Cells.Item(5).Value = 0
            Me.BDGV.CurrentRow.Cells.Item(6).Value = CDbl(GetDetails.Price).ToString("0.00")
        ElseIf Me.BDGV.Columns.Count = 6 Then
            Me.BDGV.CurrentRow.Cells.Item(5).Value = CDbl(GetDetails.Price).ToString("0.00")
        End If
        MakeTotal()
    End Sub

    Private Sub LinePrice()
        Try

            If Me.BDGV.Columns.Count = 7 Then
                If Me.BDGV.CurrentRow.Cells.Item(5).Value <> 0 Then
                    Me.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl((Me.BDGV.CurrentRow.Cells.Item(3).Value - Me.BDGV.CurrentRow.Cells.Item(5).Value / 100 * Me.BDGV.CurrentRow.Cells.Item(3).Value) * Me.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                ElseIf Me.BDGV.CurrentRow.Cells.Item(5).Value = 0 Then
                    Me.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl(Me.BDGV.CurrentRow.Cells.Item(3).Value * Me.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                End If
            ElseIf Me.BDGV.Columns.Count = 6 Then
                Me.BDGV.CurrentRow.Cells.Item(5).Value = CDbl(Me.BDGV.CurrentRow.Cells.Item(3).Value * Me.BDGV.CurrentRow.Cells.Item(4).Value).ToString("0.00")
            End If

        Catch ex As InvalidCastException

            If Me.BDGV.Columns.Count = 7 Then
                Me.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl(Me.BDGV.CurrentRow.Cells.Item(3).Value)).ToString("0.00")
            ElseIf Me.BDGV.Columns.Count = 6 Then
                Me.BDGV.CurrentRow.Cells.Item(5).Value = (CDbl(Me.BDGV.CurrentRow.Cells.Item(3).Value)).ToString("0.00")
            End If
            Me.BDGV.CurrentRow.Cells.Item(4).Value = "1"

        Catch ex As NullReferenceException
            Exit Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = "New Billing List" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Unsaved) "
        ElseIf Microsoft.VisualBasic.Right(Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text, 7) = "(Saved)" Then
            Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text = Me.TabControl.TabPages(Me.TabControl.SelectedIndex).Text + " (Modified)"
        End If

        MakeTotal()

    End Sub

    Private Sub UpdateBill(ByVal OriCode As String, ByVal NewCode As String)
        Dim updates As Integer = 0
        For k As Integer = 1 To Me.TabControl.TabCount - 1
            Me.BDGV = CType(BDGVObj(k - 1), DataGridView)
            If Me.BDGV.Rows.Count > 1 Then
                Dim nullproducts As Integer = 0
                Dim count As Integer = Me.BDGV.Rows.Count - 2
                For i As Integer = 0 To count
                    Dim j As Integer = i - nullproducts
                    Code = Me.BDGV.Rows(j).Cells(1).Value.ToString
                    If Code = OriCode Then
                        Dim GetDetails As InventoryDataSet.Details1Row
                        GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(NewCode)

                        If GetDetails Is Nothing Then
                            Dim index As Integer
                            Dim Desc As String = Me.BDGV.Rows(j).Cells(2).Value.ToString
                            index = Me.Details1BindingSource.Find("Description", Desc)
                            If index <> -1 Then
                                If Me.MainInventoryDataSet.Details1.Item(index).Price.ToString("0.00") <> Me.BDGV.Rows(j).Cells(3).Value.ToString Then
                                    index = -1
                                End If
                            End If
                            If index <> -1 Then
                                Me.BDGV.Rows(j).Cells(1).Value = Me.MainInventoryDataSet.Details1.Item(index).Code
                                updates += 1
                            ElseIf index = -1 Then
                                nullproducts += 1
                                Me.BDGV.Rows.RemoveAt(j)
                            End If

                        ElseIf GetDetails IsNot Nothing Then
                            Me.BDGV.Rows(j).Cells(1).Value = GetDetails.Code
                            Me.BDGV.Rows(j).Cells(2).Value = GetDetails.Description
                            Me.BDGV.Rows(j).Cells(3).Value = GetDetails.Price.ToString("0.00")
                            LinePrice()
                            updates += 1
                        End If
                    End If
                Next
                If nullproducts <> 0 Then
                    Me.TabControl.SelectTab(k)
                    MessageBox.Show(nullproducts.ToString + " Product(s) are not found in the list or they have been edited after adding to the billing list but the changes could not be tracked. These products have been removed from this billing list.", "Product not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            End If
        Next
        If updates <> 0 Then
            MessageBox.Show(updates.ToString + " instance(s) of this Product were found and updated in the Billing Lists.", "Product details updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub UpdateStock(ByVal OriCode As String)
        Dim Findinstock() As InventoryDataSet.StockDetailsRow
        Findinstock = Me.MainInventoryDataSet.StockDetails.Select("ProductCode ='" & OriCode & "'")
        If Findinstock.Length > 0 Then
            Dim SDetail As InventoryDataSet.StockDetailsRow
            For Each SDetail In Findinstock
                SDetail.BeginEdit()
                SDetail.ProductCode = Me.Code_tbx.Text.Trim
                SDetail.EndEdit()
                StockForm.StockDetailsTableAdapter.Update(SDetail)
            Next
        End If
    End Sub

    Private Sub UpdateSavedBills(ByVal OriCode As String)
        Dim FindinBills() As BillingDataSet.InvoiceRow
        FindinBills = Me.MainBillingDataSet.Invoice.Select("ProductCode ='" & OriCode & "'")
        If FindinBills.Length > 0 Then
            Dim InvoiceItem As BillingDataSet.InvoiceRow
            For Each InvoiceItem In FindinBills
                InvoiceItem.BeginEdit()
                InvoiceItem.ProductCode = Me.Code_tbx.Text.Trim
                InvoiceItem.Description = Me.Desc_tbx.Text
                InvoiceItem.EndEdit()
                Me.InvoiceTableAdapter.Update(InvoiceItem)
            Next
        End If
    End Sub

    Private Sub GetBillNo()
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
            If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                Me.BillNo_tbx.Tag = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "")).ToString
                If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifPrePrefix", 1)) = 1 Then
                    Dim Prefix As String = ""
                    If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", 1)) = 1 Then
                        Prefix = Date.Today.Day.ToString("00") + Date.Today.Month.ToString("00")
                    ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Nothing)) = 2 Then
                        Prefix = Date.Today.Month.ToString("00") + Date.Today.Day.ToString("00")
                    ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Nothing)) = 3 Then
                        Prefix = Date.Today.Day.ToString("00") + Date.Today.Month.ToString("00") + Microsoft.VisualBasic.Right(Date.Today.Year.ToString, 2)
                    ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Nothing)) = 4 Then
                        Prefix = Date.Today.Month.ToString("00") + Date.Today.Day.ToString("00") + Microsoft.VisualBasic.Right(Date.Today.Year.ToString, 2)
                    ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Nothing)) = 5 Then
                        Prefix = Microsoft.VisualBasic.Right(Date.Today.Year.ToString, 2) + Date.Today.Day.ToString("00") + Date.Today.Month.ToString("00")
                    ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PPrefix", Nothing)) = 6 Then
                        Prefix = Microsoft.VisualBasic.Right(Date.Today.Year.ToString, 2) + Date.Today.Month.ToString("00") + Date.Today.Day.ToString("00")
                    End If
                    Prefix = Prefix + (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "OPrefix", "")).ToString
                    Me.BillNo_tbx.Tag = Prefix + (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "")).ToString
                End If
            End If
        End If
    End Sub

#End Region

End Class