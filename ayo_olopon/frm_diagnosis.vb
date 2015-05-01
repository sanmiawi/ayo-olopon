Public Class frm_diagnosis

    Public Sub New(ByRef err_txt As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rtxt_debug.Text = err_txt
    End Sub
End Class