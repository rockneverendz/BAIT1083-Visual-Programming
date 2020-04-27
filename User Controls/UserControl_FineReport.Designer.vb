<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_FineReport
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
		Me.lstFineReport = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lblTotalFineAmount = New System.Windows.Forms.Label()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.panForPrintHeader = New System.Windows.Forms.Panel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.lblPrintedBy = New System.Windows.Forms.Label()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.lblDateNow = New System.Windows.Forms.Label()
		Me.lblPrint = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dgvFineRpt = New System.Windows.Forms.DataGridView()
		Me.easyRpt = New KimToo.EasyHTMLReports(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Colunm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.panForPrintHeader.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dgvFineRpt, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.Panel1.TabIndex = 1
		'
		'lblChartTitle
		'
		Me.lblChartTitle.AutoSize = True
		Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChartTitle.Location = New System.Drawing.Point(460, 14)
		Me.lblChartTitle.Name = "lblChartTitle"
		Me.lblChartTitle.Size = New System.Drawing.Size(147, 32)
		Me.lblChartTitle.TabIndex = 1
		Me.lblChartTitle.Text = "Fine Report"
		'
		'lstFineReport
		'
		Me.lstFineReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
		Me.lstFineReport.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstFineReport.HideSelection = False
		Me.lstFineReport.Location = New System.Drawing.Point(0, 0)
		Me.lstFineReport.Name = "lstFineReport"
		Me.lstFineReport.Size = New System.Drawing.Size(840, 390)
		Me.lstFineReport.TabIndex = 2
		Me.lstFineReport.UseCompatibleStateImageBehavior = False
		Me.lstFineReport.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "No."
		Me.ColumnHeader1.Width = 48
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Return ID"
		Me.ColumnHeader2.Width = 100
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "Date"
		Me.ColumnHeader3.Width = 160
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Fine Amount"
		Me.ColumnHeader4.Width = 132
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.lblSelectDate)
		Me.Panel3.Controls.Add(Me.dtpSelectDate)
		Me.Panel3.Controls.Add(Me.Label1)
		Me.Panel3.Controls.Add(Me.lblTotalFineAmount)
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 450)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(1067, 73)
		Me.Panel3.TabIndex = 3
		'
		'lblTotalFineAmount
		'
		Me.lblTotalFineAmount.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalFineAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotalFineAmount.Location = New System.Drawing.Point(375, 17)
		Me.lblTotalFineAmount.Name = "lblTotalFineAmount"
		Me.lblTotalFineAmount.Size = New System.Drawing.Size(140, 37)
		Me.lblTotalFineAmount.TabIndex = 2
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
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
		Me.Panel2.Location = New System.Drawing.Point(0, 60)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(108, 390)
		Me.Panel2.TabIndex = 4
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(948, 60)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(119, 390)
		Me.FlowLayoutPanel1.TabIndex = 5
		'
		'Panel4
		'
		Me.Panel4.Controls.Add(Me.lstFineReport)
		Me.Panel4.Controls.Add(Me.panForPrintHeader)
		Me.Panel4.Controls.Add(Me.dgvFineRpt)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel4.Location = New System.Drawing.Point(108, 60)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(840, 390)
		Me.Panel4.TabIndex = 6
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
		Me.panForPrintHeader.Location = New System.Drawing.Point(6, 231)
		Me.panForPrintHeader.Name = "panForPrintHeader"
		Me.panForPrintHeader.Size = New System.Drawing.Size(784, 153)
		Me.panForPrintHeader.TabIndex = 4
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
		Me.Label2.Size = New System.Drawing.Size(147, 32)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Fine Report"
		'
		'dgvFineRpt
		'
		Me.dgvFineRpt.BackgroundColor = System.Drawing.SystemColors.Control
		Me.dgvFineRpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvFineRpt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colunm1, Me.Column1, Me.Column2, Me.Column3})
		Me.dgvFineRpt.Location = New System.Drawing.Point(92, 51)
		Me.dgvFineRpt.Name = "dgvFineRpt"
		Me.dgvFineRpt.RowHeadersWidth = 51
		Me.dgvFineRpt.RowTemplate.Height = 24
		Me.dgvFineRpt.Size = New System.Drawing.Size(678, 149)
		Me.dgvFineRpt.TabIndex = 5
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
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(103, 17)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(239, 37)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Total Fines Amount: RM"
		'
		'Colunm1
		'
		Me.Colunm1.HeaderText = "No."
		Me.Colunm1.MinimumWidth = 6
		Me.Colunm1.Name = "Colunm1"
		Me.Colunm1.Width = 125
		'
		'Column1
		'
		Me.Column1.HeaderText = "Return ID"
		Me.Column1.MinimumWidth = 6
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 125
		'
		'Column2
		'
		Me.Column2.HeaderText = "Return Date"
		Me.Column2.MinimumWidth = 6
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 125
		'
		'Column3
		'
		Me.Column3.HeaderText = "Fines"
		Me.Column3.MinimumWidth = 6
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 125
		'
		'lblSelectDate
		'
		Me.lblSelectDate.AutoSize = True
		Me.lblSelectDate.Location = New System.Drawing.Point(649, 12)
		Me.lblSelectDate.Name = "lblSelectDate"
		Me.lblSelectDate.Size = New System.Drawing.Size(83, 17)
		Me.lblSelectDate.TabIndex = 5
		Me.lblSelectDate.Text = "Select date:"
		'
		'dtpSelectDate
		'
		Me.dtpSelectDate.CustomFormat = "MM/yyyy"
		Me.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpSelectDate.Location = New System.Drawing.Point(652, 32)
		Me.dtpSelectDate.Name = "dtpSelectDate"
		Me.dtpSelectDate.Size = New System.Drawing.Size(246, 22)
		Me.dtpSelectDate.TabIndex = 4
		'
		'UserControl_FineReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "UserControl_FineReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.panForPrintHeader.ResumeLayout(False)
		Me.panForPrintHeader.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dgvFineRpt, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents lblChartTitle As Label
	Friend WithEvents lstFineReport As ListView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnPrint As Button
	Friend WithEvents Panel2 As Panel
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents ColumnHeader1 As ColumnHeader
	Friend WithEvents ColumnHeader2 As ColumnHeader
	Friend WithEvents ColumnHeader3 As ColumnHeader
	Friend WithEvents Panel4 As Panel
	Friend WithEvents easyRpt As KimToo.EasyHTMLReports
	Friend WithEvents panForPrintHeader As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents lblPrintedBy As Label
	Friend WithEvents lbl3 As Label
	Friend WithEvents lblDateNow As Label
	Friend WithEvents lblPrint As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dgvFineRpt As DataGridView
	Friend WithEvents ColumnHeader4 As ColumnHeader
	Friend WithEvents lblTotalFineAmount As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Colunm1 As DataGridViewTextBoxColumn
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents lblSelectDate As Label
	Friend WithEvents dtpSelectDate As DateTimePicker
End Class
