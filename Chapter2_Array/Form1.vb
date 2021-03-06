﻿

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub GoMatrix_Click(sender As Object, e As EventArgs) Handles GoMatrix.Click

        Dim errMsgX As String
        Dim errMsgY As String

        errMsgX = myMatrix.ChkMatrixSize(InputX.Text)
        errMsgY = myMatrix.ChkMatrixSize(InputY.Text)

        ' check input
        If String.IsNullOrEmpty(errMsgX) And String.IsNullOrEmpty(errMsgY) Then

            InputXError.Clear()
            InputYError.Clear()

            Dim m As New myMatrix()
            Dim x As Integer
            Dim y As Integer
            x = InputX.Text
            y = InputY.Text

            Dim matrixA(,) As Integer
            Dim matrixB(,) As Integer
            Dim matrixR(,) As Integer

            ' generate matrix
            matrixA = m.CreateMatrix(x, y)
            matrixB = m.CreateMatrix(y, x)

            ' multiply matrix
            matrixR = m.Multiply2DArrays(matrixA, matrixB)

            ' show data
            ShowDataA.Text = m.ShowMatrix(matrixA)
            ShowDataB.Text = m.ShowMatrix(matrixB)
            ShowResult.Text = m.ShowMatrix(matrixR)

        Else

            ' return error msg.
            If String.IsNullOrEmpty(errMsgX) Then
                InputXError.Clear()
            Else
                InputYError.SetError(InputX, errMsgX)
            End If

            If String.IsNullOrEmpty(errMsgY) Then
                InputYError.Clear()
            Else
                InputYError.SetError(InputY, errMsgY)
            End If

        End If




    End Sub

    Private Sub InputX_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InputX.Validating

        ' check inputX
        Dim errMsg As String
        errMsg = myMatrix.ChkMatrixSize(InputX.Text)

        If String.IsNullOrEmpty(errMsg) Then
            InputXError.Clear()
        Else
            InputXError.SetError(InputX, errMsg)
        End If



    End Sub

    Private Sub InputY_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InputY.Validating

        'check inputY
        Dim errMsg As String
        errMsg = myMatrix.ChkMatrixSize(InputY.Text)

        If String.IsNullOrEmpty(errMsg) Then
            InputYError.Clear()
        Else
            InputYError.SetError(InputY, errMsg)
        End If

    End Sub

End Class
