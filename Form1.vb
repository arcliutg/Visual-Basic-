Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        MessageBox.Show("欢迎学习 Visual Basic") '这个会自动蹦出一个弹窗

    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Debug.Print(20 + 10) '使用了 Debug.Print() 方法来输出结果，该方法会在「输出」窗口中显示结果
        Debug.Print(20 - 10)
        Debug.Print(20 * 10)
        Debug.Print(20 / 10)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class
