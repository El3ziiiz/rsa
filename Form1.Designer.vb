<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        calc = New Button()
        base = New TextBox()
        pow = New TextBox()
        modd = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' calc
        ' 
        calc.Location = New Point(560, 181)
        calc.Name = "calc"
        calc.Size = New Size(135, 75)
        calc.TabIndex = 0
        calc.Text = "calculate"
        calc.UseVisualStyleBackColor = True
        ' 
        ' base
        ' 
        base.Location = New Point(74, 208)
        base.Name = "base"
        base.Size = New Size(100, 23)
        base.TabIndex = 1
        ' 
        ' pow
        ' 
        pow.Location = New Point(220, 173)
        pow.Name = "pow"
        pow.Size = New Size(100, 23)
        pow.TabIndex = 2
        ' 
        ' modd
        ' 
        modd.Location = New Point(398, 208)
        modd.Name = "modd"
        modd.Size = New Size(100, 23)
        modd.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(174, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 4
        Label1.Text = "^"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(340, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 5
        Label2.Text = "mod"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(526, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 15)
        Label3.TabIndex = 6
        Label3.Text = "="
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(819, 385)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(modd)
        Controls.Add(pow)
        Controls.Add(base)
        Controls.Add(calc)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents calc As Button
    Friend WithEvents base As TextBox
    Friend WithEvents pow As TextBox
    Friend WithEvents modd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
