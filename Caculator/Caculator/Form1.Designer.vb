<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.additionRb = New System.Windows.Forms.RadioButton()
        Me.SubtractRb = New System.Windows.Forms.RadioButton()
        Me.MultiplyRb = New System.Windows.Forms.RadioButton()
        Me.DivideRb = New System.Windows.Forms.RadioButton()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.input1TextBox = New System.Windows.Forms.TextBox()
        Me.input2TextBox = New System.Windows.Forms.TextBox()
        Me.symbolLbl = New System.Windows.Forms.Label()
        Me.answerLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'additionRb
        '
        Me.additionRb.AutoSize = True
        Me.additionRb.Location = New System.Drawing.Point(12, 25)
        Me.additionRb.Name = "additionRb"
        Me.additionRb.Size = New System.Drawing.Size(44, 17)
        Me.additionRb.TabIndex = 1
        Me.additionRb.TabStop = True
        Me.additionRb.Text = "Add"
        Me.additionRb.UseVisualStyleBackColor = True
        '
        'SubtractRb
        '
        Me.SubtractRb.AutoSize = True
        Me.SubtractRb.Location = New System.Drawing.Point(62, 25)
        Me.SubtractRb.Name = "SubtractRb"
        Me.SubtractRb.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRb.TabIndex = 2
        Me.SubtractRb.TabStop = True
        Me.SubtractRb.Text = "Subtract"
        Me.SubtractRb.UseVisualStyleBackColor = True
        '
        'MultiplyRb
        '
        Me.MultiplyRb.AutoSize = True
        Me.MultiplyRb.Location = New System.Drawing.Point(133, 25)
        Me.MultiplyRb.Name = "MultiplyRb"
        Me.MultiplyRb.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRb.TabIndex = 3
        Me.MultiplyRb.TabStop = True
        Me.MultiplyRb.Text = "Multiply"
        Me.MultiplyRb.UseVisualStyleBackColor = True
        '
        'DivideRb
        '
        Me.DivideRb.AutoSize = True
        Me.DivideRb.Location = New System.Drawing.Point(199, 25)
        Me.DivideRb.Name = "DivideRb"
        Me.DivideRb.Size = New System.Drawing.Size(55, 17)
        Me.DivideRb.TabIndex = 4
        Me.DivideRb.TabStop = True
        Me.DivideRb.Text = "Divide"
        Me.DivideRb.UseVisualStyleBackColor = True
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(62, 74)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(75, 23)
        Me.calculateBtn.TabIndex = 5
        Me.calculateBtn.Text = "Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(143, 74)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 6
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'input1TextBox
        '
        Me.input1TextBox.Location = New System.Drawing.Point(12, 48)
        Me.input1TextBox.Name = "input1TextBox"
        Me.input1TextBox.Size = New System.Drawing.Size(115, 20)
        Me.input1TextBox.TabIndex = 7
        '
        'input2TextBox
        '
        Me.input2TextBox.Location = New System.Drawing.Point(156, 48)
        Me.input2TextBox.Name = "input2TextBox"
        Me.input2TextBox.Size = New System.Drawing.Size(124, 20)
        Me.input2TextBox.TabIndex = 7
        '
        'symbolLbl
        '
        Me.symbolLbl.AutoSize = True
        Me.symbolLbl.Location = New System.Drawing.Point(133, 51)
        Me.symbolLbl.Name = "symbolLbl"
        Me.symbolLbl.Size = New System.Drawing.Size(48, 13)
        Me.symbolLbl.TabIndex = 8
        Me.symbolLbl.Text = "Operator"
        '
        'answerLbl
        '
        Me.answerLbl.AutoSize = True
        Me.answerLbl.Location = New System.Drawing.Point(122, 100)
        Me.answerLbl.Name = "answerLbl"
        Me.answerLbl.Size = New System.Drawing.Size(42, 13)
        Me.answerLbl.TabIndex = 8
        Me.answerLbl.Text = "Answer"
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(284, 119)
        Me.Controls.Add(Me.answerLbl)
        Me.Controls.Add(Me.symbolLbl)
        Me.Controls.Add(Me.input2TextBox)
        Me.Controls.Add(Me.input1TextBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.DivideRb)
        Me.Controls.Add(Me.MultiplyRb)
        Me.Controls.Add(Me.SubtractRb)
        Me.Controls.Add(Me.additionRb)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents additionRb As System.Windows.Forms.RadioButton
    Friend WithEvents SubtractRb As System.Windows.Forms.RadioButton
    Friend WithEvents MultiplyRb As System.Windows.Forms.RadioButton
    Friend WithEvents DivideRb As System.Windows.Forms.RadioButton
    Friend WithEvents calculateBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents input1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents input2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents symbolLbl As System.Windows.Forms.Label
    Friend WithEvents answerLbl As System.Windows.Forms.Label

End Class
