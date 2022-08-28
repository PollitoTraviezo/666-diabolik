Public Class Form1

    Private Sub Btn_aceptar_Click(sender As Object, e As EventArgs) Handles Btn_aceptar.Click
        If TB_a.Text.Length = 0 Then
            MsgBox("El coeficiente A esta vacio")
            TB_a.Text = ""
            TB_a.Focus()
        Else
            If Not IsNumeric(TB_a.Text) Then
                MsgBox("El coeficiente A debe ser númerico")
                TB_a.Text = ""
                TB_a.Focus()
            Else
                If TB_b.Text.Length = 0 Then
                    MsgBox("El coeficiente B esta vacio")
                    TB_b.Text = ""
                    TB_b.Focus()
                Else
                    If Not IsNumeric(TB_b.Text) Then
                        MsgBox("El coeficiente B debe ser númerico")
                        TB_b.Text = ""
                        TB_b.Focus()
                    Else
                        If TB_c.Text.Length = 0 Then
                            MsgBox("El coeficiente C esta vacio")
                            TB_c.Text = ""
                            TB_c.Focus()
                        Else
                            If Not IsNumeric(TB_c.Text) Then
                                MsgBox("El coeficiente C debe ser númerico")
                                TB_c.Text = ""
                                TB_c.Focus()
                            Else
                                Dim a, b, c, X1, X2
                                a = Val(TB_a.Text)
                                b = Val(TB_b.Text)
                                c = Val(TB_c.Text)
                                X1 = Val(TB_X1.Text)
                                X2 = Val(TB_X2.Text)
                                If a = 0 Then
                                    MsgBox("Error de división por cero")
                                Else
                                    If (Math.Pow(b, 2) < 4 * a * c) Then
                                        MsgBox("Las raices son imaginarias")
                                    Else
                                        X1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)
                                        X2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a)
                                        TB_X1.Text = X1
                                        TB_X2.Text = X2

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btn_limpiar_Click(sender As Object, e As EventArgs) Handles Btn_limpiar.Click
        TB_a.Text = ""
        TB_b.Text = ""
        TB_c.Text = ""
        TB_X1.Text = ""
        TB_X2.Text = ""

    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click
        Close()
    End Sub
End Class
