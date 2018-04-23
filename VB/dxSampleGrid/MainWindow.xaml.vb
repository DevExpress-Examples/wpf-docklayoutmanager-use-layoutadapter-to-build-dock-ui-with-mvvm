Imports System.Windows

Namespace dxSampleGrid
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            vm = New MyViewModel()
            DataContext = vm

        End Sub
        Private vm As MyViewModel
    End Class
End Namespace
