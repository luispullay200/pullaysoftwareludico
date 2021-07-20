Public Class Evaluacion
    Dim preguntas() As String = {
    "Comunicar es llegar a compartir algo de nosotros mismos. Es decir, es una cualidad racional y
emocional específica del hombre que surge de la necesidad de ponerse en contacto con los...",
    "Los diversos modos en que los seres humanos intercambiamos ideas, desde la señal, el gesto o la imagen, hasta la palabra hablada o ...",
    "No hay una fórmula que determine que la comunicación ocurre siempre igual entre las ...",
    "Desarrollar habilidades para llegar a ser un comunicador competitivo exige
llevar a la acción nuestras...",
"Hay aptitudes innatas y derivadas, naturales y adquiridas. El estudio integra y templa, pero
no crea. Por otra parte, todo orador tiene una manera propia de concebir y ...",
"El comunicador, para ser eficaz en este aspecto, debe aprender a pararse erguido y moverse con...",
"Para un buen comunicador, esta habilidad no sólo consiste en hacer contacto visual con el
receptor, sino que por medio de la mirada debe reflejar entusiasmo, naturalidad y convicción
de ..."}
    Dim respuestas() As String = {
    "demás",
    "escrita",
    "personas",
    "aptitudes",
    "expresarse",
    "naturalidad",
    "ideas"}
    Dim resTemp() As String = {"null", "null", "null"}
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LblCorrecta1.Text = "Respuesta Correcta: " & resTemp(0)
        LblCorrecta2.Text = "Respuesta Correcta: " & resTemp(1)
        LblCorrecta3.Text = "Respuesta Correcta: " & resTemp(2)
        Dim r1 As String
        Dim r2 As String
        Dim r3 As String
        Dim nota As Integer = 0
        r1 = TxtRespuesta1.Text
        r2 = TxtRespuesta2.Text
        r3 = TxtRespuesta3.Text


        If r1 = resTemp(0) Then
            nota = nota + 10
        End If
        If r2 Like resTemp(1) Then
            nota = nota + 10
        End If
        If r3 Like resTemp(2) Then
            nota = nota + 10
        End If

        LblNota.Text = "Calificación: " & nota.ToString()
        If nota = 0 Then
            LblMensaje.Text = "OTRO INTENTO"
        End If
        If nota = 10 Then
            LblMensaje.Text = "REGULAR"
        End If
        If nota = 20 Then
            LblMensaje.Text = "BUENO"
        End If
        If nota = 30 Then
            LblMensaje.Text = "EXCELENTE"
        End If
    End Sub
    Private Sub Evaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd1 As New Random
        Dim rnd2 As New Random
        Dim rnd3 As New Random
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer
        x1 = rnd1.Next(0, 7)
        x2 = rnd2.Next(0, 7)
        x3 = rnd3.Next(0, 7)

        LblPregunta1.Text = preguntas(x1)
        LblPregunta2.Text = preguntas(x2)
        LblPregunta3.Text = preguntas(x3)

        resTemp(0) = respuestas(x1)
        resTemp(1) = respuestas(x2)
        resTemp(2) = respuestas(x3)
    End Sub
End Class