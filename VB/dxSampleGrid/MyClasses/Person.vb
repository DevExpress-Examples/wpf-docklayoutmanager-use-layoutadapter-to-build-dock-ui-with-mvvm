Namespace dxSampleGrid

    Public Class Person

        Public Sub New(ByVal i As Integer)
            FirstName = "FirstName" & i
            LastName = "LastName" & i
            Age = i * 10
        End Sub

        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Age() As Integer
        Public Property ParentName() As String
        Public Property IsTabbed() As Boolean
        Public Property IsFloat() As Boolean
    End Class
End Namespace
