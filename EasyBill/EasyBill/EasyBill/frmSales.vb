
Imports System.Data.SqlClient

Public Class frmSales

    Dim collection As New AutoCompleteStringCollection
    Dim itemDataReader As SqlDataReader



    Private Sub frmSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        itemDataReader = New clsEasyBill().FetchAllProductName()
        If itemDataReader.HasRows Then
            While itemDataReader.Read()
                collection.Add(itemDataReader!vaProductName)
            End While
            'dgvSales.Columns(1).

        End If


    End Sub

    Private Sub dgvSales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSales.CellContentClick

    End Sub

    Private Sub dgvSales_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSales.EditingControlShowing



    End Sub


End Class