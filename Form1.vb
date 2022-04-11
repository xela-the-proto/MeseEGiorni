Imports Microsoft.VisualBasic.Interaction
Public Class frm_giorniMese
    Private Sub txt_mese_TextChanged(sender As Object, e As EventArgs) Handles txt_mese.TextChanged

    End Sub

    Private Sub btn_esci_Click(sender As Object, e As EventArgs) Handles btn_esci.Click
        End
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        txt_mese.Clear()
        lbl_giorni.Text = ""
    End Sub

    Private Sub btn_assegna_Click(sender As Object, e As EventArgs) Handles btn_assegna.Click
        Dim risposta As String
        Select Case txt_mese.Text
            Case "4", "6", "9", "11"
                lbl_giorni.Text = "numero di giorni: 30"
            Case "1", "3", "5", "7", "8", "10", "12"
                lbl_giorni.Text = "numero di giorni: 31"
            Case "2"
                risposta = MessageBox.Show("anno bisestile?", "Caso particolare", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If risposta = MsgBoxResult.Yes Then
                    lbl_giorni.Text = "numero di giorni: 29"
                Else
                    lbl_giorni.Text = "numero di giorni: 28"
                End If
            Case Else
                MessageBox.Show("mese invalido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_mese.Clear()
                lbl_giorni.Text = ""
                txt_mese.Focus()

        End Select
    End Sub
End Class
