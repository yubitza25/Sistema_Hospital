﻿Public Class FrmListarPacientes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim AgregarPaciente As New FrmAgregarPaciente
        AgregarPaciente.ShowDialog()
    End Sub
End Class