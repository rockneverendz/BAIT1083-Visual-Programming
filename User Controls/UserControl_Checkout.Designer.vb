<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Checkout
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
        Me.SplitContainer_Checkout = New System.Windows.Forms.SplitContainer()
        Me.TextBox_PatronID = New System.Windows.Forms.TextBox()
        Me.Label_Patron = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_CheckoutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Current = New System.Windows.Forms.Panel()
        Me.ListView_Current = New System.Windows.Forms.ListView()
        Me.Label_Current = New System.Windows.Forms.Label()
        Me.Panel_New = New System.Windows.Forms.Panel()
        Me.ListView_New = New System.Windows.Forms.ListView()
        Me.Label_New = New System.Windows.Forms.Label()
        Me.Panel_Confirmation = New System.Windows.Forms.Panel()
        Me.Label_Weeks = New System.Windows.Forms.Label()
        Me.NumericUpDown_Weeks = New System.Windows.Forms.NumericUpDown()
        Me.Button_Confirm = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Label_DueDate = New System.Windows.Forms.Label()
        Me.DateTimePicker_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_Duration = New System.Windows.Forms.Label()
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Checkout.Panel1.SuspendLayout()
        Me.SplitContainer_Checkout.Panel2.SuspendLayout()
        Me.SplitContainer_Checkout.SuspendLayout()
        Me.TableLayoutPanel_CheckoutDetails.SuspendLayout()
        Me.Panel_Current.SuspendLayout()
        Me.Panel_New.SuspendLayout()
        Me.Panel_Confirmation.SuspendLayout()
        CType(Me.NumericUpDown_Weeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.TextBox_PatronID)
        Me.SplitContainer_Checkout.Panel1.Controls.Add(Me.Label_Patron)
        Me.SplitContainer_Checkout.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer_Checkout.Panel2
        '
        Me.SplitContainer_Checkout.Panel2.Controls.Add(Me.TableLayoutPanel_CheckoutDetails)
        Me.SplitContainer_Checkout.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.SplitterDistance = 272
        Me.SplitContainer_Checkout.TabIndex = 0
        '
        'TextBox_PatronID
        '
        Me.TextBox_PatronID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_PatronID.Location = New System.Drawing.Point(15, 38)
        Me.TextBox_PatronID.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_PatronID.Name = "TextBox_PatronID"
        Me.TextBox_PatronID.Size = New System.Drawing.Size(242, 20)
        Me.TextBox_PatronID.TabIndex = 1
        '
        'Label_Patron
        '
        Me.Label_Patron.AutoSize = True
        Me.Label_Patron.Location = New System.Drawing.Point(15, 15)
        Me.Label_Patron.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Patron.Name = "Label_Patron"
        Me.Label_Patron.Size = New System.Drawing.Size(52, 13)
        Me.Label_Patron.TabIndex = 0
        Me.Label_Patron.Text = "Patron ID"
        '
        'TableLayoutPanel_CheckoutDetails
        '
        Me.TableLayoutPanel_CheckoutDetails.ColumnCount = 1
        Me.TableLayoutPanel_CheckoutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Current, 0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_New, 0, 1)
        Me.TableLayoutPanel_CheckoutDetails.Controls.Add(Me.Panel_Confirmation, 0, 2)
        Me.TableLayoutPanel_CheckoutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_CheckoutDetails.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_CheckoutDetails.Name = "TableLayoutPanel_CheckoutDetails"
        Me.TableLayoutPanel_CheckoutDetails.RowCount = 3
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_CheckoutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel_CheckoutDetails.Size = New System.Drawing.Size(540, 490)
        Me.TableLayoutPanel_CheckoutDetails.TabIndex = 0
        '
        'Panel_Current
        '
        Me.Panel_Current.AutoSize = True
        Me.Panel_Current.Controls.Add(Me.ListView_Current)
        Me.Panel_Current.Controls.Add(Me.Label_Current)
        Me.Panel_Current.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Current.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Current.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Current.Name = "Panel_Current"
        Me.Panel_Current.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Current.Size = New System.Drawing.Size(540, 163)
        Me.Panel_Current.TabIndex = 0
        '
        'ListView_Current
        '
        Me.ListView_Current.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Current.HideSelection = False
        Me.ListView_Current.Location = New System.Drawing.Point(15, 38)
        Me.ListView_Current.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_Current.Name = "ListView_Current"
        Me.ListView_Current.Size = New System.Drawing.Size(510, 110)
        Me.ListView_Current.TabIndex = 3
        Me.ListView_Current.UseCompatibleStateImageBehavior = False
        '
        'Label_Current
        '
        Me.Label_Current.AutoSize = True
        Me.Label_Current.Location = New System.Drawing.Point(15, 15)
        Me.Label_Current.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Current.Name = "Label_Current"
        Me.Label_Current.Size = New System.Drawing.Size(123, 13)
        Me.Label_Current.TabIndex = 2
        Me.Label_Current.Text = "Parton Current Borrowed"
        '
        'Panel_New
        '
        Me.Panel_New.AutoSize = True
        Me.Panel_New.Controls.Add(Me.ListView_New)
        Me.Panel_New.Controls.Add(Me.Label_New)
        Me.Panel_New.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_New.Location = New System.Drawing.Point(0, 163)
        Me.Panel_New.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_New.Name = "Panel_New"
        Me.Panel_New.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_New.Size = New System.Drawing.Size(540, 163)
        Me.Panel_New.TabIndex = 1
        '
        'ListView_New
        '
        Me.ListView_New.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_New.HideSelection = False
        Me.ListView_New.Location = New System.Drawing.Point(15, 38)
        Me.ListView_New.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView_New.Name = "ListView_New"
        Me.ListView_New.Size = New System.Drawing.Size(510, 110)
        Me.ListView_New.TabIndex = 4
        Me.ListView_New.UseCompatibleStateImageBehavior = False
        '
        'Label_New
        '
        Me.Label_New.AutoSize = True
        Me.Label_New.Location = New System.Drawing.Point(15, 15)
        Me.Label_New.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_New.Name = "Label_New"
        Me.Label_New.Size = New System.Drawing.Size(62, 13)
        Me.Label_New.TabIndex = 3
        Me.Label_New.Text = "Borrow Cart"
        '
        'Panel_Confirmation
        '
        Me.Panel_Confirmation.AutoSize = True
        Me.Panel_Confirmation.Controls.Add(Me.Label_Weeks)
        Me.Panel_Confirmation.Controls.Add(Me.NumericUpDown_Weeks)
        Me.Panel_Confirmation.Controls.Add(Me.Button_Confirm)
        Me.Panel_Confirmation.Controls.Add(Me.Button_Clear)
        Me.Panel_Confirmation.Controls.Add(Me.Label_DueDate)
        Me.Panel_Confirmation.Controls.Add(Me.DateTimePicker_DueDate)
        Me.Panel_Confirmation.Controls.Add(Me.Label_Duration)
        Me.Panel_Confirmation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Confirmation.Location = New System.Drawing.Point(0, 326)
        Me.Panel_Confirmation.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Confirmation.Name = "Panel_Confirmation"
        Me.Panel_Confirmation.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel_Confirmation.Size = New System.Drawing.Size(540, 164)
        Me.Panel_Confirmation.TabIndex = 2
        '
        'Label_Weeks
        '
        Me.Label_Weeks.AutoSize = True
        Me.Label_Weeks.Location = New System.Drawing.Point(62, 40)
        Me.Label_Weeks.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Weeks.Name = "Label_Weeks"
        Me.Label_Weeks.Size = New System.Drawing.Size(47, 13)
        Me.Label_Weeks.TabIndex = 7
        Me.Label_Weeks.Text = "Week(s)"
        '
        'NumericUpDown_Weeks
        '
        Me.NumericUpDown_Weeks.Location = New System.Drawing.Point(15, 38)
        Me.NumericUpDown_Weeks.Margin = New System.Windows.Forms.Padding(5)
        Me.NumericUpDown_Weeks.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown_Weeks.Name = "NumericUpDown_Weeks"
        Me.NumericUpDown_Weeks.Size = New System.Drawing.Size(37, 20)
        Me.NumericUpDown_Weeks.TabIndex = 6
        Me.NumericUpDown_Weeks.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Button_Confirm
        '
        Me.Button_Confirm.Location = New System.Drawing.Point(365, 126)
        Me.Button_Confirm.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Confirm.Name = "Button_Confirm"
        Me.Button_Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Button_Confirm.TabIndex = 5
        Me.Button_Confirm.Text = "Borrow"
        Me.Button_Confirm.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(450, 126)
        Me.Button_Clear.Margin = New System.Windows.Forms.Padding(5)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 4
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Label_DueDate
        '
        Me.Label_DueDate.AutoSize = True
        Me.Label_DueDate.Location = New System.Drawing.Point(173, 15)
        Me.Label_DueDate.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_DueDate.Name = "Label_DueDate"
        Me.Label_DueDate.Size = New System.Drawing.Size(53, 13)
        Me.Label_DueDate.TabIndex = 3
        Me.Label_DueDate.Text = "Due Date"
        '
        'DateTimePicker_DueDate
        '
        Me.DateTimePicker_DueDate.Location = New System.Drawing.Point(176, 38)
        Me.DateTimePicker_DueDate.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker_DueDate.MinDate = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.DateTimePicker_DueDate.Name = "DateTimePicker_DueDate"
        Me.DateTimePicker_DueDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_DueDate.TabIndex = 1
        Me.DateTimePicker_DueDate.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'Label_Duration
        '
        Me.Label_Duration.AutoSize = True
        Me.Label_Duration.Location = New System.Drawing.Point(15, 15)
        Me.Label_Duration.Margin = New System.Windows.Forms.Padding(5)
        Me.Label_Duration.Name = "Label_Duration"
        Me.Label_Duration.Size = New System.Drawing.Size(83, 13)
        Me.Label_Duration.TabIndex = 0
        Me.Label_Duration.Text = "Borrow Duration"
        '
        'UserControl_Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer_Checkout)
        Me.Name = "UserControl_Checkout"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.SplitContainer_Checkout.Panel1.ResumeLayout(False)
        Me.SplitContainer_Checkout.Panel1.PerformLayout()
        Me.SplitContainer_Checkout.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Checkout.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.ResumeLayout(False)
        Me.TableLayoutPanel_CheckoutDetails.PerformLayout()
        Me.Panel_Current.ResumeLayout(False)
        Me.Panel_Current.PerformLayout()
        Me.Panel_New.ResumeLayout(False)
        Me.Panel_New.PerformLayout()
        Me.Panel_Confirmation.ResumeLayout(False)
        Me.Panel_Confirmation.PerformLayout()
        CType(Me.NumericUpDown_Weeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer_Checkout As SplitContainer
    Friend WithEvents TextBox_PatronID As TextBox
    Friend WithEvents Label_Patron As Label
    Friend WithEvents Label_Current As Label
    Friend WithEvents TableLayoutPanel_CheckoutDetails As TableLayoutPanel
    Friend WithEvents Panel_Current As Panel
    Friend WithEvents Panel_New As Panel
    Friend WithEvents Panel_Confirmation As Panel
    Friend WithEvents Label_Duration As Label
    Friend WithEvents Label_New As Label
    Friend WithEvents ListView_Current As ListView
    Friend WithEvents ListView_New As ListView
    Friend WithEvents DateTimePicker_DueDate As DateTimePicker
    Friend WithEvents Label_DueDate As Label
    Friend WithEvents Label_Weeks As Label
    Friend WithEvents NumericUpDown_Weeks As NumericUpDown
    Friend WithEvents Button_Confirm As Button
    Friend WithEvents Button_Clear As Button
End Class
