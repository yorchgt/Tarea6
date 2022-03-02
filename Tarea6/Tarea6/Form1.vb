Public Class Form1

    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function


    Private Sub btnAmenos_Click(sender As Object, e As EventArgs) Handles btnAmenos.Click
        lblA.Text = Restar(lblA.Text)
    End Sub

    Private Sub btnBmenos_Click(sender As Object, e As EventArgs) Handles btnBmenos.Click
        lblB.Text = Restar(lblB.Text)
    End Sub

    Private Sub btnAmas_Click(sender As Object, e As EventArgs) Handles btnAmas.Click
        lblA.Text = Aumentar(lblA.Text)
    End Sub

    Private Sub btnBmas_Click(sender As Object, e As EventArgs) Handles btnBmas.Click
        lblB.Text = Aumentar(lblB.Text)
    End Sub

    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function

    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function

    Function Multiplicacion(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function

    Function Division(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA / numB
        Return resultado
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)
        lblresultado.Text = "El resultado de A + B es: " + resultadoSuma.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        lblresultado.Text = "El resultado de A - B es: " + resultadoResta.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMultiplicacion = Multiplicacion(numA, numB)
        lblresultado.Text = "El resultado de A * B es: " + resultadoMultiplicacion.ToString
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim txtA = lblA.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lblB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoDivision = Division(numA, numB)
        lblresultado.Text = "El resultado de A / B es: " + resultadoDivision.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Desea Salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

End Class
