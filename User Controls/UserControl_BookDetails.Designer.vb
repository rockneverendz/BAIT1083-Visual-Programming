<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_BookDetails
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
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_CallNo = New System.Windows.Forms.TextBox()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_CallNo = New System.Windows.Forms.Label()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.TextBox_Copies = New System.Windows.Forms.TextBox()
        Me.Label_Author = New System.Windows.Forms.Label()
        Me.Label_Copies = New System.Windows.Forms.Label()
        Me.TextBox_Author = New System.Windows.Forms.TextBox()
        Me.TextBox_YearPublish = New System.Windows.Forms.TextBox()
        Me.Label_Category = New System.Windows.Forms.Label()
        Me.Label_YearPublish = New System.Windows.Forms.Label()
        Me.TextBox_Category = New System.Windows.Forms.TextBox()
        Me.TextBox_Publication = New System.Windows.Forms.TextBox()
        Me.Label_Publication = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_ID
        '
        Me.Label_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Location = New System.Drawing.Point(367, 132)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(18, 13)
        Me.Label_ID.TabIndex = 33
        Me.Label_ID.Text = "ID"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Cancel.Location = New System.Drawing.Point(423, 337)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 24)
        Me.Button_Cancel.TabIndex = 49
        Me.Button_Cancel.Text = "Cancel"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Location = New System.Drawing.Point(398, 129)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 34
        '
        'TextBox_CallNo
        '
        Me.TextBox_CallNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_CallNo.Location = New System.Drawing.Point(398, 311)
        Me.TextBox_CallNo.Name = "TextBox_CallNo"
        Me.TextBox_CallNo.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_CallNo.TabIndex = 48
        '
        'Label_Title
        '
        Me.Label_Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(358, 158)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(27, 13)
        Me.Label_Title.TabIndex = 35
        Me.Label_Title.Text = "Title"
        '
        'Label_CallNo
        '
        Me.Label_CallNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_CallNo.AutoSize = True
        Me.Label_CallNo.Location = New System.Drawing.Point(343, 314)
        Me.Label_CallNo.Name = "Label_CallNo"
        Me.Label_CallNo.Size = New System.Drawing.Size(42, 13)
        Me.Label_CallNo.TabIndex = 47
        Me.Label_CallNo.Text = "Call no."
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Title.Location = New System.Drawing.Point(398, 155)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Title.TabIndex = 36
        '
        'TextBox_Copies
        '
        Me.TextBox_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Copies.Location = New System.Drawing.Point(398, 285)
        Me.TextBox_Copies.Name = "TextBox_Copies"
        Me.TextBox_Copies.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Copies.TabIndex = 46
        '
        'Label_Author
        '
        Me.Label_Author.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Author.AutoSize = True
        Me.Label_Author.Location = New System.Drawing.Point(347, 184)
        Me.Label_Author.Name = "Label_Author"
        Me.Label_Author.Size = New System.Drawing.Size(38, 13)
        Me.Label_Author.TabIndex = 37
        Me.Label_Author.Text = "Author"
        '
        'Label_Copies
        '
        Me.Label_Copies.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Copies.AutoSize = True
        Me.Label_Copies.Location = New System.Drawing.Point(346, 288)
        Me.Label_Copies.Name = "Label_Copies"
        Me.Label_Copies.Size = New System.Drawing.Size(39, 13)
        Me.Label_Copies.TabIndex = 45
        Me.Label_Copies.Text = "Copies"
        '
        'TextBox_Author
        '
        Me.TextBox_Author.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Author.Location = New System.Drawing.Point(398, 181)
        Me.TextBox_Author.Name = "TextBox_Author"
        Me.TextBox_Author.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Author.TabIndex = 38
        '
        'TextBox_YearPublish
        '
        Me.TextBox_YearPublish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_YearPublish.Location = New System.Drawing.Point(398, 259)
        Me.TextBox_YearPublish.Name = "TextBox_YearPublish"
        Me.TextBox_YearPublish.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_YearPublish.TabIndex = 44
        '
        'Label_Category
        '
        Me.Label_Category.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Category.AutoSize = True
        Me.Label_Category.Location = New System.Drawing.Point(336, 210)
        Me.Label_Category.Name = "Label_Category"
        Me.Label_Category.Size = New System.Drawing.Size(49, 13)
        Me.Label_Category.TabIndex = 39
        Me.Label_Category.Text = "Category"
        '
        'Label_YearPublish
        '
        Me.Label_YearPublish.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_YearPublish.AutoSize = True
        Me.Label_YearPublish.Location = New System.Drawing.Point(319, 262)
        Me.Label_YearPublish.Name = "Label_YearPublish"
        Me.Label_YearPublish.Size = New System.Drawing.Size(66, 13)
        Me.Label_YearPublish.TabIndex = 43
        Me.Label_YearPublish.Text = "Year Publish"
        '
        'TextBox_Category
        '
        Me.TextBox_Category.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Category.Location = New System.Drawing.Point(398, 207)
        Me.TextBox_Category.Name = "TextBox_Category"
        Me.TextBox_Category.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Category.TabIndex = 40
        '
        'TextBox_Publication
        '
        Me.TextBox_Publication.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Publication.Location = New System.Drawing.Point(398, 233)
        Me.TextBox_Publication.Name = "TextBox_Publication"
        Me.TextBox_Publication.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Publication.TabIndex = 42
        '
        'Label_Publication
        '
        Me.Label_Publication.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Publication.AutoSize = True
        Me.Label_Publication.Location = New System.Drawing.Point(326, 236)
        Me.Label_Publication.Name = "Label_Publication"
        Me.Label_Publication.Size = New System.Drawing.Size(59, 13)
        Me.Label_Publication.TabIndex = 41
        Me.Label_Publication.Text = "Publication"
        '
        'UserControl_BookDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.Label_ID)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.TextBox_CallNo)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Label_CallNo)
        Me.Controls.Add(Me.TextBox_Title)
        Me.Controls.Add(Me.TextBox_Copies)
        Me.Controls.Add(Me.Label_Author)
        Me.Controls.Add(Me.Label_Copies)
        Me.Controls.Add(Me.TextBox_Author)
        Me.Controls.Add(Me.TextBox_YearPublish)
        Me.Controls.Add(Me.Label_Category)
        Me.Controls.Add(Me.Label_YearPublish)
        Me.Controls.Add(Me.TextBox_Category)
        Me.Controls.Add(Me.TextBox_Publication)
        Me.Controls.Add(Me.Label_Publication)
        Me.Name = "UserControl_BookDetails"
        Me.Size = New System.Drawing.Size(816, 490)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_ID As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_CallNo As TextBox
    Friend WithEvents Label_Title As Label
    Friend WithEvents Label_CallNo As Label
    Friend WithEvents TextBox_Title As TextBox
    Friend WithEvents TextBox_Copies As TextBox
    Friend WithEvents Label_Author As Label
    Friend WithEvents Label_Copies As Label
    Friend WithEvents TextBox_Author As TextBox
    Friend WithEvents TextBox_YearPublish As TextBox
    Friend WithEvents Label_Category As Label
    Friend WithEvents Label_YearPublish As Label
    Friend WithEvents TextBox_Category As TextBox
    Friend WithEvents TextBox_Publication As TextBox
    Friend WithEvents Label_Publication As Label
End Class
