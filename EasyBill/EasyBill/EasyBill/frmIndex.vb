Public Class frmIndex

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click

        frmProduct.MdiParent = Me
        frmProduct.Location = New Point(0, 0)
        frmProduct.BringToFront()
        frmProduct.Show()

    End Sub


    Private Sub ProductSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductSearchToolStripMenuItem.Click

        frmSearchProduct.MdiParent = Me
        frmSearchProduct.Location = New Point(0, 0)
        frmSearchProduct.BringToFront()
        frmSearchProduct.Show()

    End Sub


    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click

        frmPurchase.MdiParent = Me
        frmPurchase.Location = New Point(0, 0)
        frmPurchase.BringToFront()
        frmPurchase.Show()

    End Sub

    Private Sub PurchaseSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseSearchToolStripMenuItem.Click

        frmSearchPurchase.MdiParent = Me
        frmSearchPurchase.Location = New Point(0, 0)
        frmSearchPurchase.BringToFront()
        frmSearchPurchase.Show()

    End Sub

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click

        frmSales.MdiParent = Me
        frmSales.Location = New Point(0, 0)
        frmSales.BringToFront()
        frmSales.Show()

    End Sub

    Private Sub SalesSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesSearchToolStripMenuItem.Click

        frmSearchSales.MdiParent = Me
        frmSearchSales.Location = New Point(0, 0)
        frmSearchSales.BringToFront()
        frmSearchSales.Show()

    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click

        frmStock.MdiParent = Me
        frmStock.Location = New Point(0, 0)
        frmStock.BringToFront()
        frmStock.Show()

    End Sub
End Class