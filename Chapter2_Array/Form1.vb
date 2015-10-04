Public Class Form1

    Private Function CreateMatrix(x As Integer, y As Integer) As Integer(,)
        Dim matrixA(x, y) As Integer
        Dim rndNum As New Random(Guid.NewGuid().GetHashCode())
        Dim arrayNo As Integer

        For i As Integer = 0 To x
            For j As Integer = 0 To y
                matrixA(i, j) = rndNum.Next(10)
                arrayNo += 1
            Next
        Next

        Return matrixA
    End Function

    Private Function ShowMatrix(matrix(,) As Integer) As String

        Dim str As String = ""

        For i As Integer = 0 To UBound(matrix, 1)
            For j As Integer = 0 To UBound(matrix, 2)

                If j = UBound(matrix, 2) Then
                    str = str + matrix(i, j).ToString
                Else
                    str = str + matrix(i, j).ToString + ", "
                End If
            Next

            str += vbCrLf

        Next

        Return str
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CreateMatrix_Click(sender As Object, e As EventArgs) Handles CreateMatrixA.Click
        ShowDataA.Text = ShowMatrix(CreateMatrix(2, 2))
        ShowDataB.Text = ShowMatrix(CreateMatrix(2, 2))

    End Sub
End Class
