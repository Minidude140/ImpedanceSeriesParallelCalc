<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircuitForm
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
        Me.CircuitPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CircuitPictureBox
        '
        Me.CircuitPictureBox.BackgroundImage = Global.ImpedanceSeriesParallelCalc.My.Resources.Resources.CircuitImage
        Me.CircuitPictureBox.Location = New System.Drawing.Point(10, 30)
        Me.CircuitPictureBox.Name = "CircuitPictureBox"
        Me.CircuitPictureBox.Size = New System.Drawing.Size(802, 305)
        Me.CircuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CircuitPictureBox.TabIndex = 0
        Me.CircuitPictureBox.TabStop = False
        '
        'CircuitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 497)
        Me.Controls.Add(Me.CircuitPictureBox)
        Me.MinimumSize = New System.Drawing.Size(1067, 0)
        Me.Name = "CircuitForm"
        Me.Text = "Circuit Calculator"
        CType(Me.CircuitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CircuitPictureBox As PictureBox
End Class
