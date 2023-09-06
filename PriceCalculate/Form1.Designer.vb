<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Total = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        Label4 = New Label()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' Total
        ' 
        Total.Location = New Point(485, 308)
        Total.Name = "Total"
        Total.Size = New Size(227, 34)
        Total.TabIndex = 0
        Total.Text = "Total For Customer"
        Total.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(189, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 25)
        Label1.TabIndex = 1
        Label1.Text = "Price Per Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(189, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 25)
        Label2.TabIndex = 2
        Label2.Text = "Quantity Of Items"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(349, 92)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(150, 31)
        txtPrice.TabIndex = 3
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(349, 150)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(150, 31)
        txtQuantity.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(166, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 25)
        Label4.TabIndex = 6
        Label4.Text = "Enter your Full Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(349, 211)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Total)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Total As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
End Class
