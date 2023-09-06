Public Class Form1
    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        Dim Price As Decimal
        Dim Quantity As Integer
        Dim Total As Decimal
        Dim Name As String

        Price = txtPrice.Text
        Quantity = txtQuantity.Text
        Name = txtName.Text

        Total = Price * Quantity
        MsgBox("You have bought " & Quantity & " items for R" & Price & " each, Your total cost is R" & Total & " " & Name)


    End Sub
End Class
