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
        Me.Label_Panel_Fines = New System.Windows.Forms.Label()
        Me.Panel_Fines = New System.Windows.Forms.Panel()
        Me.DataGridView_Fines = New System.Windows.Forms.DataGridView()
        Me.Label_Panel_Copies = New System.Windows.Forms.Label()
        Me.Panel_Copies = New System.Windows.Forms.Panel()
        Me.ListView_Copies = New System.Windows.Forms.ListView()
        Me.Book_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Issue_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Due_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Daily_Late_Fee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Owing = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel_CheckoutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer_Checkout = New System.Windows.Forms.SplitContainer()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Lebel_Message = New System.Windows.Forms.Label()
        Me.Button_Return = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Panel_Fines.SuspendLayout()
        CType(Me.DataGridView_Fines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Copies.SuspendLayout()
        Me.TableLayoutPanel_CheckoutDetails.SuspendLayout()
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Checkout.Panel1.SuspendLayout()
        Me.SplitContainer_Checkout.Panel2.SuspendLayout()
        Me.SplitContainer_Checkout.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Panel_Fines
        '
        Me.Label_Panel_Fines.AutoSize = True
        Me.Label_Panel_Fines.Location = New System.Drawing.Point(15, 15)
        Me.Label_Panel_Fines.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Panel_Fines.Name = "Label_Panel_Fines"
        Me.Label_Panel_Fines.Size = New System.Drawing.Size(32, 13)
        Me.Label_Panel_Fines.TabIndex = 3
        Me.Label_Panel_Fines.Text = "Fines"
        '
        'Panel_Fines
        '
        Me.Panel_Fines.AutoSize = True
        Me.Panel_Fines.Controls.Add(Me.Label_Panel_Fines)
        Me.Panel_Fines.Controls.Add(Me.DataGridView_Fines)
        Me.Panel_Fines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Fines.Location = New System.Drawing.Point(0, 245)
        Me.Panel_Fines.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Fines.Name = "Panel_Fines"
        Me.Panel_Fines.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Fines.Size = New System.Drawing.Size(540, 245)
        Me.Panel_Fines.TabIndex = 1
        '
        'DataGridView_Fines
        '
        Me.DataGridView_Fines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Fines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Fines.Location = New System.Drawing.Point(15, 38)
        Me.DataGridView_Fines.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView_Fines.Name = "DataGridView_Fines"
        Me.DataGridView_Fines.Size = New System.Drawing.Size(510, 192)
        Me.DataGridView_Fines.TabIndex = 21
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
        Me.Panel_Copies.Controls.Add(Me.ListView_Copies)
        Me.Panel_Copies.Controls.Add(Me.Label_Panel_Copies)
        Me.Panel_Copies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Copies.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Copies.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Copies.Name = "Panel_Copies"
        Me.Panel_Copies.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Copies.Size = New System.Drawing.Size(540, 245)
        Me.Panel_Copies.TabIndex = 0
        '
        'ListView_Copies
        '
        Me.ListView_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Copies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Book_Id, Me.Issue_Date, Me.Due_Date, Me.Daily_Late_Fee, Me.Owing})
        Me.ListView_Copies.HideSelection = False
        Me.ListView_Copies.Location = New System.Drawing.Point(15, 38)
        Me.ListView_Copies.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_Copies.Name = "ListView_Copies"
        Me.ListView_Copies.Size = New System.Drawing.Size(510, 192)
        Me.ListView_Copies.TabIndex = 13
        Me.ListView_Copies.UseCompatibleStateImageBehavior = False
        Me.ListView_Copies.View = System.Windows.Forms.View.Details
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
        'TableLayoutPanel_CheckoutDetails
        '
        Me.TableLayoutPanel_CheckoutDetails.ColumnCount = 1
        Me.TableLayoutPanel_CheckoutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Copies, 0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Fines, 0, 1)
        Me.TableLayoutPanel_CheckoutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CheckoutDetails.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Name = "TableLayoutPanel_CheckoutDetails"
        Me.TableLayoutPanel_CheckoutDetails.RowCount = 2
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_CheckoutDetails.Size = New System.Drawing.Size(540, 490)
        Me.TableLayoutPanel_CheckoutDetails.TabIndex = 0
        '
        'SplitContainer_Checkout
        '
        Me.SplitContainer_Checkout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Checkout.IsSplitterFixed = True
        Me.SplitContainer_Checkout.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Checkout.Name = "SplitContainer_Checkout"
        '
        'SplitContainer_Checkout.Panel1
        '
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_ID)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_ID)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Add)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Lebel_Message)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Return)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Button_Clear)
        Me.SplitContainer_Checkout.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer_Checkout.Panel2
        '
        Me.SplitContainer_Checkout.Panel2.Controls.Add(Me.TableLayoutPanel_CheckoutDetails)
        Me.SplitContainer_Checkout.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.SplitterDistance = 272
        Me.SplitContainer_Checkout.TabIndex = 51
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(15, 15)
        Me.Label_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(45, 13)
        Me.Label_ID.TabIndex = 33
        Me.Label_ID.Text = "Copy ID"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(242, 20)
        Me.TextBox_ID.TabIndex = 34
        '
        'Button_Add
        '
        Me.Button_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Add.Location = New System.Drawing.Point(182, 68)
        Me.Button_Add.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 50
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Lebel_Message
        '
        Me.Lebel_Message.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lebel_Message.ForeColor = System.Drawing.Color.Red
        Me.Lebel_Message.Location = New System.Drawing.Point(97, 429)
        Me.Lebel_Message.Margin = New System.Windows.Forms.Padding(5)
        Me.Lebel_Message.Name = "Lebel_Message"
        Me.Lebel_Message.Size = New System.Drawing.Size(160, 13)
        Me.Lebel_Message.TabIndex = 51
        Me.Lebel_Message.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button_Return
        '
        Me.Button_Return.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Return.Location = New System.Drawing.Point(97, 452)
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
        Me.Button_Clear.Location = New System.Drawing.Point(182, 452)
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
        Me.Controls.Add(Me.SplitContainer_Checkout)
        Me.Name = "UserControl_ReturnBook"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.Panel_Fines.ResumeLayout(False)
        Me.Panel_Fines.PerformLayout()
        CType(Me.DataGridView_Fines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Copies.ResumeLayout(False)
        Me.Panel_Copies.PerformLayout()
        Me.TableLayoutPanel_CheckoutDetails.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.PerformLayout()
        Me.SplitContainer_Checkout.Panel1.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel1.PerformLayout()
        Me.SplitContainer_Checkout.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Checkout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_Panel_Fines As Label
    Friend WithEvents Panel_Fines As Panel
    Friend WithEvents Label_Panel_Copies As Label
    Friend WithEvents Panel_Copies As Panel
    Friend WithEvents TableLayoutPanel_CheckoutDetails As TableLayoutPanel
    Friend WithEvents SplitContainer_Checkout As SplitContainer
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Button_Return As Button
    Friend WithEvents Button_Clear As Button
    Friend WithEvents ListView_Copies As ListView
    Friend WithEvents Book_Id As ColumnHeader
    Friend WithEvents Issue_Date As ColumnHeader
    Friend WithEvents Due_Date As ColumnHeader
    Friend WithEvents Daily_Late_Fee As ColumnHeader
    Friend WithEvents Owing As ColumnHeader
    Friend WithEvents DataGridView_Fines As DataGridView
    Friend WithEvents Button_Add As Button
    Friend WithEvents Lebel_Message As Label
End Class
