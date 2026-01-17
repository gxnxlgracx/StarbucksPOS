Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Text
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Payment
    Private dataTable As DataTable

    Public Sub New(dataTable As DataTable)
        InitializeComponent()
        Me.dataTable = dataTable
        LoadData()
    End Sub

    Private Sub LoadData()
        DataGridView2.DataSource = dataTable
        DataGridView2.ReadOnly = True 'Make the DataGridView non-editable

        'Calculate the total of all product prices
        Dim total As Decimal = 0
        For Each row As DataRow In dataTable.Rows
            total += Convert.ToDecimal(row("Price"))
        Next

        'Set the transaction total text field to the total sum of prices in decimal form with two decimal places
        txtTotal.Text = total.ToString("N2")

        'Set the column widths
        DataGridView2.Columns("ID").Width = 55
        DataGridView2.Columns("Name").Width = 267
        DataGridView2.Columns("Quantity").Width = 56
        DataGridView2.Columns("Price").Width = 55
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            'et the customer tender from the text field
            Dim customerTender As Decimal = Decimal.Parse(txtTender.Text)

            'alculate the change
            Dim totalAmount As Decimal = Decimal.Parse(txtTotal.Text)
            Dim change As Decimal = customerTender - totalAmount

            'isplay the change in a new text field
            txtChange.Text = change.ToString("N2")

            'heck if the total is greater than the customer tender and display an error message if it is
            If totalAmount > customerTender Then
                MessageBox.Show("Not enough balance!", "Payment error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Payment successful!", "Payment success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'isplay the receipt in the TextArea
                Dim receiptText As New StringBuilder()

                receiptText.AppendLine("                Starbucks GG")
                receiptText.AppendLine("            0904/ Amihan Road,")
                receiptText.AppendLine("          Las Piñas, Metro Manila")
                receiptText.AppendLine("            +63 912 345 6789")
                receiptText.AppendLine("-------------------------------------------------------")
                receiptText.AppendLine(String.Format("{0,-20} {1,13} {2,18}", "Item", "Qty", "Price"))
                receiptText.AppendLine("-------------------------------------------------------")

                'dd items from your DataTable here
                For Each row As DataRow In dataTable.Rows
                    Dim itemName As String = row("Name").ToString()
                    Dim quantity As String = row("Quantity").ToString()
                    Dim price As String = Convert.ToDecimal(row("Price")).ToString("N2")

                    Select Case itemName
                        Case "Iced Caramel Macchiato"
                            itemName = "Iced Caramel           "
                        Case "Mocha Frappuccino"
                            itemName = "Mocha Frap             "
                        Case "Double Chocolate Chip Frappuccino"
                            itemName = "Dbl Choc Frap         "
                        Case "Java Chip Frappuccino"
                            itemName = "Java Chip Frap        "
                        Case "Iced Green Tea Lemonade"
                            itemName = "Iced Green Tea       "
                        Case "Brown Sugar Iced Shaken Espresso"
                            itemName = "Brwn Sugar Esp"
                        Case "Strawberry Acai"
                            itemName = "Strawberry Acai       "
                        Case "Strawberries & Cream Frappuccino"
                            itemName = "Strawberries Frap    "
                    End Select

                    receiptText.AppendLine(String.Format("{0,-20} {1,3} {2,20}", itemName, quantity, price))
                Next

                receiptText.AppendLine("-------------------------------------------------------")
                receiptText.AppendLine(String.Format("{0,-20} {1,35}", "Total:", txtTotal.Text))
                Dim customerTenderDecimal As Decimal = Decimal.Parse(txtTender.Text)
                receiptText.AppendLine(String.Format("{0,-20} {1,33:N2}", "Tender:", customerTenderDecimal))
                receiptText.AppendLine(String.Format("{0,-20} {1,33}", "Change:", txtChange.Text))
                receiptText.AppendLine("-------------------------------------------------------")
                receiptText.AppendLine("      Thank you for your purchase!")
                receiptText.AppendLine("-------------------------------------------------------")
                receiptText.AppendLine("      © Genel Grace L. Amihan 2024")

                receipt.Text = receiptText.ToString()
            End If
        Catch ex As FormatException
            MessageBox.Show("Invalid tender amount!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            'reate a PDF document
            Dim document As New iTextSharp.text.Document()
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
            saveFileDialog.FileName = "Amihan-Starbs_Receipt"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(document, New FileStream(saveFileDialog.FileName, FileMode.Create))
                document.Open()
                Dim font As New Font(FontFactory.GetFont("Arial", 12))
                Dim paragraph As New Paragraph(receipt.Text, font)
                document.Add(paragraph)
                document.Close()
                MessageBox.Show("Receipt saved as " & saveFileDialog.FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while generating the receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Login.ClearFields() ' Clear the login form fields
        Login.Show()
        Me.Close()
    End Sub

    Friend WithEvents btnBack As Button
End Class

'AMIHAN