Public Class UserControl_NewBook
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Make default value to this year
        NumericUpDown_YearPublish.Value = Now.Year

        Using database As New LibDBDataContext()

            '' Add categories
            Dim categories = (From bk In database.Books Select bk.Category).Distinct()

            For Each category In categories
                ComboBox_Category.Items.Add(category)
            Next

        End Using
    End Sub
End Class
