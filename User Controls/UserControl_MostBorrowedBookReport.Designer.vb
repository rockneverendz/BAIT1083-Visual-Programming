<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_MostBorrowedBookReport
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
		Me.components = New System.ComponentModel.Container()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.chartMostBorrowedBook = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnEasyRpt = New System.Windows.Forms.Button()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.lstMostBorrowedBook = New System.Windows.Forms.ListView()
		Me.col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.easyRpt = New KimToo.EasyHTMLReports(Me.components)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.chartMostBorrowedBook, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel4.SuspendLayout()
		Me.Panel3.SuspendLayout()
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
		Me.SplitContainer1.Panel1.Controls.Add(Me.chartMostBorrowedBook)
		Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
		Me.SplitContainer1.Panel2.Controls.Add(Me.lstMostBorrowedBook)
		Me.SplitContainer1.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.SplitterDistance = 756
		Me.SplitContainer1.TabIndex = 0
		'
		'chartMostBorrowedBook
		'
		Me.chartMostBorrowedBook.BackColor = System.Drawing.Color.WhiteSmoke
		Me.chartMostBorrowedBook.BackSecondaryColor = System.Drawing.Color.Gray
		Me.chartMostBorrowedBook.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
		ChartArea1.AxisX.Title = "Time"
		ChartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far
		ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea1.AxisY.Title = "Count"
		ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		ChartArea1.BackColor = System.Drawing.Color.PaleTurquoise
		ChartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
		ChartArea1.BackSecondaryColor = System.Drawing.Color.White
		ChartArea1.BorderColor = System.Drawing.Color.Transparent
		ChartArea1.Name = "Time Count Chart "
		Me.chartMostBorrowedBook.ChartAreas.Add(ChartArea1)
		Me.chartMostBorrowedBook.Dock = System.Windows.Forms.DockStyle.Fill
		Legend1.Name = "Legend1"
		Me.chartMostBorrowedBook.Legends.Add(Legend1)
		Me.chartMostBorrowedBook.Location = New System.Drawing.Point(0, 61)
		Me.chartMostBorrowedBook.Name = "chartMostBorrowedBook"
		Series1.BorderWidth = 3
		Series1.ChartArea = "Time Count Chart "
		Series1.Legend = "Legend1"
		Series1.MarkerSize = 10
		Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
		Series1.Name = "Count"
		Me.chartMostBorrowedBook.Series.Add(Series1)
		Me.chartMostBorrowedBook.Size = New System.Drawing.Size(756, 462)
		Me.chartMostBorrowedBook.TabIndex = 3
		Me.chartMostBorrowedBook.Text = " Chart "
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Panel4.Controls.Add(Me.Label1)
		Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Panel4.Location = New System.Drawing.Point(0, 0)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(756, 61)
		Me.Panel4.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(200, 13)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(375, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Most Borrowed Book by Patron" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.btnEasyRpt)
		Me.Panel3.Controls.Add(Me.lblSelectDate)
		Me.Panel3.Controls.Add(Me.dtpSelectDate)
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 405)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(307, 118)
		Me.Panel3.TabIndex = 3
		'
		'btnEasyRpt
		'
		Me.btnEasyRpt.Location = New System.Drawing.Point(142, 68)
		Me.btnEasyRpt.Name = "btnEasyRpt"
		Me.btnEasyRpt.Size = New System.Drawing.Size(118, 37)
		Me.btnEasyRpt.TabIndex = 3
		Me.btnEasyRpt.Text = "Print with Easy"
		Me.btnEasyRpt.UseVisualStyleBackColor = True
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
		Me.btnPrint.Location = New System.Drawing.Point(14, 68)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(118, 37)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'lstMostBorrowedBook
		'
		Me.lstMostBorrowedBook.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col1, Me.col2})
		Me.lstMostBorrowedBook.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstMostBorrowedBook.HideSelection = False
		Me.lstMostBorrowedBook.Location = New System.Drawing.Point(0, 0)
		Me.lstMostBorrowedBook.Name = "lstMostBorrowedBook"
		Me.lstMostBorrowedBook.Size = New System.Drawing.Size(307, 523)
		Me.lstMostBorrowedBook.TabIndex = 0
		Me.lstMostBorrowedBook.UseCompatibleStateImageBehavior = False
		Me.lstMostBorrowedBook.View = System.Windows.Forms.View.Details
		'
		'col1
		'
		Me.col1.Text = "Book title"
		Me.col1.Width = 164
		'
		'col2
		'
		Me.col2.Text = "Number of Borrowed"
		Me.col2.Width = 217
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
		'UserControl_MostBorrowedBookReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "UserControl_MostBorrowedBookReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.chartMostBorrowedBook, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Panel4 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents chartMostBorrowedBook As DataVisualization.Charting.Chart
	Friend WithEvents lstMostBorrowedBook As ListView
	Friend WithEvents Panel3 As Panel
	Friend WithEvents btnEasyRpt As Button
	Friend WithEvents lblSelectDate As Label
	Friend WithEvents dtpSelectDate As DateTimePicker
	Friend WithEvents btnPrint As Button
	Friend WithEvents col1 As ColumnHeader
	Friend WithEvents col2 As ColumnHeader
	Friend WithEvents easyRpt As KimToo.EasyHTMLReports
End Class
