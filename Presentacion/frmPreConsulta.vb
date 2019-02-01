Public Class frmPreConsulta


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        If (TextFolioV.Text = "") Then
            MessageBox.Show("Ingresa algún Folio de Venta", "No se escribió nada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            consultaventa = TextFolioV.Text
            frmConsultaVenta.MdiParent = frmMenu
            frmConsultaVenta.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub TextFolioV_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFolioV.KeyDown
        Select e.KeyData
            Case Keys.Enter
                If (TextFolioV.Text = "") Then
                    MessageBox.Show("Ingresa algún Folio de Venta", "No se escribió nada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    consultaventa = TextFolioV.Text
                    frmConsultaVenta.MdiParent = frmMenu
                    frmConsultaVenta.Show()
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub btBuscar_MouseHover(sender As Object, e As EventArgs) Handles btBuscar.MouseHover
        btBuscar.Size = New Size(126, 38)
    End Sub

    Private Sub btBuscar_MouseLeave(sender As Object, e As EventArgs) Handles btBuscar.MouseLeave
        btBuscar.Size = New Size(123, 35)
    End Sub

    Private Sub btCancelar_MouseHover(sender As Object, e As EventArgs) Handles btCancelar.MouseHover
        btCancelar.Size = New Size(126, 38)
    End Sub

    Private Sub btCancelar_MouseLeave(sender As Object, e As EventArgs) Handles btCancelar.MouseLeave
        btCancelar.Size = New Size(123, 35)
    End Sub
End Class