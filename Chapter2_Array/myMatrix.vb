Public Class myMatrix
    Public Function Multiply2DArrays(matrixA As Integer(,), matrixB As Integer(,)) As Integer(,)
        Dim matrixR(UBound(matrixA, 1), UBound(matrixB, 2)) As Integer

        For i As Integer = 0 To UBound(matrixA, 1)
            For j As Integer = 0 To UBound(matrixB, 2)

                matrixR(i, j) = 0

                For k As Integer = 0 To UBound(matrixA, 2)
                    matrixR(i, j) = matrixR(i, j) + matrixA(i, k) * matrixB(k, j)
                Next
            Next
        Next

        Return matrixR
    End Function

    Public Function CreateMatrix(x As Integer, y As Integer) As Integer(,)
        Dim matrixA(x, y) As Integer
        Dim rndNum As New Random(Guid.NewGuid().GetHashCode())

        For i As Integer = 0 To x
            For j As Integer = 0 To y
                matrixA(i, j) = rndNum.Next(10)
            Next
        Next

        Return matrixA
    End Function

    Public Function ShowMatrix(matrix(,) As Integer) As String

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
End Class
