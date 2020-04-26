<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_PatronInsightReport
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
		Me.components = New System.ComponentModel.Container()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lblChartTitle = New System.Windows.Forms.Label()
		Me.lstPatronList = New System.Windows.Forms.ListView()
		Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colCourse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colHpnum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.colEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.dgvPatronList = New System.Windows.Forms.DataGridView()
		Me.dgvCol1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvCol2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvCol3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvCol4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvCol5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.dgvCol6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.panForPrintHeader = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.lblPrintedBy = New System.Windows.Forms.Label()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.lblDateNow = New System.Windows.Forms.Label()
		Me.lblPrint = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.easyRpt = New KimToo.EasyHTMLReports(Me.components)
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.dgvPatronList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.panForPrintHeader.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.White
		Me.Panel1.Controls.Add(Me.lblChartTitle)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1067, 60)
		Me.Panel1.TabIndex = 0
		'
		'lblChartTitle
		'
		Me.lblChartTitle.AutoSize = True
		Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChartTitle.Location = New System.Drawing.Point(402, 14)
		Me.lblChartTitle.Name = "lblChartTitle"
		Me.lblChartTitle.Size = New System.Drawing.Size(262, 32)
		Me.lblChartTitle.TabIndex = 1
		Me.lblChartTitle.Text = "Patron Insight Report"
		'
		'lstPatronList
		'
		Me.lstPatronList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colId, Me.colName, Me.colCourse, Me.colHpnum, Me.colAddress, Me.colEmail})
		Me.lstPatronList.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstPatronList.HideSelection = False
		Me.lstPatronList.Location = New System.Drawing.Point(0, 0)
		Me.lstPatronList.Name = "lstPatronList"
		Me.lstPatronList.Size = New System.Drawing.Size(1067, 390)
		Me.lstPatronList.TabIndex = 1
		Me.lstPatronList.UseCompatibleStateImageBehavior = False
		Me.lstPatronList.View = System.Windows.Forms.View.Details
		'
		'colId
		'
		Me.colId.Text = "ID"
		'
		'colName
		'
		Me.colName.Text = "Name"
		Me.colName.Width = 100
		'
		'colCourse
		'
		Me.colCourse.Text = "Course"
		Me.colCourse.Width = 100
		'
		'colHpnum
		'
		Me.colHpnum.Text = "Phone Number"
		Me.colHpnum.Width = 100
		'
		'colAddress
		'
		Me.colAddress.Text = "Address"
		Me.colAddress.Width = 250
		'
		'colEmail
		'
		Me.colEmail.Text = "Email"
		Me.colEmail.Width = 200
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.lstPatronList)
		Me.Panel2.Controls.Add(Me.dgvPatronList)
		Me.Panel2.Controls.Add(Me.Panel3)
		Me.Panel2.Controls.Add(Me.panForPrintHeader)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 60)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1067, 463)
		Me.Panel2.TabIndex = 2
		'
		'dgvPatronList
		'
		Me.dgvPatronList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvPatronList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvCol1, Me.dgvCol2, Me.dgvCol3, Me.dgvCol4, Me.dgvCol5, Me.dgvCol6})
		Me.dgvPatronList.Location = New System.Drawing.Point(117, 54)
		Me.dgvPatronList.Name = "dgvPatronList"
		Me.dgvPatronList.RowHeadersWidth = 51
		Me.dgvPatronList.RowTemplate.Height = 24
		Me.dgvPatronList.Size = New System.Drawing.Size(728, 279)
		Me.dgvPatronList.TabIndex = 4
		'
		'dgvCol1
		'
		Me.dgvCol1.HeaderText = "ID"
		Me.dgvCol1.MinimumWidth = 6
		Me.dgvCol1.Name = "dgvCol1"
		Me.dgvCol1.Width = 125
		'
		'dgvCol2
		'
		Me.dgvCol2.HeaderText = "Name"
		Me.dgvCol2.MinimumWidth = 6
		Me.dgvCol2.Name = "dgvCol2"
		Me.dgvCol2.Width = 125
		'
		'dgvCol3
		'
		Me.dgvCol3.HeaderText = "Course"
		Me.dgvCol3.MinimumWidth = 6
		Me.dgvCol3.Name = "dgvCol3"
		Me.dgvCol3.Width = 125
		'
		'dgvCol4
		'
		Me.dgvCol4.HeaderText = "Phone Number"
		Me.dgvCol4.MinimumWidth = 6
		Me.dgvCol4.Name = "dgvCol4"
		Me.dgvCol4.Width = 125
		'
		'dgvCol5
		'
		Me.dgvCol5.HeaderText = "Address"
		Me.dgvCol5.MinimumWidth = 6
		Me.dgvCol5.Name = "dgvCol5"
		Me.dgvCol5.Width = 125
		'
		'dgvCol6
		'
		Me.dgvCol6.HeaderText = "Email"
		Me.dgvCol6.MinimumWidth = 6
		Me.dgvCol6.Name = "dgvCol6"
		Me.dgvCol6.Width = 125
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 390)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(1067, 73)
		Me.Panel3.TabIndex = 2
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(925, 17)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(118, 37)
		Me.btnPrint.TabIndex = 1
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'panForPrintHeader
		'
		Me.panForPrintHeader.BackColor = System.Drawing.Color.White
		Me.panForPrintHeader.Controls.Add(Me.PictureBox1)
		Me.panForPrintHeader.Controls.Add(Me.lblPrintedBy)
		Me.panForPrintHeader.Controls.Add(Me.lbl3)
		Me.panForPrintHeader.Controls.Add(Me.lblDateNow)
		Me.panForPrintHeader.Controls.Add(Me.lblPrint)
		Me.panForPrintHeader.Controls.Add(Me.Label2)
		Me.panForPrintHeader.Location = New System.Drawing.Point(3, 231)
		Me.panForPrintHeader.Name = "panForPrintHeader"
		Me.panForPrintHeader.Size = New System.Drawing.Size(784, 153)
		Me.panForPrintHeader.TabIndex = 3
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.BAIT1083_Visual_Programming.My.Resources.Resources.circle_cropped
		Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(155, 146)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 5
		Me.PictureBox1.TabStop = False
		'
		'lblPrintedBy
		'
		Me.lblPrintedBy.BackColor = System.Drawing.Color.Transparent
		Me.lblPrintedBy.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrintedBy.Location = New System.Drawing.Point(274, 102)
		Me.lblPrintedBy.Name = "lblPrintedBy"
		Me.lblPrintedBy.Size = New System.Drawing.Size(113, 23)
		Me.lblPrintedBy.TabIndex = 4
		'
		'lbl3
		'
		Me.lbl3.BackColor = System.Drawing.Color.Transparent
		Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3.Location = New System.Drawing.Point(182, 102)
		Me.lbl3.Name = "lbl3"
		Me.lbl3.Size = New System.Drawing.Size(84, 23)
		Me.lbl3.TabIndex = 3
		Me.lbl3.Text = "Printed by:"
		'
		'lblDateNow
		'
		Me.lblDateNow.BackColor = System.Drawing.Color.Transparent
		Me.lblDateNow.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDateNow.Location = New System.Drawing.Point(274, 79)
		Me.lblDateNow.Name = "lblDateNow"
		Me.lblDateNow.Size = New System.Drawing.Size(113, 23)
		Me.lblDateNow.TabIndex = 2
		'
		'lblPrint
		'
		Me.lblPrint.BackColor = System.Drawing.Color.Transparent
		Me.lblPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrint.Location = New System.Drawing.Point(182, 79)
		Me.lblPrint.Name = "lblPrint"
		Me.lblPrint.Size = New System.Drawing.Size(98, 23)
		Me.lblPrint.TabIndex = 1
		Me.lblPrint.Text = "Printed on:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(180, 43)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(262, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Patron Insight Report"
		'
		'easyRpt
		'
		Me.easyRpt.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
		Me.easyRpt.AlternativeRowGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		Me.easyRpt.HeaderBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(197, Byte), Integer))
		Me.easyRpt.HeaderFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
		Me.easyRpt.HeaderGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		Me.easyRpt.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.easyRpt.RowDefaultFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
		Me.easyRpt.RowDefaultGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
		'
		'UserControl_PatronInsightReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "UserControl_PatronInsightReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.dgvPatronList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.panForPrintHeader.ResumeLayout(False)
		Me.panForPrintHeader.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents lblChartTitle As Label
	Friend WithEvents lstPatronList As ListView
	Friend WithEvents Panel2 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents colId As ColumnHeader
	Friend WithEvents colName As ColumnHeader
	Friend WithEvents colCourse As ColumnHeader
	Friend WithEvents colHpnum As ColumnHeader
	Friend WithEvents colAddress As ColumnHeader
	Friend WithEvents colEmail As ColumnHeader
	Friend WithEvents btnPrint As Button
	Friend WithEvents panForPrintHeader As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblPrintedBy As Label
	Friend WithEvents lbl3 As Label
	Friend WithEvents lblDateNow As Label
	Friend WithEvents lblPrint As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents easyRpt As KimToo.EasyHTMLReports
	Friend WithEvents dgvPatronList As DataGridView
	Friend WithEvents dgvCol1 As DataGridViewTextBoxColumn
	Friend WithEvents dgvCol2 As DataGridViewTextBoxColumn
	Friend WithEvents dgvCol3 As DataGridViewTextBoxColumn
	Friend WithEvents dgvCol4 As DataGridViewTextBoxColumn
	Friend WithEvents dgvCol5 As DataGridViewTextBoxColumn
	Friend WithEvents dgvCol6 As DataGridViewTextBoxColumn
End Class
