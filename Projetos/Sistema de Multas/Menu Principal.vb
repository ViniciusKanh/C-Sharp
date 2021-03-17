Public Class Menu_Principal
    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

    End Sub

    Private Sub MultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultaToolStripMenuItem.Click

    End Sub

    Private Sub RESAMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RESAMToolStripMenuItem1.Click
        RESAM.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StatusDeJulgamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusDeJulgamentoToolStripMenuItem.Click
        C_StatusdeJulgamento.Show()
    End Sub
End Class