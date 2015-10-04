<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ShowDataA = New System.Windows.Forms.TextBox()
        Me.CreateMatrixA = New System.Windows.Forms.Button()
        Me.ShowDataB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ShowDataA
        '
        Me.ShowDataA.Location = New System.Drawing.Point(12, 66)
        Me.ShowDataA.Multiline = True
        Me.ShowDataA.Name = "ShowDataA"
        Me.ShowDataA.Size = New System.Drawing.Size(135, 155)
        Me.ShowDataA.TabIndex = 0
        '
        'CreateMatrixA
        '
        Me.CreateMatrixA.Location = New System.Drawing.Point(12, 12)
        Me.CreateMatrixA.Name = "CreateMatrixA"
        Me.CreateMatrixA.Size = New System.Drawing.Size(115, 21)
        Me.CreateMatrixA.TabIndex = 1
        Me.CreateMatrixA.Text = "Create Matrix "
        Me.CreateMatrixA.UseVisualStyleBackColor = True
        '
        'ShowDataB
        '
        Me.ShowDataB.Location = New System.Drawing.Point(185, 66)
        Me.ShowDataB.Multiline = True
        Me.ShowDataB.Name = "ShowDataB"
        Me.ShowDataB.Size = New System.Drawing.Size(135, 155)
        Me.ShowDataB.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.ShowDataB)
        Me.Controls.Add(Me.CreateMatrixA)
        Me.Controls.Add(Me.ShowDataA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowDataA As System.Windows.Forms.TextBox
    Friend WithEvents CreateMatrixA As System.Windows.Forms.Button
    Friend WithEvents ShowDataB As System.Windows.Forms.TextBox

End Class
