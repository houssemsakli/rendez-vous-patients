Imports System.Data.OleDb

Public Class ModifierRendezVous1

    Dim mouse_move As System.Drawing.Point

    Private Sub modifierrendezvous(ByVal idc As Integer)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drRendezVous As OleDbDataReader
        Dim cmdRendezVous As New OleDbCommand
        Dim str As String
        Dim typec As String = Nothing
        typec = Convert.ToString(type.SelectedItem)
        str = String.Concat("UPDATE rendezvous SET type='", typec, "', daterendezvous='", daterendezvous.Value.Date, "' WHERE id=", idc)
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
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

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

    Private Sub modifier_MouseEnter(sender As Object, e As EventArgs) Handles modifier.MouseEnter
        modifier.BackgroundImage = My.Resources.boutonmodifier2
    End Sub

    Private Sub modifier_MouseLeave(sender As Object, e As EventArgs) Handles modifier.MouseLeave
        modifier.BackgroundImage = My.Resources.boutonmodifier
    End Sub

    Private Sub annuler_MouseEnter(sender As Object, e As EventArgs) Handles annuler.MouseEnter
        annuler.BackgroundImage = My.Resources.boutonannuler2
    End Sub

    Private Sub annuler_MouseLeave(sender As Object, e As EventArgs) Handles annuler.MouseLeave
        annuler.BackgroundImage = My.Resources.boutonannuler
    End Sub

    Private Sub closeb_Click(sender As Object, e As EventArgs) Handles closeb.Click
        Me.Close()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        Me.Close()
    End Sub

    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        If Not (type.SelectedIndex = 0 Or type.SelectedItem = Nothing) Then
            modifierrendezvous(cnxid)
            MsgBox("Rendez-vous modifié avec succès !", vbDefaultButton1, "Succès")
            Me.Close()
        Else
            MsgBox("Vérifier tous les champs !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub ModifierRendezVous1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cin.Text = cnxcin
        id.Text = cnxid
        type.SelectedItem = cnxtype
        daterendezvous.Value = cnxdaterendezvous
    End Sub
End Class