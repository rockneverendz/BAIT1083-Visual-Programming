<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_RoomBookingReport
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
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lstQueryRpt = New System.Windows.Forms.ListView()
		Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.dtpSelectDate = New System.Windows.Forms.DateTimePicker()
		Me.lblSelectDate = New System.Windows.Forms.Label()
		Me.chartTimeCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		CType(Me.chartTimeCount, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.SplitContainer1.Panel1.Controls.Add(Me.chartTimeCount)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
		Me.SplitContainer1.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.SplitterDistance = 787
		Me.SplitContainer1.TabIndex = 2
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Panel1.Controls.Add(Me.Panel3)
		Me.Panel1.Controls.Add(Me.Panel2)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(276, 523)
		Me.Panel1.TabIndex = 0
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.lblSelectDate)
		Me.Panel3.Controls.Add(Me.dtpSelectDate)
		Me.Panel3.Controls.Add(Me.btnPrint)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.Panel3.Location = New System.Drawing.Point(0, 411)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(272, 108)
		Me.Panel3.TabIndex = 2
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.lstQueryRpt)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(272, 405)
		Me.Panel2.TabIndex = 1
		'
		'lstQueryRpt
		'
		Me.lstQueryRpt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time, Me.Count})
		Me.lstQueryRpt.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstQueryRpt.HideSelection = False
		Me.lstQueryRpt.Location = New System.Drawing.Point(0, 0)
		Me.lstQueryRpt.Name = "lstQueryRpt"
		Me.lstQueryRpt.Size = New System.Drawing.Size(272, 405)
		Me.lstQueryRpt.TabIndex = 0
		Me.lstQueryRpt.UseCompatibleStateImageBehavior = False
		Me.lstQueryRpt.View = System.Windows.Forms.View.Details
		'
		'Time
		'
		Me.Time.Text = "Time"
		Me.Time.Width = 75
		'
		'Count
		'
		Me.Count.Text = "Count"
		Me.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.Count.Width = 100
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(72, 68)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(130, 37)
		Me.btnPrint.TabIndex = 0
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'dtpSelectDate
		'
		Me.dtpSelectDate.Location = New System.Drawing.Point(14, 35)
		Me.dtpSelectDate.Name = "dtpSelectDate"
		Me.dtpSelectDate.Size = New System.Drawing.Size(246, 22)
		Me.dtpSelectDate.TabIndex = 1
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
		'chartTimeCount
		'
		Me.chartTimeCount.BackColor = System.Drawing.Color.WhiteSmoke
		Me.chartTimeCount.BackSecondaryColor = System.Drawing.Color.Gray
		Me.chartTimeCount.BorderSkin.PageColor = System.Drawing.Color.WhiteSmoke
		ChartArea2.Name = "ChartArea1"
		Me.chartTimeCount.ChartAreas.Add(ChartArea2)
		Me.chartTimeCount.Dock = System.Windows.Forms.DockStyle.Fill
		Legend2.Name = "Legend1"
		Me.chartTimeCount.Legends.Add(Legend2)
		Me.chartTimeCount.Location = New System.Drawing.Point(0, 0)
		Me.chartTimeCount.Name = "chartTimeCount"
		Series2.BorderWidth = 3
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series2.Legend = "Legend1"
		Series2.MarkerSize = 10
		Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
		Series2.Name = "Count"
		Me.chartTimeCount.Series.Add(Series2)
		Me.chartTimeCount.Size = New System.Drawing.Size(787, 523)
		Me.chartTimeCount.TabIndex = 0
		Me.chartTimeCount.Text = "Chart Count Time"
		'
		'UserControl_RoomBookingReport
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.Controls.Add(Me.SplitContainer1)
		Me.Name = "UserControl_RoomBookingReport"
		Me.Size = New System.Drawing.Size(1067, 523)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.Panel2.PerformLayout()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.Panel1.ResumeLayout(False)
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		CType(Me.chartTimeCount, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents Panel1 As Panel
	Friend WithEvents Panel3 As Panel
	Friend WithEvents Panel2 As Panel
	Friend WithEvents lstQueryRpt As ListView
	Friend WithEvents Time As ColumnHeader
	Friend WithEvents Count As ColumnHeader
	Friend WithEvents lblSelectDate As Label
	Friend WithEvents dtpSelectDate As DateTimePicker
	Friend WithEvents btnPrint As Button
	Friend WithEvents chartTimeCount As DataVisualization.Charting.Chart
End Class
