Imports DevExpress.Xpf.Docking

Namespace dxSampleGrid

    Friend Class MyLayoutAdapter
        Implements ILayoutAdapter

        Public Function Resolve(ByVal owner As DockLayoutManager, ByVal item As Object) As String Implements ILayoutAdapter.Resolve
            Dim p As Person = TryCast(item, Person)
            If p.IsTabbed Then
                Return "TabbedGroup1"
            End If
            If p.IsFloat Then
                Dim floatGroups = owner.FloatGroups
                Dim fg As FloatGroup
                If floatGroups.Count = 0 Then
                    fg = New FloatGroup()
                    fg.Name = "NewFloatGroup1"
                    owner.FloatGroups.Add(fg)
                Else
                    fg = floatGroups(0)
                End If
                Return fg.Name
            End If
            Return p.ParentName
        End Function
    End Class
End Namespace
