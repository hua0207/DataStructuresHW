Imports System.Text.RegularExpressions

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
                    str = str + Right("     " + matrix(i, j).ToString, 5)
                Else
                    str = str + Right("     " + matrix(i, j).ToString, 5) + ", "
                End If
            Next

            str += vbCrLf

        Next

        Return str
    End Function

    Public Shared Function ChkMatrixSize(input As String) As String
        Dim msg As String

        'Dim regex As Regex = New Regex("^[1-9]+$")
        Dim regex As Regex = New Regex("^[1-9]$")
        If regex.IsMatch(input) Then
            msg = String.Empty
        Else
            msg = "only 1~9 may be entered here!!"
        End If

        Return msg
    End Function
End Class
