<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_ReturnBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lstItem = New System.Windows.Forms.ListView()
        Me.Book_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Issue_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Due_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Daily_Late_Fee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Owing = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstReturnNotes = New System.Windows.Forms.ListView()
        Me.txtFeesPaid = New System.Windows.Forms.NumericUpDown()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCopyID = New System.Windows.Forms.Label()
        Me.Copy_ID = New System.Windows.Forms.TextBox()
        CType(Me.txtFeesPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstItem
        '
        Me.lstItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Book_Id, Me.Issue_Date, Me.Due_Date, Me.Daily_Late_Fee, Me.Owing})
        Me.lstItem.HideSelection = False
        Me.lstItem.Location = New System.Drawing.Point(28, 94)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(751, 166)
        Me.lstItem.TabIndex = 0
        Me.lstItem.UseCompatibleStateImageBehavior = False
        Me.lstItem.View = System.Windows.Forms.View.Details
        '
        'Book_Id
        '
        Me.Book_Id.Text = "Title"
        Me.Book_Id.Width = 340
        '
        'Issue_Date
        '
        Me.Issue_Date.Text = "Borrow Date"
        Me.Issue_Date.Width = 100
        '
        'Due_Date
        '
        Me.Due_Date.Text = "Due Date"
        Me.Due_Date.Width = 100
        '
        'Daily_Late_Fee
        '
        Me.Daily_Late_Fee.Text = "Daily Late Fee"
        Me.Daily_Late_Fee.Width = 100
        '
        'Owing
        '
        Me.Owing.Text = "Owing"
        Me.Owing.Width = 110
        '
        'lstReturnNotes
        '
        Me.lstReturnNotes.HideSelection = False
        Me.lstReturnNotes.Location = New System.Drawing.Point(28, 291)
        Me.lstReturnNotes.Name = "lstReturnNotes"
        Me.lstReturnNotes.Size = New System.Drawing.Size(643, 86)
        Me.lstReturnNotes.TabIndex = 1
        Me.lstReturnNotes.UseCompatibleStateImageBehavior = False
        '
        'txtFeesPaid
        '
        Me.txtFeesPaid.Location = New System.Drawing.Point(677, 291)
        Me.txtFeesPaid.Name = "txtFeesPaid"
        Me.txtFeesPaid.Size = New System.Drawing.Size(102, 20)
        Me.txtFeesPaid.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(569, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(677, 394)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(102, 23)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(674, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fee Paid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Return Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Item"
        '
        'lblCopyID
        '
        Me.lblCopyID.AutoSize = True
        Me.lblCopyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyID.Location = New System.Drawing.Point(28, 35)
        Me.lblCopyID.Name = "lblCopyID"
        Me.lblCopyID.Size = New System.Drawing.Size(56, 13)
        Me.lblCopyID.TabIndex = 10
        Me.lblCopyID.Text = "Copy ID:"
        '
        'Copy_ID
        '
        Me.Copy_ID.Location = New System.Drawing.Point(90, 32)
        Me.Copy_ID.Name = "Copy_ID"
        Me.Copy_ID.Size = New System.Drawing.Size(100, 20)
        Me.Copy_ID.TabIndex = 0
        '
        'UserControl_ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Copy_ID)
        Me.Controls.Add(Me.lblCopyID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtFeesPaid)
        Me.Controls.Add(Me.lstReturnNotes)
        Me.Controls.Add(Me.lstItem)
        Me.Name = "UserControl_ReturnBook"
        Me.Size = New System.Drawing.Size(800, 423)
        CType(Me.txtFeesPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstItem As ListView
    Friend WithEvents lstReturnNotes As ListView
    Friend WithEvents txtFeesPaid As NumericUpDown
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Book_Id As ColumnHeader
    Friend WithEvents Issue_Date As ColumnHeader
    Friend WithEvents Due_Date As ColumnHeader
    Friend WithEvents Daily_Late_Fee As ColumnHeader
    Friend WithEvents Owing As ColumnHeader
    Friend WithEvents lblCopyID As Label
    Friend WithEvents Copy_ID As TextBox
End Class
