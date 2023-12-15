<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        TextBox1.Location = New Point(103, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(377, 46)
        TextBox1.TabIndex = 0
        TextBox1.TabStop = False
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        TextBox2.Location = New Point(103, 102)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(377, 46)
        TextBox2.TabIndex = 1
        TextBox2.TabStop = False
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("温柔养猫人", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button1.Location = New Point(495, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 111)
        Button1.TabIndex = 2
        Button1.Text = "计算总和"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        TextBox3.Location = New Point(103, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(513, 46)
        TextBox3.TabIndex = 3
        TextBox3.TabStop = False
        TextBox3.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("黑体", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(20, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 4
        Label1.Text = "变量A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("黑体", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(20, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 25)
        Label2.TabIndex = 5
        Label2.Text = "变量B"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("黑体", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label3.Location = New Point(20, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 25)
        Label3.TabIndex = 6
        Label3.Text = "总和F"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(639, 460)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
