Imports System.IO
Imports System.Drawing.Printing
Imports System.Drawing
Imports NumtoWord

Public Class PreviewForm
    Private HeadFont As New Font(System.Drawing.FontFamily.GenericSerif, 10)
    Private FootFont As New Font(System.Drawing.FontFamily.GenericSansSerif, 9)
    Private BodyFont As New Font(System.Drawing.FontFamily.GenericSansSerif, 7)
    Private HeadCellFont As New Font(System.Drawing.FontFamily.GenericSerif, 8)
    Private HeadRect As Rectangle
    Private FootRect As Rectangle
    Private BodyRect As Rectangle
    Private Textlayout As StringFormat
    Dim RowHeight As Integer
    Dim rowsprinted As Integer = 0
    Dim pagesprinted As Integer = 0
    Dim Noofpages As Integer
    Dim Noofrows As Integer
    Dim DGV As DataGridView
    Dim BillNo As String
    Dim ThisDate As String
    Dim ThisTime As String
    Dim BillAmt As String
    Dim restart As Boolean = False
    Dim LSpace As Integer


    Private Sub Billing_pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Billing_pd.PrintPage

        If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Spacing", 1)) = 0 Then
            LSpace = 12
        ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Spacing", 1)) = 1 Then
            LSpace = 20
        ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Spacing", 1)) = 2 Then
            LSpace = 30
        End If

        If e.MarginBounds.Width < 400 Then
            HeadFont = New Font(System.Drawing.FontFamily.GenericSerif, 7)
            FootFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 7)
            BodyFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 5)
            HeadCellFont = New Font(System.Drawing.FontFamily.GenericSerif, 6)
        End If

        'Specify bounds
        If e.MarginBounds.Height <= 0 Or e.MarginBounds.Width <= 0 Then
            Me.PageSetupDialog.ShowDialog()
            rowsprinted = 0
            pagesprinted = 0
            Me.Billing_ppc.InvalidatePreview()
        End If

        If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PaperS", 1)) = 0 Then

            RowsandPages(e)

            DrawPage(e)

            PrintHeader(e)

            DrawCHeader(e)

            PrintRows(Noofrows, e)

        ElseIf CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "PaperS", 1)) = 1 Then

            RowsandPages(e)

            DrawPage(e)

            PrintHeader(e)

            DrawCHeader(e)

            PrintRows(Noofrows, e)

        End If

    End Sub

    Private Sub PreviewForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Zoom_cbx.SelectedIndex = 19
        rowsprinted = 0
        pagesprinted = 0
        If BillingForm.TabControl.SelectedIndex > 1 Then
            BillingForm.Thisday_lbl.Text = Now.Date.ToString("dd/MM/yyyy")
            BillingForm.Thisday_lbl.Tag = Now.ToShortTimeString
        ElseIf BillingForm.TabControl.SelectedIndex = 1 And BillingForm.TabControl.Tag = "" Then
            BillingForm.Thisday_lbl.Text = Now.Date.ToString("dd/MM/yyyy")
            BillingForm.Thisday_lbl.Tag = Now.ToShortTimeString
        End If
        Me.Billing_ppc.InvalidatePreview()
        Dim state As String = Microsoft.VisualBasic.Right(BillingForm.TabControl.TabPages(BillingForm.TabControl.SelectedIndex).Text, 10)
        If state = "(Unsaved) " Or state = "(Modified)" Then
            Me.Sav_btn.Enabled = True
            Me.SavPrnt_btn.Enabled = True
        End If
        

        If Me.Tag = "B" Then
            DGV = New DataGridView
            For Each Column As DataGridViewColumn In BillingForm.BDGV.Columns
                Dim NewCol As DataGridViewColumn = Column.Clone()
                Me.DGV.Columns.Add(NewCol)
            Next
            Me.DGV.AllowUserToAddRows = True
            For Each Row As DataGridViewRow In BillingForm.BDGV.Rows
                Dim NewRow As DataGridViewRow = Row.Clone()
                For i As Integer = 0 To Row.Cells.Count - 1
                    NewRow.Cells(i).Value = Row.Cells(i).Value
                Next
                Me.DGV.Rows.Add(NewRow)
            Next
            Me.DGV.AllowUserToAddRows = False

            Dim Index As Integer = Me.DGV.Rows.GetLastRow(DataGridViewElementStates.None)
            Me.DGV.Rows.RemoveAt(Index)

            BillNo = BillingForm.BillNo_tbx.Text
            ThisDate = BillingForm.Thisday_lbl.Text
            ThisTime = BillingForm.Thisday_lbl.Tag
            BillAmt = BillingForm.Ttl_tbx.Text
        ElseIf Me.Tag = "H" Then
            DGV = New DataGridView
            For Each Column As DataGridViewColumn In HistoryForm.BillingDataGridView.Columns
                Dim NewCol As DataGridViewColumn = Column.Clone()
                Me.DGV.Columns.Add(NewCol)
            Next
            Me.DGV.AllowUserToAddRows = True
            For Each Row As DataGridViewRow In HistoryForm.BillingDataGridView.Rows
                Dim NewRow As DataGridViewRow = Row.Clone()
                For i As Integer = 0 To Row.Cells.Count - 1
                    NewRow.Cells(i).Value = Row.Cells(i).Value
                Next
                Me.DGV.Rows.Add(NewRow)
            Next
            Me.DGV.AllowUserToAddRows = False

            BillNo = HistoryForm.BillNo_tbx.Text
            ThisDate = HistoryForm.Thisday_lbl.Text
            ThisTime = HistoryForm.Thisday_lbl.Tag
            BillAmt = HistoryForm.Ttl_tbx.Text

        End If

    End Sub

    Private Sub PageSet_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSet_btn.Click
        'Me.PageSetupDialog.Document = Me.Billing_pd
        Me.PageSetupDialog.ShowDialog()
        rowsprinted = 0
        pagesprinted = 0
        Me.Billing_ppc.InvalidatePreview()
        'Dim result As DialogResult = Me.PageSetupDialog.ShowDialog()
        'If result = System.Windows.Forms.DialogResult.OK Then
        '    Me.Billing_pd.DefaultPageSettings = Me.PageSetupDialog.PageSettings
        'End If

    End Sub

    Private Sub Sav_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sav_btn.Click
        Dim Index As Integer = BillingForm.ShortBillBindingSource.Find("BillNo", BillingForm.BillNo_tbx.Text)
        If Index <> -1 Then
            GetBillNo()
            If BillingForm.BillNo_tbx.Text = BillingForm.BillNo_tbx.Tag Then
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                    If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                        SetBillNo()
                    End If
                End If
                GetBillNo()
            End If
            Dim result As DialogResult
            result = MessageBox.Show("Bill No. " & BillingForm.BillNo_tbx.Text & " already exits. Do you want to save this as a new Bill? If Yes the bill will be saved separately with the Bill No." & BillingForm.BillNo_tbx.Tag & " else the Bill will be overwritten.", "Bill Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If result = System.Windows.Forms.DialogResult.Yes Then
                SaveShortBill()
                SaveInvoice()
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                    If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                        SetBillNo()
                    End If
                End If
                GetBillNo()
            ElseIf result = System.Windows.Forms.DialogResult.No Then
                EditBill()
            ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        ElseIf Index = -1 Then
            Dim SetNo As Boolean = True
            If BillingForm.BillNo_tbx.Text <> BillingForm.BillNo_tbx.Tag Then
                BillingForm.BillNo_tbx.Tag = BillingForm.BillNo_tbx.Text
                SetNo = False
            End If
            SaveShortBill()
            SaveInvoice()
            If SetNo = True Then
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                    If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                        SetBillNo()
                    End If
                End If
            End If
            GetBillNo()
        End If
        BillNo = BillingForm.BillNo_tbx.Text
        ThisDate = BillingForm.Thisday_lbl.Text
        ThisTime = BillingForm.Thisday_lbl.Tag
        BillAmt = BillingForm.Ttl_tbx.Text
        Me.Billing_ppc.InvalidatePreview()
        Me.Sav_btn.Enabled = False
        Me.SavPrnt_btn.Enabled = False
    End Sub

    Private Sub SavPrnt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavPrnt_btn.Click
        Dim Index As Integer = BillingForm.ShortBillBindingSource.Find("BillNo", BillingForm.BillNo_tbx.Text)
        If Index <> -1 Then
            GetBillNo()
            Dim result As DialogResult
            result = MessageBox.Show("Bill No. " & BillingForm.BillNo_tbx.Text & " already exits. Do you want to save this as a new Bill? If Yes the bill will be saved separately with the Bill No." & BillingForm.BillNo_tbx.Tag & " else the Bill will be overwritten.", "Bill Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If result = System.Windows.Forms.DialogResult.Yes Then
                SaveShortBill()
                SaveInvoice()
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                    If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                        SetBillNo()
                    End If
                End If
                GetBillNo()
            ElseIf result = System.Windows.Forms.DialogResult.No Then
                EditBill()
            ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        ElseIf Index = -1 Then
            SaveShortBill()
            SaveInvoice()
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                    SetBillNo()
                End If
            End If
            GetBillNo()
        End If
        BillNo = BillingForm.BillNo_tbx.Text
        ThisDate = BillingForm.Thisday_lbl.Text
        ThisTime = BillingForm.Thisday_lbl.Tag
        BillAmt = BillingForm.Ttl_tbx.Text
        Me.Billing_ppc.InvalidatePreview()
        Me.Sav_btn.Enabled = False
        Me.SavPrnt_btn.Enabled = False
        Me.Billing_pd.Print()
    End Sub

    Private Sub Prnt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prnt_btn.Click
        If Me.Tag = "H" Then
            If HistoryForm.Date_ckx.Checked = True Then
                Dim result As DialogResult
                result = MessageBox.Show("Would you like to save the change in date to the Bill History?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Dim BillSummary As BillingDataSet.ShortBillRow
                    BillSummary = BillingForm.MainBillingDataSet.ShortBill.FindByBillNo(HistoryForm.BillNo_tbx.Text)
                    BillSummary.BeginEdit()
                    BillSummary.ThisDate = HistoryForm.Thisday_lbl.Text
                    BillSummary.ThisTime = HistoryForm.Thisday_lbl.Tag
                    BillSummary.EndEdit()
                    Try
                        BillingForm.ShortBillTableAdapter.Update(BillSummary)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                    BillSummary = Nothing
                End If
            End If
            Me.Billing_pd.Print()
        ElseIf Me.Tag = "B" Then
            If Me.Sav_btn.Enabled = True Then
                Dim result As DialogResult
                result = MessageBox.Show("You have not saved this bill. Do you intend to Print it without saving?", "Bill not saved!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                If result = System.Windows.Forms.DialogResult.Yes Then
                    Me.Billing_pd.Print()
                End If
            ElseIf Me.Sav_btn.Enabled = False Then
                Me.Billing_pd.Print()
            End If
        End If
    End Sub

    Private Sub Zoom_cbx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom_cbx.SelectedIndexChanged
        If Me.Zoom_cbx.SelectedIndex >= 0 Then
            Me.Billing_ppc.Zoom = CDbl(Me.Zoom_cbx.Text) / 100
        End If
    End Sub

    Private Sub Billing_ppc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Billing_ppc.Click
        Me.Billing_ppc.Focus()
    End Sub

#Region "Methods"

    Private Sub RowsandPages(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim remain As Integer
        Dim rowsperpage As Integer = Math.DivRem(e.MarginBounds.Height - 185, LSpace, remain)
        If remain < 26 And e.PageSettings.Landscape = False Then
            rowsperpage -= 1
        End If
        Noofrows = DGV.Rows.Count - rowsprinted
        If Noofrows > rowsperpage Then
            Noofrows = rowsperpage
        End If

        If pagesprinted = 0 Then

            Noofpages = Math.DivRem(DGV.Rows.Count - 1, rowsperpage, remain)
            If remain > 0 Then
                Noofpages = Noofpages + 1
            End If
        End If

        If Noofpages < 1 Then
            Noofpages = 1
        End If
        Me.Billing_ppc.Rows = Noofpages
    End Sub

    Private Sub PrintHeader(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim GenOpt() As String = {}
        Dim MyName As String
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = True Then
            OptionsDialog.ShowDialog()
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "/Data/Opt.sof") Then
            Dim Opt As String = MainForm.FillGenPref()
            GenOpt = Opt.Split(vbCrLf)
            MyName = GenOpt(0).ToString
        Else
            MyName = "My Shop"
        End If
        'Print Header rect
        HeadRect = e.MarginBounds
        If e.MarginBounds.Width < 400 Then
            HeadRect.Height = 70
        Else
            HeadRect.Height = 100
        End If

        'e.Graphics.DrawRectangle(Pens.Black, HeadRect)

        'Print Header Text
        Textlayout.Alignment = StringAlignment.Near

        If e.MarginBounds.Width < 400 Then
            HeadFont = New Font(System.Drawing.FontFamily.GenericSerif, 7)
        Else
            HeadFont = New Font(System.Drawing.FontFamily.GenericSerif, 11)
        End If

        If MyName <> "" Then
            e.Graphics.DrawString(MyName, HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If e.MarginBounds.Width < 400 Then
            HeadFont = New Font(System.Drawing.FontFamily.GenericSerif, 6)
            FootFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 6)
            BodyFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 5)
            HeadCellFont = New Font(System.Drawing.FontFamily.GenericSerif, 6)
        Else
            HeadFont = New Font(System.Drawing.FontFamily.GenericSerif, 9)
            FootFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 7)
            HeadCellFont = New Font(System.Drawing.FontFamily.GenericSerif, 6)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2) <> "" And Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2) & ", " & Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        ElseIf Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2) <> "" And Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2) = "" Then
            e.Graphics.DrawString(vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        ElseIf Microsoft.VisualBasic.Mid(GenOpt(1).ToString, 2) = "" And Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(2).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(3).ToString, 2) <> "" And Microsoft.VisualBasic.Mid(GenOpt(5).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(4).ToString, 2) & " - " & Microsoft.VisualBasic.Mid(GenOpt(5).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        ElseIf Microsoft.VisualBasic.Mid(GenOpt(3).ToString, 2) <> "" And Microsoft.VisualBasic.Mid(GenOpt(5).ToString, 2) = "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(4).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(4).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & Microsoft.VisualBasic.Mid(GenOpt(4).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(6).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Phone: " & Microsoft.VisualBasic.Mid(GenOpt(6).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(7).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Email: " & Microsoft.VisualBasic.Mid(GenOpt(7).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        If Microsoft.VisualBasic.Mid(GenOpt(8).ToString, 2) <> "" Then
            e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Wesite: " & Microsoft.VisualBasic.Mid(GenOpt(8).ToString, 2), HeadFont, Brushes.Black, HeadRect, Textlayout)
        End If

        Textlayout.Alignment = StringAlignment.Center
        e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Cash Bill", HeadFont, Brushes.Black, HeadRect, Textlayout)

        Textlayout.Alignment = StringAlignment.Far
        e.Graphics.DrawString("Bill No.: " & BillNo, HeadFont, Brushes.Black, HeadRect, Textlayout)
        e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Date: " & ThisDate, HeadFont, Brushes.Black, HeadRect, Textlayout)
        e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "Time: " & ThisTime, HeadFont, Brushes.Black, HeadRect, Textlayout)
    End Sub

    Private Sub PrintRows(ByVal Noofrows As Integer, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        If e.MarginBounds.Width < 400 Then
            BodyFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 5)
        Else
            BodyFont = New Font(System.Drawing.FontFamily.GenericSansSerif, 7)
        End If
        For i As Integer = 1 To Noofrows
            Dim BCell As Rectangle = New System.Drawing.Rectangle
            Textlayout.Alignment = StringAlignment.Center
            Textlayout.LineAlignment = StringAlignment.Center
            BCell = e.MarginBounds
            BCell.Height = LSpace
            BCell.Width = e.MarginBounds.Width * 0.07
            BCell.Y += HeadRect.Height + 35 + ((i - 1) * LSpace)
            BCell.X = e.PageSettings.Margins.Left
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            e.Graphics.DrawString(DGV.Rows(rowsprinted).Cells(0).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 1 Then
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width * 0.15
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Center
                e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(1).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width * 0.32
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Near
                e.Graphics.DrawString("   " & DGV.Rows.Item(rowsprinted).Cells(2).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
            ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 0 Then
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width * 0.4
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Near
                e.Graphics.DrawString("   " & DGV.Rows.Item(rowsprinted).Cells(2).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
            End If

            BCell.X += BCell.Width
            BCell.Width = e.MarginBounds.Width * 0.12
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            Textlayout.Alignment = StringAlignment.Far
            e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(3).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
            BCell.X += BCell.Width + e.MarginBounds.Width * 0.011
            BCell.Width = e.MarginBounds.Width * 0.08
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            Textlayout.Alignment = StringAlignment.Center
            e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(4).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
            If Me.DGV.ColumnCount = 7 Then
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width * 0.08
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Center
                e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(5).Value.ToString, BodyFont, Brushes.Black, BCell, Textlayout)
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width - (BCell.X - e.PageSettings.Margins.Left) - 5
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Far
                e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(6).Value.ToString & "     ", FootFont, Brushes.Black, BCell, Textlayout)
                rowsprinted += 1
            ElseIf Me.DGV.ColumnCount = 6 Then
                BCell.X += BCell.Width
                BCell.Width = e.MarginBounds.Width - (BCell.X - e.PageSettings.Margins.Left) - 5
                'e.Graphics.DrawRectangle(Pens.Blue, BCell)
                Textlayout.Alignment = StringAlignment.Far
                e.Graphics.DrawString(DGV.Rows.Item(rowsprinted).Cells(5).Value.ToString & "     ", FootFont, Brushes.Black, BCell, Textlayout)
                rowsprinted += 1
            End If

            ManagePages(i, e, Noofrows, BCell)

        Next
    End Sub

    Private Sub ManagePages(ByVal i As Integer, ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal Noofrows As Integer, ByVal BCell As System.Drawing.Rectangle)
        If Noofpages > pagesprinted Then
            e.HasMorePages = True
        ElseIf i = Noofrows And Noofpages = pagesprinted Then
            Dim TtlQuant As Integer = 0
            For i = 0 To Me.DGV.RowCount - 1
                TtlQuant += CInt(Me.DGV.Rows(i).Cells(4).Value)
            Next
            BCell = e.MarginBounds
            BCell.Y += HeadRect.Height + 35 + LSpace * (Noofrows) 'BodyRect.Height  'e.PageSettings.Margins.Top + HeadRect.Height + (e.MarginBounds.Height * 0.005) + ((i + 1) * 30)
            BCell.Height = 30
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 1 Then
                BCell.Width = e.MarginBounds.Width * 0.67
            ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 0 Then
                BCell.Width = e.MarginBounds.Width * 0.6
            End If

            BCell.X = e.PageSettings.Margins.Left
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            Textlayout.Alignment = StringAlignment.Far
            e.Graphics.DrawString("Total:   ", FootFont, Brushes.Black, BCell, Textlayout)
            Textlayout.Alignment = StringAlignment.Near
            Dim Rs() As String = BillAmt.Split(".", 2, StringSplitOptions.None)
            If Rs(1) = 0 Then
                Dim cost As String = InWords.NuminWords(Rs(0), True)
                e.Graphics.DrawString(vbCrLf & "Rupees" & cost & " only.", FootFont, Brushes.Black, BCell, Textlayout)
            Else
                Dim cost As String = InWords.NuminWords(Rs(0), True) & " and " & InWords.TensPart(Rs(1), False) & " paise"
                e.Graphics.DrawString(vbCrLf & "Rupees" & cost & " only.", FootFont, Brushes.Black, BCell, Textlayout)
            End If
            BCell.X += BCell.Width
            BCell.Width = e.MarginBounds.Width * 0.08
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            Textlayout.Alignment = StringAlignment.Center
            e.Graphics.DrawString(TtlQuant.ToString, FootFont, Brushes.Black, BCell, Textlayout)
            BCell.X += BCell.Width
            BCell.Width = e.MarginBounds.Width - (BCell.X - e.PageSettings.Margins.Left) - 5
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            Textlayout.Alignment = StringAlignment.Far
            e.Graphics.DrawString(BillAmt, FootFont, Brushes.Black, BCell, Textlayout)
            e.Graphics.DrawLine(Pens.Blue, e.PageSettings.Margins.Left, BCell.Y + 30, e.MarginBounds.Right, BCell.Y + 30)
            pagesprinted = 0
            rowsprinted = 0
        End If
        If i = Noofrows Then
            e.Graphics.DrawLine(Pens.Blue, e.MarginBounds.Left, e.MarginBounds.Top + HeadRect.Height + 35 + (LSpace * Noofrows), e.MarginBounds.Right, e.MarginBounds.Top + HeadRect.Height + 35 + (LSpace * Noofrows))
            'BCell = e.MarginBounds
            'BCell.Y += HeadRect.Height + 35
            'BCell.Height = LSpace * Noofrows 'e.MarginBounds.Height * 0.85 - 30
            'BCell.Width = e.MarginBounds.Width * 0.07
            'BCell.X = e.PageSettings.Margins.Left
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 1 Then
            '    BCell.X += BCell.Width
            '    BCell.Width = e.MarginBounds.Width * 0.15
            '    e.Graphics.DrawRectangle(Pens.Blue, BCell)
            '    BCell.X += BCell.Width
            '    BCell.Width = e.MarginBounds.Width * 0.32
            '    e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 0 Then
            '    BCell.X += BCell.Width
            '    BCell.Width = e.MarginBounds.Width * 0.4
            '    e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'End If

            'BCell.X += BCell.Width
            'BCell.Width = e.MarginBounds.Width * 0.13
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'BCell.X += BCell.Width
            'BCell.Width = e.MarginBounds.Width * 0.08
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'If Me.DGV.ColumnCount = 7 Then
            '    BCell.X += BCell.Width
            '    BCell.Width = e.MarginBounds.Width * 0.08
            '    e.Graphics.DrawRectangle(Pens.Blue, BCell)
            'End If
            'BCell.X += BCell.Width
            'BCell.Width = e.MarginBounds.Width - (BCell.X - e.PageSettings.Margins.Left)
            'e.Graphics.DrawRectangle(Pens.Blue, BCell)
        End If
    End Sub

    Private Sub DrawPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        'e.MarginBounds.Height * 0.1
        FootRect = e.MarginBounds
        FootRect.Height = 50 'e.MarginBounds.Height * 0.05
        FootRect.Y = e.MarginBounds.Bottom - 50 'e.MarginBounds.Height * 0.95
        BodyRect = e.MarginBounds
        BodyRect.Height = e.MarginBounds.Height * 0.83
        BodyRect.Y += HeadRect.Height + 5
        Textlayout = New System.Drawing.StringFormat
        Textlayout.Trimming = StringTrimming.EllipsisCharacter

        'Draw Page Layout
        'e.Graphics.FillRectangle(Brushes.White, HeadRect)
        'e.Graphics.FillRectangle(Brushes.White, BodyRect)
        'e.Graphics.DrawRectangle(Pens.Blue, BodyRect)
        'e.Graphics.DrawLine(Pens.Blue, 10, BodyRect.Y, 10, FootRect.Y)
        'e.Graphics.FillRectangle(Brushes.White, FootRect)
        e.Graphics.DrawRectangle(Pens.Black, FootRect)
    End Sub

    Private Sub DrawCHeader(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Draw Column Header Cells and text
        If e.MarginBounds.Width < 400 Then
            HeadCellFont = New Font(System.Drawing.FontFamily.GenericSerif, 5)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0, Microsoft.Win32.RegistryValueKind.DWord)
            MessageBox.Show("The Column 'Product Code' has been removed as the width of the page is smaller", "Product Code Coulmn remved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            HeadCellFont = New Font(System.Drawing.FontFamily.GenericSerif, 8)
        End If
        Dim HCell As Rectangle = New System.Drawing.Rectangle
        Textlayout.Alignment = StringAlignment.Center
        Textlayout.LineAlignment = StringAlignment.Center
        HCell = e.MarginBounds
        HCell.Height = 30
        HCell.Width = e.MarginBounds.Width * 0.07
        HCell.Y += HeadRect.Height + 5
        HCell.X = e.PageSettings.Margins.Left
        e.Graphics.DrawLine(Pens.Blue, e.MarginBounds.Left, HCell.Y, e.MarginBounds.Right, HCell.Y)
        e.Graphics.DrawLine(Pens.Blue, e.MarginBounds.Left, HCell.Y + 30, e.MarginBounds.Right, HCell.Y + 30)
        'e.Graphics.DrawRectangle(Pens.Blue, HCell)
        e.Graphics.DrawString("Sl.No.", HeadCellFont, Brushes.Black, HCell, Textlayout)
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 1 Then
            HCell.X += HCell.Width
            HCell.Width = e.MarginBounds.Width * 0.15
            'e.Graphics.DrawRectangle(Pens.Blue, HCell)
            e.Graphics.DrawString("Product Code", HeadCellFont, Brushes.Black, HCell, Textlayout)
            HCell.X += HCell.Width
            HCell.Width = e.MarginBounds.Width * 0.32
            'e.Graphics.DrawRectangle(Pens.Blue, HCell)
            e.Graphics.DrawString("Description", HeadCellFont, Brushes.Black, HCell, Textlayout)
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ProdCode", 0) = 0 Then
            HCell.X += HCell.Width
            HCell.Width = e.MarginBounds.Width * 0.4
            'e.Graphics.DrawRectangle(Pens.Blue, HCell)
            e.Graphics.DrawString("Description", HeadCellFont, Brushes.Black, HCell, Textlayout)

        End If
        Dim Currency As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Currency", "Rs.")
        HCell.X += HCell.Width
        HCell.Width = e.MarginBounds.Width * 0.13
        'e.Graphics.DrawRectangle(Pens.Blue, HCell)
        e.Graphics.DrawString("Rate " & Currency, HeadCellFont, Brushes.Black, HCell, Textlayout)
        HCell.X += HCell.Width
        HCell.Width = e.MarginBounds.Width * 0.08
        'e.Graphics.DrawRectangle(Pens.Blue, HCell)
        e.Graphics.DrawString("Qty.", HeadCellFont, Brushes.Black, HCell, Textlayout)
        If Me.DGV.ColumnCount = 7 Then
            HCell.X += HCell.Width
            HCell.Width = e.MarginBounds.Width * 0.08
            'e.Graphics.DrawRectangle(Pens.Blue, HCell)
            e.Graphics.DrawString("Disc.%", HeadCellFont, Brushes.Black, HCell, Textlayout)
        End If
        HCell.X += HCell.Width
        HCell.Width = e.MarginBounds.Width - (HCell.X - e.PageSettings.Margins.Left)
        'e.Graphics.DrawRectangle(Pens.Blue, HCell)
        e.Graphics.DrawString("Amount " & Currency, HeadCellFont, Brushes.Black, HCell, Textlayout)
        pagesprinted += 1
        'Me.Billing_ppc.Zoom = 0.85
    End Sub

    Private Sub SetBillNo()
        Dim BillNo As String = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "00001")).ToString
        Dim Len As Integer = BillNo.Length
        BillNo = (CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "00001")) + CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Step", "1"))).ToString
        For i As Integer = 1 To Len - 1
            If BillNo.Length < Len Then
                BillNo = "0" + BillNo
            ElseIf BillNo.Length >= Len Then
                Exit For
            End If
        Next
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", BillNo, Microsoft.Win32.RegistryValueKind.String)
    End Sub

    Private Sub GetBillNo()
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
            If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                BillingForm.BillNo_tbx.Tag = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "")).ToString
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
                    Prefix = (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "OPrefix", "")).ToString + Prefix
                    BillingForm.BillNo_tbx.Tag = Prefix + (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "Seed", "")).ToString
                End If
            End If
        End If
    End Sub

    Private Sub SaveShortBill()
        Dim BillSummary As BillingDataSet.ShortBillRow
        BillSummary = BillingForm.MainBillingDataSet.ShortBill.NewShortBillRow()
        BillSummary.BillNo = BillingForm.BillNo_tbx.Tag
        BillSummary.TotalPrice = CDbl(BillingForm.Ttl_tbx.Text)
        BillSummary.ThisDate = BillingForm.Thisday_lbl.Text
        BillSummary.ThisTime = BillingForm.Thisday_lbl.Tag
        If BillingForm.RAmt_tbx.Text <> "" Then
            BillSummary.Received = CDbl(BillingForm.RAmt_tbx.Text)
            BillSummary.Returned = CDbl(BillingForm.BAmt_tbx.Text)
        Else
            BillSummary.Received = 0
            BillSummary.Returned = CDbl(0 - CDbl(BillingForm.Pay_tbx.Text))
        End If

        If BillingForm.DiscAmt_tbx.Enabled = False Then
            BillSummary.DiscOnTotal = "%" + BillingForm.DiscPer_tbx.Text
        ElseIf BillingForm.DiscPer_tbx.Enabled = False Then
            BillSummary.DiscOnTotal = BillingForm.DiscAmt_tbx.Text
        Else
            BillSummary.DiscOnTotal = 0
        End If

        If BillingForm.BDGV.ColumnCount = 7 Then
            BillSummary.PerItemDisc = True
        ElseIf BillingForm.BDGV.ColumnCount = 6 Then
            BillSummary.PerItemDisc = False
        End If

        Try
            BillingForm.MainBillingDataSet.ShortBill.AddShortBillRow(BillSummary)
            BillingForm.ShortBillTableAdapter.Update(BillSummary)
        Catch ex As ConstraintException
            If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", Nothing) Is Nothing = False Then
                If CInt(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Shopkeeper's Inventory", "ifAutoIncr", 1)) = 1 Then
                    SetBillNo()
                End If
            End If
            GetBillNo()
            Dim result As DialogResult
            result = MessageBox.Show("Bill No. " & BillSummary.BillNo & " already exits. Do you want to save this as a new Bill? If Yes the bill will be saved separately with the Bill No." & BillingForm.BillNo_tbx.Tag & " else the Bill will be overwritten.", "Bill Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If result = System.Windows.Forms.DialogResult.Yes Then
                SaveShortBill()
            ElseIf result = System.Windows.Forms.DialogResult.No Then
                EditBill()
            ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        BillSummary = Nothing
        BillingForm.BillNo_tbx.Text = BillingForm.BillNo_tbx.Tag

    End Sub

    Private Sub SaveInvoice()
        For i As Integer = 0 To BillingForm.BDGV.Rows.Count - 2
            Dim NewInvoice As BillingDataSet.InvoiceRow
            NewInvoice = BillingForm.MainBillingDataSet.Invoice.NewInvoiceRow()
            NewInvoice.RefNo = BillingForm.BillNo_tbx.Text.ToString & BillingForm.BDGV.Rows(i).Cells(0).Value.ToString
            NewInvoice.ProductCode = BillingForm.BDGV.Rows(i).Cells(1).Value
            NewInvoice.Description = BillingForm.BDGV.Rows(i).Cells(2).Value
            NewInvoice.Price = CDbl(BillingForm.BDGV.Rows(i).Cells(3).Value)
            NewInvoice.Quantity = CInt(BillingForm.BDGV.Rows(i).Cells(4).Value)
            Dim Getdetails As InventoryDataSet.Details1Row
            Getdetails = BillingForm.MainInventoryDataSet.Details1.FindByCode(NewInvoice.ProductCode)
            Getdetails.BeginEdit()
            Getdetails.Available_Nos = Getdetails.Available_Nos - NewInvoice.Quantity
            Getdetails.EndEdit()
            Try
                BillingForm.Details1TableAdapter.Update(Getdetails)
                BillingForm.DetailsTableAdapter.Fill(BillingForm.MainInventoryDataSet.Details)
                Getdetails = Nothing
            Catch ex As Exception
                Exit Try
            End Try
            If BillingForm.BDGV.ColumnCount = 7 Then
                NewInvoice.Discount = CInt(BillingForm.BDGV.Rows(i).Cells(5).Value)
            ElseIf BillingForm.BDGV.ColumnCount = 6 Then
                NewInvoice.Discount = 0
            End If
            NewInvoice.BillNo = BillingForm.BillNo_tbx.Text
            Try
                BillingForm.MainBillingDataSet.Invoice.AddInvoiceRow(NewInvoice)
                BillingForm.InvoiceTableAdapter.Update(NewInvoice)
                NewInvoice = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        Next

        BillingForm.TabControl.TabPages(BillingForm.TabControl.SelectedIndex).Text = BillingForm.BillNo_tbx.Text + " (Saved)"
        BillingForm.TabControl.TabPages(BillingForm.TabControl.SelectedIndex).Tag = BillingForm.BillNo_tbx.Text

        'BillingForm.BillNo_tbx.Text = BillingForm.BillNo_tbx.Tag

    End Sub

    Private Sub EditBill()
        Dim DelInvoice() As BillingDataSet.InvoiceRow
        DelInvoice = BillingForm.MainBillingDataSet.Invoice.Select("BillNo =" & BillingForm.BillNo_tbx.Text)
        If DelInvoice.Length > 0 Then
            Dim InvoiceItem As BillingDataSet.InvoiceRow
            For Each InvoiceItem In DelInvoice
                Dim GetDetails As InventoryDataSet.Details1Row
                GetDetails = BillingForm.MainInventoryDataSet.Details1.FindByCode(InvoiceItem.ProductCode)
                GetDetails.BeginEdit()
                GetDetails.Available_Nos += InvoiceItem.Quantity
                GetDetails.EndEdit()
                Try
                    BillingForm.Details1TableAdapter.Update(GetDetails)
                    BillingForm.DetailsTableAdapter.Fill(BillingForm.MainInventoryDataSet.Details)
                    GetDetails = Nothing
                Catch ex As Exception
                    Exit Try
                End Try
                InvoiceItem.Delete()
            Next
            BillingForm.InvoiceTableAdapter.Update(BillingForm.MainBillingDataSet)
            InvoiceItem = Nothing
        End If
        DelInvoice = Nothing

        Dim BillSummary As BillingDataSet.ShortBillRow
        BillSummary = BillingForm.MainBillingDataSet.ShortBill.FindByBillNo(BillingForm.BillNo_tbx.Text)
        BillSummary.BeginEdit()
        BillSummary.TotalPrice = CDbl(BillingForm.Ttl_tbx.Text)
        BillSummary.ThisDate = BillingForm.Thisday_lbl.Text
        BillSummary.ThisTime = BillingForm.Thisday_lbl.Tag
        If BillingForm.RAmt_tbx.Text <> "" Then
            BillSummary.Received = CDbl(BillingForm.RAmt_tbx.Text)
            BillSummary.Returned = CDbl(BillingForm.BAmt_tbx.Text)
        Else
            BillSummary.Received = 0
            BillSummary.Returned = CDbl(0 - CDbl(BillingForm.Pay_tbx.Text))
        End If

        If BillingForm.DiscAmt_tbx.Enabled = False Then
            BillSummary.DiscOnTotal = "%" + BillingForm.DiscPer_tbx.Text
        ElseIf BillingForm.DiscPer_tbx.Enabled = False Then
            BillSummary.DiscOnTotal = BillingForm.DiscAmt_tbx.Text
        Else
            BillSummary.DiscOnTotal = 0
        End If

        If BillingForm.BDGV.ColumnCount = 7 Then
            BillSummary.PerItemDisc = True
        ElseIf BillingForm.BDGV.ColumnCount = 6 Then
            BillSummary.PerItemDisc = False
        End If
        BillSummary.EndEdit()
        Try
            BillingForm.ShortBillTableAdapter.Update(BillSummary)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        BillSummary = Nothing

        SaveInvoice()

    End Sub

#End Region

End Class