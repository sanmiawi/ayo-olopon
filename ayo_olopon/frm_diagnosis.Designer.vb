<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_diagnosis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.rtxt_debug = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxt_debug
        '
        Me.rtxt_debug.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxt_debug.Location = New System.Drawing.Point(0, 0)
        Me.rtxt_debug.Name = "rtxt_debug"
        Me.rtxt_debug.Size = New System.Drawing.Size(564, 451)
        Me.rtxt_debug.TabIndex = 0
        Me.rtxt_debug.Text = ""
        '
        'frm_diagnosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 451)
        Me.Controls.Add(Me.rtxt_debug)
        Me.MaximizeBox = False
        Me.Name = "frm_diagnosis"
        Me.Text = "Diagnosis - Debug"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxt_debug As System.Windows.Forms.RichTextBox
End Class
