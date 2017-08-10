<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPurchase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkInvoiceNo = New System.Windows.Forms.CheckBox
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.chkPurchaseDate = New System.Windows.Forms.CheckBox
        Me.dtPurchaseDateFrom = New System.Windows.Forms.DateTimePicker
        Me.dtPurchaseDateTo = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lsvPurchaseSearch = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditPurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvPurchaseSearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dtPurchaseDateTo)
        Me.GroupBox1.Controls.Add(Me.dtPurchaseDateFrom)
        Me.GroupBox1.Controls.Add(Me.chkPurchaseDate)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.chkInvoiceNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 456)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Search"
        '
        'chkInvoiceNo
        '
        Me.chkInvoiceNo.AutoSize = True
        Me.chkInvoiceNo.Location = New System.Drawing.Point(16, 23)
        Me.chkInvoiceNo.Name = "chkInvoiceNo"
        Me.chkInvoiceNo.Size = New System.Drawing.Size(78, 17)
        Me.chkInvoiceNo.TabIndex = 0
        Me.chkInvoiceNo.Text = "Invoice No"
        Me.chkInvoiceNo.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(16, 46)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(193, 20)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'chkPurchaseDate
        '
        Me.chkPurchaseDate.AutoSize = True
        Me.chkPurchaseDate.Location = New System.Drawing.Point(226, 23)
        Me.chkPurchaseDate.Name = "chkPurchaseDate"
        Me.chkPurchaseDate.Size = New System.Drawing.Size(97, 17)
        Me.chkPurchaseDate.TabIndex = 2
        Me.chkPurchaseDate.Text = "Purchase Date"
        Me.chkPurchaseDate.UseVisualStyleBackColor = True
        '
        'dtPurchaseDateFrom
        '
        Me.dtPurchaseDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtPurchaseDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPurchaseDateFrom.Location = New System.Drawing.Point(226, 46)
        Me.dtPurchaseDateFrom.Name = "dtPurchaseDateFrom"
        Me.dtPurchaseDateFrom.Size = New System.Drawing.Size(116, 20)
        Me.dtPurchaseDateFrom.TabIndex = 3
        '
        'dtPurchaseDateTo
        '
        Me.dtPurchaseDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtPurchaseDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPurchaseDateTo.Location = New System.Drawing.Point(348, 46)
        Me.dtPurchaseDateTo.Name = "dtPurchaseDateTo"
        Me.dtPurchaseDateTo.Size = New System.Drawing.Size(116, 20)
        Me.dtPurchaseDateTo.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(484, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lsvPurchaseSearch
        '
        Me.lsvPurchaseSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lsvPurchaseSearch.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lsvPurchaseSearch.FullRowSelect = True
        Me.lsvPurchaseSearch.GridLines = True
        Me.lsvPurchaseSearch.Location = New System.Drawing.Point(16, 73)
        Me.lsvPurchaseSearch.MultiSelect = False
        Me.lsvPurchaseSearch.Name = "lsvPurchaseSearch"
        Me.lsvPurchaseSearch.Size = New System.Drawing.Size(842, 379)
        Me.lsvPurchaseSearch.TabIndex = 6
        Me.lsvPurchaseSearch.UseCompatibleStateImageBehavior = False
        Me.lsvPurchaseSearch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No"
        Me.ColumnHeader2.Width = 40
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Invoice No"
        Me.ColumnHeader9.Width = 131
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Purchase Date"
        Me.ColumnHeader10.Width = 181
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Supplier Name"
        Me.ColumnHeader11.Width = 197
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Total Amount"
        Me.ColumnHeader12.Width = 212
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditPurchaseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(146, 26)
        '
        'EditPurchaseToolStripMenuItem
        '
        Me.EditPurchaseToolStripMenuItem.Name = "EditPurchaseToolStripMenuItem"
        Me.EditPurchaseToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EditPurchaseToolStripMenuItem.Text = "Edit Purchase"
        '
        'frmSearchPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmSearchPurchase"
        Me.Text = "Purchase Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dtPurchaseDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPurchaseDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPurchaseDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents chkInvoiceNo As System.Windows.Forms.CheckBox
    Friend WithEvents lsvPurchaseSearch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditPurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
