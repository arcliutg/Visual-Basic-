Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        MessageBox.Show("欢迎学习 Visual Basic") '这个会自动蹦出一个弹窗
        Label1.Text = "欢迎学习 Visual Basic"
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Debug.Print(20 + 10) '使用了 Debug.Print() 方法来输出结果，该方法会在「输出」窗口中显示结果
        Debug.Print(20 - 10)
        Debug.Print(20 * 10)
        Debug.Print(20 / 10)
    End Sub


    Private clickCount As Integer = 0 ' 记录点击次数和显示结果
    Private Sub Label1_Click(sender As Object, Z As EventArgs) Handles Label1.Click

        clickCount += 1 ' 点击次数加 1
        Select Case clickCount
            Case 1
                Label1.Text = (20 + 10).ToString()
            Case 2
                Label1.Text = (20 - 10).ToString()
            Case 3
                Label1.Text = (20 * 10).ToString()
            Case 4
                Label1.Text = ("最后一次").ToString()
            Case 5
                Dim A As String = "我"
                Dim B As String = "喜"
                Dim C As String = "欢"
                Dim D As String = "吃"
                Dim E As String = "饺子"
                Label1.Text = A + B + C + D + E
            Case Else ' 非 1 2 3 4 次点击，令clickCount值为1，重新开始循环
                clickCount = 1
                Label1.Text = (20 + 10).ToString()
        End Select
    End Sub
End Class
