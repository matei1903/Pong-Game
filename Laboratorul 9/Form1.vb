Public Class Form1

    Dim dx As Integer = 1
    Dim dy As Integer = 1
    Dim distanta_bila As Integer = 2
    Dim distanta_paleta As Integer = 7
    Dim vieti As Integer = 3
    Dim puncte As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        control_paleta.Image = My.Resources.paleta
        control_bila.BackgroundImageLayout = ImageLayout.Stretch
        control_bila.BackgroundImage = My.Resources.bila
        control_obstacol.BackgroundImageLayout = ImageLayout.Stretch
        control_obstacol.BackgroundImage = My.Resources.Obstacol
        obstacol2.BackgroundImageLayout = ImageLayout.Stretch
        obstacol2.BackgroundImage = My.Resources.Obstacol

        Label2.Text = vieti
        Label4.Text = puncte
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles miscare_bila.Tick
        If control_bila.Left < 0 Then
            dx = -dx

        End If

        If control_bila.Left + control_bila.Width > Me.Width Then
            dx = -dx

        End If

        If control_bila.Top < 0 Then
            dy = -dy

        End If

        If control_bila.Top + control_bila.Height > control_paleta.Top Then
            Dim centru_bila As Double
            centru_bila = control_bila.Left + control_bila.Width / 2

            If centru_bila >= control_paleta.Left And centru_bila <= control_paleta.Left + control_paleta.Width Then
                dy = -dy
                puncte = puncte + 1
                Label4.Text = puncte

            Else

                miscare_bila.Enabled = False
                If vieti > 0 Then
                    If MessageBox.Show("Ai pierdut. Vrei sa incerci din nou?", "Pong", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                        control_paleta.Left = Me.Width / 2 - control_paleta.Width / 2

                        control_bila.Top = (Me.Height / 4) * Rnd()

                        miscare_bila.Enabled = True
                        vieti = vieti - 1
                        puncte = 0
                        Label4.Text = puncte
                        Label2.Text = vieti
                    End If
                Else
                    miscare_bila.Enabled = False
                    If vieti = 0 Then
                        If MessageBox.Show("Nu mai ai vieti!", "Pong", MessageBoxButtons.OK) = DialogResult.OK Then
                            miscare_bila.Enabled = False
                            Me.Close()
                        End If
                    End If
                End If


            End If


        End If




        If control_bila.Top + control_bila.Height <= control_obstacol.Top Then
            Dim centrubw1 As Double = control_bila.Left + control_bila.Width / 2
            If centrubw1 >= control_obstacol.Left And centrubw1 <= control_obstacol.Left + control_obstacol.Width Then
                If control_bila.Top + control_bila.Height >= control_obstacol.Top And dy = 1 Then
                    dy = -dy
                End If
            End If
        End If


        If control_bila.Top >= control_obstacol.Top + control_obstacol.Height Then
            Dim centrubw2 As Double = control_bila.Left + control_bila.Width / 2
            If centrubw2 >= control_obstacol.Left And centrubw2 <= control_obstacol.Left + control_obstacol.Width Then
                If control_bila.Top <= control_obstacol.Top + control_obstacol.Height And dy = -1 Then
                    dy = -dy
                End If
            End If
        End If

        If control_bila.Left + control_bila.Width <= control_obstacol.Left Then
            Dim centrubh1 As Double = control_bila.Top + control_bila.Height / 2
            If (centrubh1 >= control_obstacol.Top And centrubh1 <= control_obstacol.Top + control_obstacol.Height) Or (control_bila.Left + control_bila.Width / 2 <= control_obstacol.Top And control_bila.Left + control_bila.Width / 2 >= control_obstacol.Top + control_obstacol.Height) Then
                If control_bila.Left + control_bila.Width >= control_obstacol.Left And dx = 1 Then
                    dx = -dx
                End If
            End If
        End If

        If control_bila.Left >= control_obstacol.Left + control_obstacol.Width Then
            Dim centrubh2 As Double = control_bila.Top + control_bila.Height / 2
            If centrubh2 >= control_obstacol.Top And centrubh2 <= control_obstacol.Top + control_obstacol.Height Then
                If control_bila.Left <= control_obstacol.Left + control_obstacol.Width And dx = -1 Then
                    dx = -dx
                End If
            End If
        End If


        If control_bila.Top + control_bila.Height <= obstacol2.Top Then
            Dim centrubw3 As Double = control_bila.Left + control_bila.Width / 2
            If centrubw3 >= obstacol2.Left And centrubw3 <= obstacol2.Left + obstacol2.Width Then
                If control_bila.Top + control_bila.Height >= obstacol2.Top And dy = 1 Then
                    dy = -dy
                End If
            End If
        End If

        If control_bila.Top >= obstacol2.Top + obstacol2.Height Then
            Dim centrubw4 As Double = control_bila.Left + control_bila.Width / 2
            If centrubw4 >= obstacol2.Left And centrubw4 <= obstacol2.Left + obstacol2.Width Then
                If control_bila.Top <= obstacol2.Top + obstacol2.Height And dy = -1 Then
                    dy = -dy
                End If
            End If
        End If

        If control_bila.Left + control_bila.Width <= obstacol2.Left Then
            Dim centrubh3 As Double = control_bila.Top + control_bila.Height / 2
            If (centrubh3 >= obstacol2.Top And centrubh3 <= obstacol2.Top + obstacol2.Height) Or (control_bila.Left + control_bila.Width / 2 <= obstacol2.Top And control_bila.Left + control_bila.Width / 2 >= obstacol2.Top + obstacol2.Height) Then
                If control_bila.Left + control_bila.Width >= obstacol2.Left And dx = 1 Then
                    dx = -dx
                End If
            End If
        End If


        If control_bila.Left >= obstacol2.Left + obstacol2.Width Then
            Dim centrubh4 As Double = control_bila.Top + control_bila.Height / 2
            If (centrubh4 >= obstacol2.Top And centrubh4 <= obstacol2.Top + obstacol2.Height) Or (control_bila.Left + control_bila.Width / 2 <= obstacol2.Top And control_bila.Left + control_bila.Width / 2 >= obstacol2.Top + obstacol2.Height) Then
                If control_bila.Left <= obstacol2.Left + obstacol2.Width And dx = -1 Then
                    dx = -dx
                End If
            End If
        End If

        control_bila.Left = control_bila.Left + distanta_bila * dx
        control_bila.Top = control_bila.Top + distanta_bila * dy

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 37 Then
            If control_paleta.Left > 0 Then
                control_paleta.Left = control_paleta.Left - distanta_paleta
            End If

        ElseIf e.KeyCode = 39 Then
            If control_paleta.Left + control_paleta.Width < Me.Width Then
                control_paleta.Left = control_paleta.Left + distanta_paleta

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub control_paleta_Click(sender As Object, e As EventArgs) Handles control_paleta.Click

    End Sub
End Class
