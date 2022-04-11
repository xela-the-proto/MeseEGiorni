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
        Dim risposta As Short
        Select Case txt_mese.Text
            Case ""
        End Select
    End Sub
End Class
