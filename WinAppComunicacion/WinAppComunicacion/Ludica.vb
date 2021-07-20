Public Class Ludica
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TxtResp5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respuestas() As String = {"PARENTESIS", "AGUDAS", "PUNTO", "COMAS", "ESDRUJULAS", "PUNTOYAPARTE", "GRAVES", "COMILLAS"}
        Dim puntaje As Integer = 0
        If TxtResp1.Text = respuestas(0) Then
            puntaje = puntaje + 10
            LblResp1.Text = "1.- CORRECTA"
        Else
            LblResp1.Text = "1.- INCORRECTA"
        End If
        If TxtResp2.Text = respuestas(1) Then
            puntaje = puntaje + 10
            LblResp2.Text = "2.- CORRECTA"
        Else
            LblResp2.Text = "2.- INCORRECTA"
        End If
        If TxtResp3.Text = respuestas(2) Then
            puntaje = puntaje + 10
            LblResp3.Text = "3.- CORRECTA"
        Else
            LblResp3.Text = "3.- INCORRECTA"
        End If
        If TxtResp4.Text = respuestas(3) Then
            puntaje = puntaje + 10
            LblResp4.Text = "4.- CORRECTA"
        Else
            LblResp4.Text = "4.- INCORRECTA"
        End If
        If TxtResp5.Text = respuestas(4) Then
            puntaje = puntaje + 10
            LblResp5.Text = "5.- CORRECTA"
        Else
            LblResp5.Text = "5.- INCORRECTA"
        End If
        If TxtResp6.Text = respuestas(5) Then
            puntaje = puntaje + 10
            LblResp6.Text = "6.- CORRECTA"
        Else
            LblResp6.Text = "6.- INCORRECTA"
        End If
        If TxtResp7.Text = respuestas(6) Then
            puntaje = puntaje + 10
            LblResp7.Text = "7.- CORRECTA"
        Else
            LblResp7.Text = "7.- INCORRECTA"
        End If
        If TxtResp8.Text = respuestas(7) Then
            puntaje = puntaje + 10
            LblResp8.Text = "8.- CORRECTA"
        Else
            LblResp8.Text = "8.- INCORRECTA"
        End If
        LblPuntaje.Text = "Puntaje: " & puntaje.ToString()
        If puntaje <= 60 Then
            LblMensaje.Text = "PERDISTE!!!"
        ElseIf puntaje = 70 Then
            LblMensaje.Text = "OTRO INTENTO!!!"
        ElseIf puntaje = 80 Then
            LblMensaje.Text = "GANASTE!!!"
        End If

        PnlImagen.BackgroundImage = Global.WinAppComunicacion.My.Resources.Resources.resuelto
    End Sub
End Class