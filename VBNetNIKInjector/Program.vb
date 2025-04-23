Imports System
Imports System.Windows.Forms

Namespace VBNetNIKInjector
    Public Module Program
        <System.STAThread()>
        Public Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace
