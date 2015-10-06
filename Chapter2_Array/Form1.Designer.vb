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
        Me.components = New System.ComponentModel.Container()
        Me.GoMatrix = New System.Windows.Forms.Button()
        Me.InputX = New System.Windows.Forms.TextBox()
        Me.InputY = New System.Windows.Forms.TextBox()
        Me.InputXError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.InputYError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ShowDataA = New System.Windows.Forms.Label()
        Me.ShowDataB = New System.Windows.Forms.Label()
        Me.ShowResult = New System.Windows.Forms.Label()
        CType(Me.InputXError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InputYError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoMatrix
        '
        Me.GoMatrix.Location = New System.Drawing.Point(528, 12)
        Me.GoMatrix.Name = "GoMatrix"
        Me.GoMatrix.Size = New System.Drawing.Size(188, 36)
        Me.GoMatrix.TabIndex = 2
        Me.GoMatrix.Text = "Create and Multiply Matrix "
        Me.GoMatrix.UseVisualStyleBackColor = True
        '
        'InputX
        '
        Me.InputX.Location = New System.Drawing.Point(13, 12)
        Me.InputX.Name = "InputX"
        Me.InputX.Size = New System.Drawing.Size(100, 22)
        Me.InputX.TabIndex = 0
        '
        'InputY
        '
        Me.InputY.Location = New System.Drawing.Point(274, 12)
        Me.InputY.Name = "InputY"
        Me.InputY.Size = New System.Drawing.Size(100, 22)
        Me.InputY.TabIndex = 1
        '
        'InputXError
        '
        Me.InputXError.ContainerControl = Me
        '
        'InputYError
        '
        Me.InputYError.ContainerControl = Me
        '
        'ShowDataA
        '
        Me.ShowDataA.AutoSize = True
        Me.ShowDataA.Location = New System.Drawing.Point(12, 66)
        Me.ShowDataA.Name = "ShowDataA"
        Me.ShowDataA.Size = New System.Drawing.Size(70, 12)
        Me.ShowDataA.TabIndex = 6
        Me.ShowDataA.Text = "show matrixA"
        '
        'ShowDataB
        '
        Me.ShowDataB.AutoSize = True
        Me.ShowDataB.Location = New System.Drawing.Point(272, 66)
        Me.ShowDataB.Name = "ShowDataB"
        Me.ShowDataB.Size = New System.Drawing.Size(70, 12)
        Me.ShowDataB.TabIndex = 7
        Me.ShowDataB.Text = "show matrixB"
        '
        'ShowResult
        '
        Me.ShowResult.AutoSize = True
        Me.ShowResult.Location = New System.Drawing.Point(526, 66)
        Me.ShowResult.Name = "ShowResult"
        Me.ShowResult.Size = New System.Drawing.Size(57, 12)
        Me.ShowResult.TabIndex = 8
        Me.ShowResult.Text = "show result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.ShowResult)
        Me.Controls.Add(Me.ShowDataB)
        Me.Controls.Add(Me.ShowDataA)
        Me.Controls.Add(Me.InputY)
        Me.Controls.Add(Me.InputX)
        Me.Controls.Add(Me.GoMatrix)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InputXError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InputYError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoMatrix As System.Windows.Forms.Button
    Friend WithEvents InputX As System.Windows.Forms.TextBox
    Friend WithEvents InputY As System.Windows.Forms.TextBox
    Friend WithEvents InputXError As System.Windows.Forms.ErrorProvider
    Friend WithEvents InputYError As System.Windows.Forms.ErrorProvider
    Friend WithEvents ShowDataA As System.Windows.Forms.Label
    Friend WithEvents ShowDataB As System.Windows.Forms.Label
    Friend WithEvents ShowResult As System.Windows.Forms.Label

End Class
