Imports System.Data.OleDb

Public Class SupprimerRendezVous1

    Dim mouse_move As System.Drawing.Point

    Private Sub supprimerrendezvous(ByVal idc As Integer)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drRendezVous As OleDbDataReader
        Dim cmdRendezVous As New OleDbCommand
        Dim str As String
        str = String.Concat("DELETE FROM rendezvous WHERE id=", idc)
        cmdRendezVous.CommandText = str
        cmdRendezVous.Connection = cn

        Try
            drRendezVous = cmdRendezVous.ExecuteReader
            cmdRendezVous.Dispose()
            cn.Close()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Navigateur.afficherendez(cnxcin)
    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel4.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub



    Private Sub closeb_Click(sender As Object, e As EventArgs) Handles closeb.Click
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeb_MouseEnter(sender As Object, e As EventArgs) Handles closeb.MouseEnter
        closeb.BackgroundImage = My.Resources.close3v2
    End Sub

    Private Sub closeb_MouseLeave(sender As Object, e As EventArgs) Handles closeb.MouseLeave
        closeb.BackgroundImage = My.Resources.close3
    End Sub

    Private Sub minimize_MouseEnter(sender As Object, e As EventArgs) Handles minimize.MouseEnter
        minimize.BackgroundImage = My.Resources.minimize3v2
    End Sub

    Private Sub minimize_MouseLeave(sender As Object, e As EventArgs) Handles minimize.MouseLeave
        minimize.BackgroundImage = My.Resources.minimize3
    End Sub

    Private Sub non_Click(sender As Object, e As EventArgs) Handles non.Click
        Me.Close()
    End Sub

    Private Sub oui_Click(sender As Object, e As EventArgs) Handles oui.Click
        supprimerrendezvous(cnxid)
        MsgBox("Rendez-vous supprimé avec succès !", vbDefaultButton1, "Succès")
        Me.Close()
    End Sub

    Private Sub oui_MouseEnter(sender As Object, e As EventArgs) Handles oui.MouseEnter
        oui.BackColor = Color.Turquoise
        oui.ForeColor = Color.MidnightBlue
    End Sub

    Private Sub oui_MouseLeave(sender As Object, e As EventArgs) Handles oui.MouseLeave
        oui.BackColor = Color.LightBlue
        oui.ForeColor = Color.Navy
    End Sub

    Private Sub non_MouseEnter(sender As Object, e As EventArgs) Handles non.MouseEnter
        non.BackColor = Color.Salmon
        non.ForeColor = Color.Maroon
    End Sub

    Private Sub non_MouseLeave(sender As Object, e As EventArgs) Handles non.MouseLeave
        non.BackColor = Color.MistyRose
        non.ForeColor = Color.Brown
    End Sub
End Class