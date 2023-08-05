Public Class Form2
    Private Sub WithdrawsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawsToolStripMenuItem.Click
        Withdraws.Show()
    End Sub

    Private Sub BankingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankingToolStripMenuItem.Click
        Banking.Show()
    End Sub

    Private Sub OtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherToolStripMenuItem.Click
        Fother.Show()
    End Sub
End Class