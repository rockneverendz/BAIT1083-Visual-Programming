<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_ReturnBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label_Panel_Copies = New System.Windows.Forms.Label()
        Me.Panel_Copies = New System.Windows.Forms.Panel()
        Me.ListView_Copies = New System.Windows.Forms.ListView()
        Me.Copies_CopyID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_BookID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_ChkID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_IssueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_DueDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_DaysOverdue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Copies_Fines = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel_CheckoutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_Return = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Copy = New System.Windows.Forms.Panel()
        Me.Label_Copy = New System.Windows.Forms.Label()
        Me.TextBox_CopyID = New System.Windows.Forms.TextBox()
        Me.Label_Copy_Message = New System.Windows.Forms.Label()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Panel_Fine = New System.Windows.Forms.Panel()
        Me.Label_DaysOverDue = New System.Windows.Forms.Label()
        Me.TextBox_DaysOverDue = New System.Windows.Forms.TextBox()
        Me.Label_FinePerDay = New System.Windows.Forms.Label()
        Me.NumericUpDown_FinePerDay = New System.Windows.Forms.NumericUpDown()
        Me.Panel_Confirm = New System.Windows.Forms.Panel()
        Me.Label_TotalFines = New System.Windows.Forms.Label()
        Me.TextBox_TotalFines = New System.Windows.Forms.TextBox()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Panel_Copies.SuspendLayout()
        Me.TableLayoutPanel_CheckoutDetails.SuspendLayout()
        Me.TableLayoutPanel_Return.SuspendLayout()
        Me.Panel_Copy.SuspendLayout()
        Me.Panel_Fine.SuspendLayout()
        CType(Me.NumericUpDown_FinePerDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Confirm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Panel_Copies
        '
        Me.Label_Panel_Copies.AutoSize = True
        Me.Label_Panel_Copies.Location = New System.Drawing.Point(15, 15)
        Me.Label_Panel_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Panel_Copies.Name = "Label_Panel_Copies"
        Me.Label_Panel_Copies.Size = New System.Drawing.Size(39, 13)
        Me.Label_Panel_Copies.TabIndex = 2
        Me.Label_Panel_Copies.Text = "Copies"
        '
        'Panel_Copies
        '
        Me.Panel_Copies.AutoSize = True
        Me.Panel_Copies.Controls.Add(Me.Label_Panel_Copies)
        Me.Panel_Copies.Controls.Add(Me.ListView_Copies)
        Me.Panel_Copies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Copies.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Copies.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Copies.Name = "Panel_Copies"
        Me.Panel_Copies.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Copies.Size = New System.Drawing.Size(816, 326)
        Me.Panel_Copies.TabIndex = 0
        '
        'ListView_Copies
        '
        Me.ListView_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Copies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Copies_CopyID, Me.Copies_BookID, Me.Copies_Title, Me.Copies_ChkID, Me.Copies_IssueDate, Me.Copies_DueDate, Me.Copies_DaysOverdue, Me.Copies_Fines})
        Me.ListView_Copies.HideSelection = False
        Me.ListView_Copies.Location = New System.Drawing.Point(15, 38)
        Me.ListView_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_Copies.Name = "ListView_Copies"
        Me.ListView_Copies.Size = New System.Drawing.Size(786, 273)
        Me.ListView_Copies.TabIndex = 13
        Me.ListView_Copies.UseCompatibleStateImageBehavior = False
        Me.ListView_Copies.View = System.Windows.Forms.View.Details
        '
        'Copies_CopyID
        '
        Me.Copies_CopyID.Text = "Copy ID"
        '
        'Copies_BookID
        '
        Me.Copies_BookID.Text = "Book ID"
        '
        'Copies_Title
        '
        Me.Copies_Title.Text = "Book Title"
        Me.Copies_Title.Width = 180
        '
        'Copies_ChkID
        '
        Me.Copies_ChkID.Text = "Chk ID"
        '
        'Copies_IssueDate
        '
        Me.Copies_IssueDate.Text = "Issue Date"
        Me.Copies_IssueDate.Width = 90
        '
        'Copies_DueDate
        '
        Me.Copies_DueDate.Text = "Due Date"
        Me.Copies_DueDate.Width = 90
        '
        'Copies_DaysOverdue
        '
        Me.Copies_DaysOverdue.Text = "Days Overdue"
        Me.Copies_DaysOverdue.Width = 120
        '
        'Copies_Fines
        '
        Me.Copies_Fines.Text = "Fines"
        Me.Copies_Fines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel_CheckoutDetails
        '
        Me.TableLayoutPanel_CheckoutDetails.ColumnCount = 1
        Me.TableLayoutPanel_CheckoutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Copies, 0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.TableLayoutPanel_Return, 0, 1)
        Me.TableLayoutPanel_CheckoutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CheckoutDetails.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Name = "TableLayoutPanel_CheckoutDetails"
        Me.TableLayoutPanel_CheckoutDetails.RowCount = 2
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel_CheckoutDetails.Size = New System.Drawing.Size(816, 490)
        Me.TableLayoutPanel_CheckoutDetails.TabIndex = 0
        '
        'TableLayoutPanel_Return
        '
        Me.TableLayoutPanel_Return.ColumnCount = 3
        Me.TableLayoutPanel_Return.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel_Return.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.TableLayoutPanel_Return.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.TableLayoutPanel_Return.Controls.Add(Me.Panel_Copy, 0, 0)
        Me.TableLayoutPanel_Return.Controls.Add(Me.Panel_Fine, 1, 0)
        Me.TableLayoutPanel_Return.Controls.Add(Me.Panel_Confirm, 2, 0)
        Me.TableLayoutPanel_Return.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Return.Location = New System.Drawing.Point(0, 326)
        Me.TableLayoutPanel_Return.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel_Return.Name = "TableLayoutPanel_Return"
        Me.TableLayoutPanel_Return.RowCount = 1
        Me.TableLayoutPanel_Return.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Return.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel_Return.Size = New System.Drawing.Size(816, 164)
        Me.TableLayoutPanel_Return.TabIndex = 1
        '
        'Panel_Copy
        '
        Me.Panel_Copy.AutoSize = True
        Me.Panel_Copy.Controls.Add(Me.Label_Copy)
        Me.Panel_Copy.Controls.Add(Me.TextBox_CopyID)
        Me.Panel_Copy.Controls.Add(Me.Label_Copy_Message)
        Me.Panel_Copy.Controls.Add(Me.Button_Add)
        Me.Panel_Copy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Copy.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Copy.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Copy.Name = "Panel_Copy"
        Me.Panel_Copy.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Copy.Size = New System.Drawing.Size(271, 164)
        Me.Panel_Copy.TabIndex = 2
        '
        'Label_Copy
        '
        Me.Label_Copy.AutoSize = True
        Me.Label_Copy.Location = New System.Drawing.Point(15, 15)
        Me.Label_Copy.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Copy.Name = "Label_Copy"
        Me.Label_Copy.Size = New System.Drawing.Size(45, 13)
        Me.Label_Copy.TabIndex = 33
        Me.Label_Copy.Text = "Copy ID"
        '
        'TextBox_CopyID
        '
        Me.TextBox_CopyID.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_CopyID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_CopyID.Name = "TextBox_CopyID"
        Me.TextBox_CopyID.Size = New System.Drawing.Size(241, 20)
        Me.TextBox_CopyID.TabIndex = 34
        '
        'Label_Copy_Message
        '
        Me.Label_Copy_Message.ForeColor = System.Drawing.Color.Red
        Me.Label_Copy_Message.Location = New System.Drawing.Point(15, 68)
        Me.Label_Copy_Message.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Copy_Message.Name = "Label_Copy_Message"
        Me.Label_Copy_Message.Size = New System.Drawing.Size(156, 23)
        Me.Label_Copy_Message.TabIndex = 52
        Me.Label_Copy_Message.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(181, 68)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 53
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Panel_Fine
        '
        Me.Panel_Fine.Controls.Add(Me.Label_DaysOverDue)
        Me.Panel_Fine.Controls.Add(Me.TextBox_DaysOverDue)
        Me.Panel_Fine.Controls.Add(Me.Label_FinePerDay)
        Me.Panel_Fine.Controls.Add(Me.NumericUpDown_FinePerDay)
        Me.Panel_Fine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Fine.Location = New System.Drawing.Point(271, 0)
        Me.Panel_Fine.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Fine.Name = "Panel_Fine"
        Me.Panel_Fine.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Fine.Size = New System.Drawing.Size(271, 164)
        Me.Panel_Fine.TabIndex = 4
        '
        'Label_DaysOverDue
        '
        Me.Label_DaysOverDue.AutoSize = True
        Me.Label_DaysOverDue.Location = New System.Drawing.Point(15, 15)
        Me.Label_DaysOverDue.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_DaysOverDue.Name = "Label_DaysOverDue"
        Me.Label_DaysOverDue.Size = New System.Drawing.Size(102, 13)
        Me.Label_DaysOverDue.TabIndex = 34
        Me.Label_DaysOverDue.Text = "Total Days Overdue"
        '
        'TextBox_DaysOverDue
        '
        Me.TextBox_DaysOverDue.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_DaysOverDue.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_DaysOverDue.Name = "TextBox_DaysOverDue"
        Me.TextBox_DaysOverDue.ReadOnly = True
        Me.TextBox_DaysOverDue.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_DaysOverDue.TabIndex = 51
        Me.TextBox_DaysOverDue.Text = "0"
        Me.TextBox_DaysOverDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_FinePerDay
        '
        Me.Label_FinePerDay.AutoSize = True
        Me.Label_FinePerDay.Location = New System.Drawing.Point(132, 15)
        Me.Label_FinePerDay.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_FinePerDay.Name = "Label_FinePerDay"
        Me.Label_FinePerDay.Size = New System.Drawing.Size(51, 13)
        Me.Label_FinePerDay.TabIndex = 36
        Me.Label_FinePerDay.Text = "Fine/Day"
        '
        'NumericUpDown_FinePerDay
        '
        Me.NumericUpDown_FinePerDay.DecimalPlaces = 2
        Me.NumericUpDown_FinePerDay.Location = New System.Drawing.Point(132, 38)
        Me.NumericUpDown_FinePerDay.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericUpDown_FinePerDay.Name = "NumericUpDown_FinePerDay"
        Me.NumericUpDown_FinePerDay.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown_FinePerDay.TabIndex = 37
        Me.NumericUpDown_FinePerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_FinePerDay.Value = New Decimal(New Integer() {100, 0, 0, 131072})
        '
        'Panel_Confirm
        '
        Me.Panel_Confirm.Controls.Add(Me.Label_TotalFines)
        Me.Panel_Confirm.Controls.Add(Me.TextBox_TotalFines)
        Me.Panel_Confirm.Controls.Add(Me.Button_Return)
        Me.Panel_Confirm.Controls.Add(Me.Button_Clear)
        Me.Panel_Confirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Confirm.Location = New System.Drawing.Point(542, 0)
        Me.Panel_Confirm.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Confirm.Name = "Panel_Confirm"
        Me.Panel_Confirm.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Confirm.Size = New System.Drawing.Size(274, 164)
        Me.Panel_Confirm.TabIndex = 3
        '
        'Label_TotalFines
        '
        Me.Label_TotalFines.AutoSize = True
        Me.Label_TotalFines.Location = New System.Drawing.Point(15, 15)
        Me.Label_TotalFines.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_TotalFines.Name = "Label_TotalFines"
        Me.Label_TotalFines.Size = New System.Drawing.Size(59, 13)
        Me.Label_TotalFines.TabIndex = 38
        Me.Label_TotalFines.Text = "Total Fines"
        '
        'TextBox_TotalFines
        '
        Me.TextBox_TotalFines.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_TotalFines.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_TotalFines.Name = "TextBox_TotalFines"
        Me.TextBox_TotalFines.ReadOnly = True
        Me.TextBox_TotalFines.Size = New System.Drawing.Size(75, 20)
        Me.TextBox_TotalFines.TabIndex = 50
        Me.TextBox_TotalFines.Text = "0.00"
        Me.TextBox_TotalFines.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button_Return
        '
        Me.Button_Return.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Return.Location = New System.Drawing.Point(99, 126)
        Me.Button_Return.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Return.Name = "Button_Return"
        Me.Button_Return.Size = New System.Drawing.Size(75, 23)
        Me.Button_Return.TabIndex = 5
        Me.Button_Return.Text = "Return"
        Me.Button_Return.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Clear.Location = New System.Drawing.Point(184, 126)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 49
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'UserControl_ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel_CheckoutDetails)
        Me.Name = "UserControl_ReturnBook"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.Panel_Copies.ResumeLayout(False)
        Me.Panel_Copies.PerformLayout()
        Me.TableLayoutPanel_CheckoutDetails.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.PerformLayout()
        Me.TableLayoutPanel_Return.ResumeLayout(False)
        Me.TableLayoutPanel_Return.PerformLayout()
        Me.Panel_Copy.ResumeLayout(False)
        Me.Panel_Copy.PerformLayout()
        Me.Panel_Fine.ResumeLayout(False)
        Me.Panel_Fine.PerformLayout()
        CType(Me.NumericUpDown_FinePerDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Confirm.ResumeLayout(False)
        Me.Panel_Confirm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_Panel_Copies As Label
    Friend WithEvents Panel_Copies As Panel
    Friend WithEvents TableLayoutPanel_CheckoutDetails As TableLayoutPanel
    Friend WithEvents ListView_Copies As ListView
    Friend WithEvents Copies_CopyID As ColumnHeader
    Friend WithEvents Copies_ChkID As ColumnHeader
    Friend WithEvents Copies_IssueDate As ColumnHeader
    Friend WithEvents Copies_DueDate As ColumnHeader
    Friend WithEvents Copies_BookID As ColumnHeader
    Friend WithEvents Copies_Title As ColumnHeader
    Friend WithEvents Copies_Fines As ColumnHeader
    Friend WithEvents TableLayoutPanel_Return As TableLayoutPanel
    Friend WithEvents Panel_Copy As Panel
    Friend WithEvents Label_Copy As Label
    Friend WithEvents TextBox_CopyID As TextBox
    Friend WithEvents Label_Copy_Message As Label
    Friend WithEvents Button_Add As Button
    Friend WithEvents Panel_Fine As Panel
    Friend WithEvents Label_DaysOverDue As Label
    Friend WithEvents TextBox_DaysOverDue As TextBox
    Friend WithEvents Label_FinePerDay As Label
    Friend WithEvents NumericUpDown_FinePerDay As NumericUpDown
    Friend WithEvents Panel_Confirm As Panel
    Friend WithEvents Label_TotalFines As Label
    Friend WithEvents TextBox_TotalFines As TextBox
    Friend WithEvents Button_Return As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Copies_DaysOverdue As ColumnHeader
End Class
