<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_MostChkOutPatronReport
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
		Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.chartPatronChkOuts = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.lstPatronChkOut = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.panForPrintHeader = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.lblPrintedBy = New System.Windows.Forms.Label()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.lblDateNow = New System.Windows.Forms.Label()
		Me.lblPrint = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.easyRpt = New KimToo.EasyHTMLReports(Me.components)
		Me.dgvForPrint = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.chartPatronChkOuts, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.panForPrintHeader.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvForPrint, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.chartPatronChkOuts)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
		Me.SplitContainer1.Panel1.Controls.Add(Me.panForPrintHeader)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lstPatronChkOut)
		Me.SplitContainer1.Panel2.Controls.Add(Me.dgvForPrint)
		Me.SplitContainer1.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.SplitterDistance = 751
		Me.SplitContainer1.TabIndex = 0
		'
		'chartPatronChkOuts
		'
		ChartArea3.AxisX.Title = "Patron Name"
		ChartArea3.AxisY.Title = "Count"
		ChartArea3.BackColor = System.Drawing.Color.PaleTurquoise
		ChartArea3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
		ChartArea3.Name = "ChartArea1"
		Me.chartPatronChkOuts.ChartAreas.Add(ChartArea3)
		Me.chartPatronChkOuts.Dock = System.Windows.Forms.DockStyle.Fill
		Legend3.Name = "Legend1"
		Me.chartPatronChkOuts.Legends.Add(Legend3)
		Me.chartPatronChkOuts.Location = New System.Drawing.Point(0, 61)
		Me.chartPatronChkOuts.Name = "chartPatronChkOuts"
		Series3.ChartArea = "ChartArea1"
		Series3.Legend = "Legend1"
		Series3.Name = "Count"
		Me.chartPatronChkOuts.Series.Add(Series3)
		Me.chartPatronChkOuts.Size = New System.Drawing.Size(751, 462)
		Me.chartPatronChkOuts.TabIndex = 4
		Me.chartPatronChkOuts.Text = "chartPatronChkOut"
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.White
		Me.Panel4.Controls.Add(Me.Label1)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(751, 61)
		Me.Panel4.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(209, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(332, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Patron with most checkouts"
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.lblSelectDate)
		Me.Panel3.Controls.Add(Me.dtpSelectDate)
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 405)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(312, 118)
		Me.Panel3.TabIndex = 4
		'
		'lblSelectDate
		'
		Me.lblSelectDate.AutoSize = True
		Me.lblSelectDate.Location = New System.Drawing.Point(11, 15)
		Me.lblSelectDate.Name = "lblSelectDate"
		Me.lblSelectDate.Size = New System.Drawing.Size(83, 17)
		Me.lblSelectDate.TabIndex = 2
		Me.lblSelectDate.Text = "Select date:"
		'
		'dtpSelectDate
		'
		Me.dtpSelectDate.CustomFormat = "MM/yyyy"
		Me.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpSelectDate.Location = New System.Drawing.Point(14, 35)
		Me.dtpSelectDate.Name = "dtpSelectDate"
		Me.dtpSelectDate.Size = New System.Drawing.Size(246, 22)
		Me.dtpSelectDate.TabIndex = 1
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(94, 68)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(118, 37)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'lstPatronChkOut
		'
		Me.lstPatronChkOut.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
		Me.lstPatronChkOut.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstPatronChkOut.HideSelection = False
		Me.lstPatronChkOut.Location = New System.Drawing.Point(0, 0)
		Me.lstPatronChkOut.Name = "lstPatronChkOut"
		Me.lstPatronChkOut.Size = New System.Drawing.Size(312, 523)
		Me.lstPatronChkOut.TabIndex = 0
		Me.lstPatronChkOut.UseCompatibleStateImageBehavior = False
		Me.lstPatronChkOut.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "No."
		Me.ColumnHeader1.Width = 36
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Patron Name"
		Me.ColumnHeader2.Width = 136
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "Total Checkouts"
		Me.ColumnHeader3.Width = 118
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
		Me.panForPrintHeader.Location = New System.Drawing.Point(3, 367)
		Me.panForPrintHeader.Name = "panForPrintHeader"
		Me.panForPrintHeader.Size = New System.Drawing.Size(748, 153)
		Me.panForPrintHeader.TabIndex = 5
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
		Me.lblPrintedBy.Location = New System.Drawing.Point(274, 106)
		Me.lblPrintedBy.Name = "lblPrintedBy"
		Me.lblPrintedBy.Size = New System.Drawing.Size(111, 21)
		Me.lblPrintedBy.TabIndex = 4
		'
		'lbl3
		'
		Me.lbl3.BackColor = System.Drawing.Color.Transparent
		Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl3.Location = New System.Drawing.Point(182, 106)
		Me.lbl3.Name = "lbl3"
		Me.lbl3.Size = New System.Drawing.Size(86, 21)
		Me.lbl3.TabIndex = 3
		Me.lbl3.Text = "Printed by:"
		'
		'lblDateNow
		'
		Me.lblDateNow.BackColor = System.Drawing.Color.Transparent
		Me.lblDateNow.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDateNow.Location = New System.Drawing.Point(274, 81)
		Me.lblDateNow.Name = "lblDateNow"
		Me.lblDateNow.Size = New System.Drawing.Size(111, 21)
		Me.lblDateNow.TabIndex = 2
		'
		'lblPrint
		'
		Me.lblPrint.BackColor = System.Drawing.Color.Transparent
		Me.lblPrint.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrint.Location = New System.Drawing.Point(182, 81)
		Me.lblPrint.Name = "lblPrint"
		Me.lblPrint.Size = New System.Drawing.Size(86, 21)
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
		Me.Label2.Size = New System.Drawing.Size(217, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Checkouts Report"
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
		'dgvForPrint
		'
		Me.dgvForPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvForPrint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
		Me.dgvForPrint.Location = New System.Drawing.Point(3, 42)
		Me.dgvForPrint.Name = "dgvForPrint"
		Me.dgvForPrint.RowHeadersWidth = 51
		Me.dgvForPrint.RowTemplate.Height = 24
		Me.dgvForPrint.Size = New System.Drawing.Size(292, 229)
		Me.dgvForPrint.TabIndex = 5
		'
		'Column1
		'
		Me.Column1.HeaderText = "No."
		Me.Column1.MinimumWidth = 6
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 125
		'
		'Column2
		'
		Me.Column2.HeaderText = "Patron Name"
		Me.Column2.MinimumWidth = 6
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 125
		'
		'Column3
		'
		Me.Column3.HeaderText = "Total Checkouts"
		Me.Column3.MinimumWidth = 6
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 125
		'
		'UserControl_MostChkOutPatronReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "UserControl_MostChkOutPatronReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.chartPatronChkOuts, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.panForPrintHeader.ResumeLayout(False)
		Me.panForPrintHeader.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvForPrint, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents chartPatronChkOuts As DataVisualization.Charting.Chart
	Friend WithEvents lstPatronChkOut As ListView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents lblSelectDate As Label
	Friend WithEvents dtpSelectDate As DateTimePicker
	Friend WithEvents btnPrint As Button
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents ColumnHeader3 As ColumnHeader
	Friend WithEvents panForPrintHeader As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblPrintedBy As Label
	Friend WithEvents lbl3 As Label
	Friend WithEvents lblDateNow As Label
	Friend WithEvents lblPrint As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dgvForPrint As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents easyRpt As KimToo.EasyHTMLReports
End Class
