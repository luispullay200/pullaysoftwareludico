Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlScroll.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlScroll.Height = Button1.Height
        pnlScroll.Top = Button1.Top
        pnlScroll.Show()
        'PictureBox1.Hide()'
        openChildForm(New Comunicacion())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlScroll.Height = Button2.Height
        pnlScroll.Top = Button2.Top
        pnlScroll.Show()
        'PictureBox1.Show()'
        openChildForm(New Evaluacion())

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlScroll.Height = Button3.Height
        pnlScroll.Top = Button3.Top
        pnlScroll.Show()
        openChildForm(New Ludica())
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        'If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Alerta!") = vbYes Then'
        End
        'End If'
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PnlChild.Controls.Add(childForm)
        PnlChild.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Alerta!") = vbYes Then'
        End
        'End If'
    End Sub

    Private Sub PnlChild_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
