Public Class HistoryForm

    Dim Edit As Boolean = False

    Private Sub HistoryForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Edit = False Then
            MainForm.Visible = True
            MainForm.Enabled = True
        End If
    End Sub

    Private Sub HistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainBillingDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.MainBillingDataSet.Invoice)
        'TODO: This line of code loads data into the 'MainBillingDataSet.ShortBill' table. You can move, or remove it, as needed.
        Me.ShortBillTableAdapter.Fill(Me.MainBillingDataSet.ShortBill)
        'TODO: This line of code loads data into the 'MainInventoryDataSet.Details1' table. You can move, or remove it, as needed.
        Me.Details1TableAdapter.Fill(Me.MainInventoryDataSet.Details1)
        'TODO: This line of code loads data into the 'BillingDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.MainBillingDataSet.Invoice)
        'TODO: This line of code loads data into the 'BillingDataSet.ShortBill' table. You can move, or remove it, as needed.
        Me.ShortBillTableAdapter.Fill(Me.MainBillingDataSet.ShortBill)
        If Me.ShortBillBindingSource.Count > 0 Then
            Me.ShortBillDataGridView.CurrentCell = Me.ShortBillDataGridView.Rows(0).Cells(0)
            FillBill()
        End If

        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total Price (" & Currency & ")"
        Me.ReceivedDataGridViewTextBoxColumn.HeaderText = "Received (" & Currency & ")"
        Me.ReturnedDataGridViewTextBoxColumn.HeaderText = "Returned (" & Currency & ")"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Rate (" & Currency & ")"
        Me.Column6.HeaderText = "Amount (" & Currency & ")"

        Me.Ttl_lbl.Text = "Bill Total " & Currency
        Me.Pay_lbl.Text = "Amt. Payable " & Currency
        Me.Per_lbl.Text = "%    or    " & Currency
        Me.Receive_lbl.Text = "Received " & Currency
        Me.Balance_lbl.Text = "Balance " & Currency
    End Sub

    Private Sub Date_ckx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_ckx.CheckedChanged
        If Me.Date_ckx.Checked = True Then
            Me.Thisday_lbl.Text = Now.Date.ToString("dd/MM/yyyy")
            Me.Thisday_lbl.Tag = Now.ToShortTimeString
        ElseIf Me.Date_ckx.Checked = False Then
            Me.Thisday_lbl.Text = Me.ShortBillDataGridView.CurrentRow.Cells(4).Value
            Me.Thisday_lbl.Tag = Me.ShortBillDataGridView.CurrentRow.Cells(5).Value
        End If
    End Sub

    Private Sub Prv_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prv_btn.Click
        PreviewForm.SavPrnt_btn.Enabled = False
        PreviewForm.Sav_btn.Enabled = False
        PreviewForm.Tag = "H"
        PreviewForm.ShowDialog()
    End Sub

    Private Sub ShortBillDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortBillDataGridView.Click, ShortBillDataGridView.SelectionChanged
        Me.Date_ckx.Checked = False
        FillBill()
    End Sub

    Private Sub Edit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_btn.Click
        If Me.BillingDataGridView.RowCount > 0 Then
            'BillingForm.BindingNavigatorDeleteItem.Enabled = False
            'BillingForm.BindingNavigatorEditItem.Enabled = False
            'BillingForm.Edit_itm.Enabled = False
            'BillingForm.Del_Itm.Enabled = False
            'BillingForm.NewToolStripMenuItem.Enabled = False
            'BillingForm.ClearBillToolStripMenuItem.Enabled = False
            'BillingForm.CloseToolStripMenuItem.Enabled = False
            'BillingForm.TabControl.Controls.Remove(BillingForm.TabPage1)
            Edit = True
            BillingForm.Visible = False
            BillingForm.Show()
            'BillingForm.TabControl.TabPages(0).Text = "Billing List"
            Dim ThisShortBill As BillingDataSet.ShortBillRow
            ThisShortBill = Me.MainBillingDataSet.ShortBill.FindByBillNo(Me.ShortBillDataGridView.CurrentRow.Cells(0).Value.ToString)
            Dim ThisInvoiceRows() As BillingDataSet.InvoiceRow
            ThisInvoiceRows = Me.MainBillingDataSet.Invoice.Select("BillNo =" & Me.ShortBillDataGridView.CurrentRow.Cells(0).Value)
            Dim ThisInvoiceRow As BillingDataSet.InvoiceRow
            If ThisShortBill.PerItemDisc = False And BillingForm.BDGV.ColumnCount = 7 Then
                BillingForm.BDGV.Columns.Remove("Discount")
            ElseIf ThisShortBill.PerItemDisc = True And BillingForm.BDGV.ColumnCount = 6 Then
                BillingForm.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn
                BillingForm.Discount.HeaderText = "Disc. %"
                BillingForm.Discount.Name = "Discount"
                BillingForm.Discount.Width = 50
                BillingForm.BDGV.Columns.Insert(5, BillingForm.Discount)
            End If
            For Each ThisInvoiceRow In ThisInvoiceRows
                BillingForm.BDGV.Rows.Add()
                BillingForm.BDGV.CurrentCell = BillingForm.BDGV.Rows(BillingForm.BDGV.Rows.Count - 2).Cells(0)
                Dim RefNo As String = Microsoft.VisualBasic.Mid(ThisInvoiceRow.RefNo, ThisInvoiceRow.BillNo.Length + 1)
                BillingForm.BDGV.CurrentRow.Cells.Item(0).Value = CInt(RefNo)
                BillingForm.BDGV.CurrentRow.Cells.Item(1).Value = ThisInvoiceRow.ProductCode
                BillingForm.BDGV.CurrentRow.Cells.Item(2).Value = ThisInvoiceRow.Description
                BillingForm.BDGV.CurrentRow.Cells.Item(3).Value = CDbl(ThisInvoiceRow.Price).ToString("0.00")
                BillingForm.BDGV.CurrentRow.Cells.Item(4).Value = ThisInvoiceRow.Quantity
                If ThisShortBill.PerItemDisc = True Then
                    BillingForm.BDGV.CurrentRow.Cells.Item(5).Value = CDbl(ThisInvoiceRow.Discount)
                    If BillingForm.BDGV.CurrentRow.Cells.Item(5).Value <> 0 Then
                        BillingForm.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl((BillingForm.BDGV.CurrentRow.Cells.Item(3).Value - BillingForm.BDGV.CurrentRow.Cells.Item(5).Value / 100 * BillingForm.BDGV.CurrentRow.Cells.Item(3).Value) * BillingForm.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    ElseIf BillingForm.BDGV.CurrentRow.Cells.Item(5).Value = 0 Then
                        BillingForm.BDGV.CurrentRow.Cells.Item(6).Value = (CDbl(BillingForm.BDGV.CurrentRow.Cells.Item(3).Value * BillingForm.BDGV.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    End If
                ElseIf ThisShortBill.PerItemDisc = False Then
                    BillingForm.BDGV.CurrentRow.Cells.Item(5).Value = CDbl(BillingForm.BDGV.CurrentRow.Cells.Item(3).Value * BillingForm.BDGV.CurrentRow.Cells.Item(4).Value).ToString("0.00")
                End If
            Next
            BillingForm.BDGV.Sort(BillingForm.Column1, System.ComponentModel.ListSortDirection.Ascending)
            BillingForm.BillNo_tbx.Text = Me.BillNo_tbx.Text
            'BillingForm.BillNo_tbx.Tag = Me.BillNo_tbx.Text
            If Me.Date_ckx.Checked = True Then
                BillingForm.TabControl.TabPages(1).Text = Me.BillNo_tbx.Text + " (Saved) (Modified)"
            ElseIf Me.Date_ckx.Checked = False Then
                BillingForm.TabControl.TabPages(1).Text = Me.BillNo_tbx.Text + " (Saved)"
                BillingForm.TabControl.Tag = "History"
            End If
            BillingForm.TabControl.TabPages(1).Tag = Me.BillNo_tbx.Text
            BillingForm.Ttl_tbx.Text = Me.Ttl_tbx.Text
            BillingForm.RAmt_tbx.Text = CDbl(Me.ShortBillDataGridView.CurrentRow.Cells(2).Value).ToString("0.00")
            BillingForm.BAmt_tbx.Text = CDbl(Me.ShortBillDataGridView.CurrentRow.Cells(3).Value).ToString("0.00")
            If ThisShortBill.DiscOnTotal = Nothing Then
                BillingForm.DiscPer_tbx.Text = "0"
                BillingForm.DiscAmt_tbx.Text = "0"
            ElseIf Microsoft.VisualBasic.Left(ThisShortBill.DiscOnTotal.ToString, 1) = "%" Then
                BillingForm.DiscPer_tbx.Text = Microsoft.VisualBasic.Mid(ThisShortBill.DiscOnTotal.ToString, 2)
                BillingForm.DiscAmt_tbx.Text = (CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.Ttl_tbx.Text))).ToString("0.00")
            ElseIf Microsoft.VisualBasic.Left(ThisShortBill.DiscOnTotal.ToString, 1) <> "%" Then
                BillingForm.DiscAmt_tbx.Text = ThisShortBill.DiscOnTotal.ToString
            End If
            BillingForm.Thisday_lbl.Text = Me.Thisday_lbl.Text
            BillingForm.Thisday_lbl.Tag = Me.Thisday_lbl.Tag
            BillingForm.Pay_tbx.Text = Me.Pay_tbx.Text
            BillingForm.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub SrchBill_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SrchBill_btn.Click
        If Me.SrchBill_tbx.Text = "" Then
            MessageBox.Show("Enter the Bill No. to search", "Bill No!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Me.SrchBill_tbx.Text <> "" Then
            Me.ShortBillDataGridView.DataSource = Me.ShortBillBindingSource
            Me.ShowAll_btn.Enabled = False
            Dim Index As Integer = Me.ShortBillBindingSource.Find("BillNo", Me.SrchBill_tbx.Text.Trim)
            If Index = -1 Then
                MessageBox.Show("No such Bill exists, please check the Bill No. you entered.", "Bill Does Not Exist?", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Index <> -1 Then
                Me.ShortBillDataGridView.CurrentCell = Me.ShortBillDataGridView.Rows(Index).Cells(0)
                FillBill()
            End If
        End If

    End Sub

    Private Sub FiltBill_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltBill_btn.Click
        Dim FiltDate As String = "ThisDate ='" & Microsoft.VisualBasic.Left(Me.FiltBill_dtp.Text, 10) & "'"
        Dim Dv As DataView = New DataView(Me.MainBillingDataSet.ShortBill, FiltDate, "BillNo", DataViewRowState.CurrentRows)
        Me.ShortBillDataGridView.DataSource = Dv.ToTable.DefaultView
        Me.ShowAll_btn.Enabled = True
    End Sub

    Private Sub DelBill_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBill_btn.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("Do you wish to Delete the Bill " & Me.DelBill_cbx.SelectedValue & " ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            Dim DelInvoice() As BillingDataSet.InvoiceRow
            DelInvoice = Me.MainBillingDataSet.Invoice.Select("BillNo =" & Me.DelBill_cbx.SelectedValue)
            If DelInvoice.Length > 0 Then
                Dim InvoiceItem As BillingDataSet.InvoiceRow
                For Each InvoiceItem In DelInvoice
                    Dim GetDetails As InventoryDataSet.Details1Row
                    GetDetails = Me.MainInventoryDataSet.Details1.FindByCode(InvoiceItem.ProductCode)
                    GetDetails.BeginEdit()
                    GetDetails.Available_Nos += InvoiceItem.Quantity
                    GetDetails.EndEdit()
                    Try
                        Me.Details1TableAdapter.Update(GetDetails)
                        GetDetails = Nothing
                    Catch ex As Exception
                        Exit Try
                    End Try
                    InvoiceItem.Delete()
                Next
                Me.InvoiceTableAdapter.Update(Me.MainBillingDataSet)
                InvoiceItem = Nothing
            End If
            DelInvoice = Nothing
            Try
                Dim DelBill As BillingDataSet.ShortBillRow
                DelBill = Me.MainBillingDataSet.ShortBill.FindByBillNo(Me.DelBill_cbx.SelectedValue)
                DelBill.Delete()
                Me.ShortBillTableAdapter.Update(Me.MainBillingDataSet.ShortBill)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ShowAll_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAll_btn.Click
        Me.ShortBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShortBillBindingSource.DataSource = Me.MainBillingDataSet
        Me.ShortBillBindingSource.DataMember = "ShortBill"
        Me.ShortBillDataGridView.DataSource = Me.ShortBillBindingSource
        Me.ShowAll_btn.Enabled = False
    End Sub

    Private Sub DelBill_cbx_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBill_cbx.SelectedValueChanged
        If Me.DelBill_cbx.SelectedValue <> Nothing Then
            Me.DelBill_btn.Enabled = True
        ElseIf Me.DelBill_cbx.SelectedValue = Nothing Then
            Me.DelBill_btn.Enabled = False
        End If
    End Sub

    Private Sub FiltPcode_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltPcode_btn.Click

        Dim FindBillNos() As BillingDataSet.InvoiceRow
        FindBillNos = Me.MainBillingDataSet.Invoice.Select("ProductCode ='" & Me.FiltPCode_cbx.SelectedValue & "'")
        Dim FindBillNo As BillingDataSet.InvoiceRow
        Me.ShortBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        For Each FindBillNo In FindBillNos
            Me.ShortBillBindingSource.Add(Me.MainBillingDataSet.ShortBill.FindByBillNo(FindBillNo.BillNo))
        Next
        Me.ShortBillDataGridView.DataSource = Me.ShortBillBindingSource
        Me.ShowAll_btn.Enabled = True
    End Sub

#Region "Methods"
    Public Sub FillBill()
        If Me.ShortBillDataGridView.ColumnCount > 0 And Me.ShortBillDataGridView.RowCount > 0 Then
            Me.BillingDataGridView.AllowUserToAddRows = True
            Me.BillingDataGridView.Rows.Clear()
            Dim ThisShortBill As BillingDataSet.ShortBillRow
            ThisShortBill = Me.MainBillingDataSet.ShortBill.FindByBillNo(Me.ShortBillDataGridView.CurrentRow.Cells(0).Value.ToString)
            If ThisShortBill.PerItemDisc = True Then
                If Me.BillingDataGridView.ColumnCount = 6 Then
                    Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn
                    Me.Discount.HeaderText = "Disc. %"
                    Me.Discount.Name = "Discount"
                    Me.Discount.Width = 50
                    Me.BillingDataGridView.Columns.Insert(5, Me.Discount)
                End If
            ElseIf ThisShortBill.PerItemDisc = False And Me.BillingDataGridView.ColumnCount = 7 Then
                Me.BillingDataGridView.Columns.Remove("Discount")
            End If
            Dim ThisInvoiceRows() As BillingDataSet.InvoiceRow
            ThisInvoiceRows = Me.MainBillingDataSet.Invoice.Select("BillNo =" & Me.ShortBillDataGridView.CurrentRow.Cells(0).Value)
            Dim ThisInvoiceRow As BillingDataSet.InvoiceRow
            For Each ThisInvoiceRow In ThisInvoiceRows
                Me.BillingDataGridView.Rows.Add()
                Me.BillingDataGridView.CurrentCell = Me.BillingDataGridView.Rows(Me.BillingDataGridView.Rows.Count - 2).Cells(0)
                Dim RefNo As String = Microsoft.VisualBasic.Mid(ThisInvoiceRow.RefNo, ThisInvoiceRow.BillNo.Length + 1)
                If RefNo <> "" Then
                    Me.BillingDataGridView.CurrentRow.Cells.Item(0).Value = CInt(RefNo)
                End If
                Me.BillingDataGridView.CurrentRow.Cells.Item(1).Value = ThisInvoiceRow.ProductCode
                Me.BillingDataGridView.CurrentRow.Cells.Item(2).Value = ThisInvoiceRow.Description
                Me.BillingDataGridView.CurrentRow.Cells.Item(3).Value = CDbl(ThisInvoiceRow.Price).ToString("0.00")
                Me.BillingDataGridView.CurrentRow.Cells.Item(4).Value = ThisInvoiceRow.Quantity
                If ThisShortBill.PerItemDisc = True Then
                    Me.BillingDataGridView.CurrentRow.Cells.Item(5).Value = CDbl(ThisInvoiceRow.Discount)
                    If Me.BillingDataGridView.CurrentRow.Cells.Item(5).Value <> 0 Then
                        Me.BillingDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl((Me.BillingDataGridView.CurrentRow.Cells.Item(3).Value - Me.BillingDataGridView.CurrentRow.Cells.Item(5).Value / 100 * Me.BillingDataGridView.CurrentRow.Cells.Item(3).Value) * Me.BillingDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    ElseIf Me.BillingDataGridView.CurrentRow.Cells.Item(5).Value = 0 Then
                        Me.BillingDataGridView.CurrentRow.Cells.Item(6).Value = (CDbl(Me.BillingDataGridView.CurrentRow.Cells.Item(3).Value * Me.BillingDataGridView.CurrentRow.Cells.Item(4).Value)).ToString("0.00")
                    End If
                ElseIf ThisShortBill.PerItemDisc = False Then
                    Me.BillingDataGridView.CurrentRow.Cells.Item(5).Value = CDbl(Me.BillingDataGridView.CurrentRow.Cells.Item(3).Value * Me.BillingDataGridView.CurrentRow.Cells.Item(4).Value).ToString("0.00")
                End If
            Next
            Me.BillingDataGridView.AllowUserToAddRows = False
            Me.BillNo_tbx.Text = Me.ShortBillDataGridView.CurrentRow.Cells(0).Value
            Me.Ttl_tbx.Text = CDbl(Me.ShortBillDataGridView.CurrentRow.Cells(1).Value).ToString("0.00")
            Me.RAmt_tbx.Text = CDbl(Me.ShortBillDataGridView.CurrentRow.Cells(2).Value).ToString("0.00")
            Me.BAmt_tbx.Text = CDbl(Me.ShortBillDataGridView.CurrentRow.Cells(3).Value).ToString("0.00")
            If ThisShortBill.DiscOnTotal = Nothing Then
                Me.DiscPer_tbx.Text = "0"
                Me.DiscAmt_tbx.Text = "0"
            ElseIf Microsoft.VisualBasic.Left(ThisShortBill.DiscOnTotal.ToString, 1) = "%" Then
                Me.DiscPer_tbx.Text = Microsoft.VisualBasic.Mid(ThisShortBill.DiscOnTotal.ToString, 2)
                Me.DiscAmt_tbx.Text = (CDbl(CDbl(Me.DiscPer_tbx.Text) / 100 * CDbl(Me.Ttl_tbx.Text))).ToString("0.00")
            ElseIf Microsoft.VisualBasic.Left(ThisShortBill.DiscOnTotal.ToString, 1) <> "%" Then
                Me.DiscPer_tbx.Text = ""
                Me.DiscAmt_tbx.Text = ThisShortBill.DiscOnTotal.ToString
            End If
            Me.Pay_tbx.Text = (CDbl(Me.Ttl_tbx.Text) - CDbl(Me.DiscAmt_tbx.Text)).ToString("0.00")
            Me.Thisday_lbl.Text = Me.ShortBillDataGridView.CurrentRow.Cells(4).Value
            Me.Thisday_lbl.Tag = Me.ShortBillDataGridView.CurrentRow.Cells(5).Value
        End If
        Me.BillingDataGridView.Sort(Me.RefNoDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)
    End Sub
#End Region

    Private Sub ColPanel1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColPanel1_btn.Click
        If Me.ColPanel1_btn.Tag = "-" Then
            Me.SplitContainer6.Panel2Collapsed = True
            Me.SplitContainer5.SplitterDistance = 25
            Me.SplitContainer5.Height -= 200
            If Me.SplitContainer8.Panel2Collapsed = True Then
                Me.SplitContainer7.SplitterDistance = 25
            Else
                Me.SplitContainer7.SplitterDistance = 200
            End If
            Me.ColPanel1_btn.Image = Global.Shopkeeper_Inventory.My.Resources.Resources.expand_all_2_
            Me.ColPanel1_btn.Tag = "+"
        ElseIf Me.ColPanel1_btn.Tag = "+" Then
            Me.SplitContainer6.Panel2Collapsed = False
            Me.SplitContainer5.Height += 200
            Me.SplitContainer5.SplitterDistance = 200
            If Me.SplitContainer8.Panel2Collapsed = True Then
                Me.SplitContainer7.SplitterDistance = 25
            Else
                Me.SplitContainer7.SplitterDistance = 200
            End If
            Me.ColPanel1_btn.Image = Global.Shopkeeper_Inventory.My.Resources.Resources.collapse_all_2_
            Me.ColPanel1_btn.Tag = "-"
        End If

    End Sub

    Private Sub ColPanel2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColPanel2_btn.Click
        If Me.ColPanel2_btn.Tag = "-" Then
            Me.SplitContainer8.Panel2Collapsed = True
            Me.SplitContainer7.SplitterDistance = 25
            Me.SplitContainer5.Height -= 200
            If Me.SplitContainer6.Panel2Collapsed = False Then
                Me.SplitContainer5.SplitterDistance = 200
            Else
                Me.SplitContainer5.SplitterDistance = 25
            End If
            Me.ColPanel2_btn.Image = Global.Shopkeeper_Inventory.My.Resources.Resources.expand_all_2_
            Me.ColPanel2_btn.Tag = "+"
        ElseIf Me.ColPanel2_btn.Tag = "+" Then
            Me.SplitContainer8.Panel2Collapsed = False
            Me.SplitContainer5.Height += 200
            Me.SplitContainer7.SplitterDistance = 200
            If Me.SplitContainer6.Panel2Collapsed = False Then
                Me.SplitContainer5.SplitterDistance = 200
            Else
                Me.SplitContainer5.SplitterDistance = 25
            End If
            Me.ColPanel2_btn.Image = Global.Shopkeeper_Inventory.My.Resources.Resources.collapse_all_2_
            Me.ColPanel2_btn.Tag = "-"
        End If
    End Sub
End Class