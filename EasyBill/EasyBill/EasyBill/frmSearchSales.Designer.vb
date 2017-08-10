<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSales
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.dtPurchaseDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtPurchaseDateFrom = New System.Windows.Forms.DateTimePicker
        Me.lsvPurchaseSearch = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvPurchaseSearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.dtPurchaseDateTo)
        Me.GroupBox1.Controls.Add(Me.dtPurchaseDateFrom)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 479)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Sales"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(18, 30)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Bill No"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 20)
        Me.TextBox1.TabIndex = 1
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(209, 30)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Bill Date"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'dtPurchaseDateTo
        '
        Me.dtPurchaseDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtPurchaseDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPurchaseDateTo.Location = New System.Drawing.Point(331, 53)
        Me.dtPurchaseDateTo.Name = "dtPurchaseDateTo"
        Me.dtPurchaseDateTo.Size = New System.Drawing.Size(116, 20)
        Me.dtPurchaseDateTo.TabIndex = 6
        '
        'dtPurchaseDateFrom
        '
        Me.dtPurchaseDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtPurchaseDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPurchaseDateFrom.Location = New System.Drawing.Point(209, 53)
        Me.dtPurchaseDateFrom.Name = "dtPurchaseDateFrom"
        Me.dtPurchaseDateFrom.Size = New System.Drawing.Size(116, 20)
        Me.dtPurchaseDateFrom.TabIndex = 5
        '
        'lsvPurchaseSearch
        '
        Me.lsvPurchaseSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader3})
        Me.lsvPurchaseSearch.FullRowSelect = True
        Me.lsvPurchaseSearch.GridLines = True
        Me.lsvPurchaseSearch.Location = New System.Drawing.Point(18, 79)
        Me.lsvPurchaseSearch.MultiSelect = False
        Me.lsvPurchaseSearch.Name = "lsvPurchaseSearch"
        Me.lsvPurchaseSearch.Size = New System.Drawing.Size(842, 379)
        Me.lsvPurchaseSearch.TabIndex = 8
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
        Me.ColumnHeader9.Text = "Bill No"
        Me.ColumnHeader9.Width = 131
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Sales Date"
        Me.ColumnHeader10.Width = 181
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Customer Name"
        Me.ColumnHeader11.Width = 197
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Total Amount"
        Me.ColumnHeader12.Width = 212
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(486, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Payment Type"
        '
        'frmSearchSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmSearchSales"
        Me.Text = "Search Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtPurchaseDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPurchaseDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lsvPurchaseSearch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
