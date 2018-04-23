Imports System.Collections.ObjectModel

Namespace dxSampleGrid
    Public Class MyViewModel
        Public Sub New()
            CreateList()
        End Sub

        Public Property PersonList() As ObservableCollection(Of Person)

        Private Sub CreateList()
            PersonList = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 4
                Dim p As New Person(i)
                p.ParentName = "LayoutGroup1"
                PersonList.Add(p)
            Next i
            PersonList(0).IsTabbed = True
            PersonList(1).IsTabbed = True
            PersonList(2).IsFloat = True
        End Sub
    End Class


End Namespace
