Public Class frmProduct

    Dim objEasyBill As New clsEasyBill

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If isValidationPassed() = False Then
            Exit Sub
        End If

        objEasyBill.InsertProduct(txtItemCode.Text, txtBarcode.Text, txtItemName.Text, dropUnit.Text)

        MsgBox("Product Saved Successfully", MsgBoxStyle.Information)

        txtBarcode.Clear()
        txtItemCode.Clear()
        txtItemName.Clear()

        txtItemCode.Focus()

    End Sub

    Private Function isValidationPassed() As Boolean

        isValidationPassed = True

        If txtBarcode.Text.Trim = Nothing Then
            MsgBox("Please enter Barcode", MsgBoxStyle.Information)
            txtBarcode.Focus()
            Return False
        End If

        If txtItemCode.Text.Trim = Nothing Then
            MsgBox("Please enter Item Code", MsgBoxStyle.Information)
            txtItemCode.Focus()
            Return False
        End If

        If txtItemName.Text.Trim = Nothing Then
            MsgBox("Please enter Item Name", MsgBoxStyle.Information)
            txtItemName.Focus()
            Return False
        End If

    End Function

End Class