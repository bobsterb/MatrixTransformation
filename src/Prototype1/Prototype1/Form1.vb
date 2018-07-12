Public Class Form1

    Dim MyRandom As Random
    Dim MatrixCheck(3) As Integer

    Sub PopulateWithRandomNumbers()
        MyRandom = New Random


        MatrixA.Text = MyRandom.Next(0, 10)
        MatrixB.Text = MyRandom.Next(0, 10)
        MatrixC.Text = MyRandom.Next(0, 10)
        MatrixD.Text = MyRandom.Next(0, 10)
        ObjectA.Text = MyRandom.Next(0, 10)
        ObjectB.Text = MyRandom.Next(0, 10)
        ObjectC.Text = MyRandom.Next(0, 10)
        ObjectD.Text = MyRandom.Next(0, 10)
        ObjectE.Text = MyRandom.Next(0, 10)
        ObjectF.Text = MyRandom.Next(0, 10)
        'ImageF.Text = MyRandom.Next(0, 10)
        'ImageE.Text = MyRandom.Next(0, 10)
        'ImageD.Text = MyRandom.Next(0, 10)
        'ImageC.Text = MyRandom.Next(0, 10)
        'ImageB.Text = MyRandom.Next(0, 10)
        'ImageA.Text = MyRandom.Next(0, 10)

        CalculateImage()
        ClearingMatrix()

    End Sub
    Sub CalculateImage()
        ImageA.Text = (MatrixA.Text * ObjectA.Text) + (MatrixB.Text * ObjectD.Text)
        ImageB.Text = (MatrixA.Text * ObjectB.Text) + (MatrixB.Text * ObjectE.Text)
        ImageC.Text = (MatrixA.Text * ObjectC.Text) + (MatrixB.Text * ObjectF.Text)
        ImageD.Text = (MatrixC.Text * ObjectA.Text) + (MatrixD.Text * ObjectD.Text)
        ImageE.Text = (MatrixC.Text * ObjectB.Text) + (MatrixD.Text * ObjectE.Text)
        ImageF.Text = (MatrixC.Text * ObjectA.Text) + (MatrixD.Text * ObjectF.Text)
    End Sub

    Private Sub s(sender As Object, e As EventArgs) Handles ObjectA.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateWithRandomNumbers()
        ShowAnswerButton.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PopulateWithRandomNumbers()
    End Sub
    Sub ClearingMatrix()

        MatrixCheck(0) = MatrixA.Text
        MatrixCheck(1) = MatrixB.Text
        MatrixCheck(2) = MatrixC.Text
        MatrixCheck(3) = MatrixD.Text

        MatrixA.Text = String.Empty
        MatrixB.Text = String.Empty
        MatrixC.Text = String.Empty
        MatrixD.Text = String.Empty
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        ShowAnswerButton.Show()

        Dim correct As Boolean = True


        If MatrixA.Text = MatrixCheck(0) And MatrixB.Text = MatrixCheck(1) And MatrixC.Text = MatrixCheck(2) And MatrixD.Text = MatrixCheck(3) Then
            correct = True
        Else
            correct = False
        End If

        If correct = True Then
            TextBox17.Text = "Correct"
        Else
            TextBox17.Text = "Incorrect"
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ShowAnswerButton.Click
        AnswerMatrixA.Text = MatrixCheck(0)
        AnswerMatrixB.Text = MatrixCheck(1)
        AnswerMatrixC.Text = MatrixCheck(2)
        AnswerMatrixD.Text = MatrixCheck(3)
    End Sub





    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    Dim correct As Boolean = True

    'If (MatrixA.Text * ObjectA.Text) + (MatrixB.Text * ObjectD.Text) = ImageA.Text And (MatrixA.Text * ObjectA.Text) + (MatrixB.Text * ObjectD.Text) = ImageB.Text And (MatrixA.Text * ObjectB.Text) + (MatrixB.Text * ObjectE.Text) = ImageB.Text And (MatrixA.Text * ObjectC.Text) + (MatrixB.Text * ObjectF.Text) = ImageC.Text And (MatrixC.Text * ObjectA.Text) + (MatrixD.Text * ObjectD.Text) = ImageD.Text And (MatrixC.Text * ObjectB.Text) + (MatrixD.Text * ObjectE.Text) = ImageE.Text And (MatrixC.Text * ObjectC.Text) + (MatrixD.Text * ObjectF.Text) = ImageF.Text Then
    '       correct = True
    'Else correct = False
    '
    'End If

    '  If correct = True Then
    '       TextBox17.Text = "Correct"
    'Else
    '       TextBox17.Text = "Incorrect"
    'End If

    'End Sub


End Class
