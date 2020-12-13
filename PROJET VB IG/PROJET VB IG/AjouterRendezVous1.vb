Imports System.Data.OleDb

Public Class AjouterRendezVous1

    Dim mouse_move As System.Drawing.Point

    Private Sub ajoutrendezvous(ByVal cinc As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim str As String
        str = "INSERT INTO rendezvous(type,daterendezvous,cin) VALUES(?,?,?)"
        Dim cmdRendezVous As New OleDbCommand(str, cn)
        Dim typec As String = Nothing
        typec = Convert.ToString(type.SelectedItem)

        cmdRendezVous.Parameters.Add(New OleDbParameter("type", CType(typec, String)))
        cmdRendezVous.Parameters.Add(New OleDbParameter("daterendezvous", CType(daterendezvous.Value.Date, Date)))
        cmdRendezVous.Parameters.Add(New OleDbParameter("cin", CType(cinc, Integer)))

        Try
            cmdRendezVous.ExecuteNonQuery()
            cmdRendezVous.Dispose()
            cn.Close()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Navigateur.afficherendez(cinc)
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

    Private Sub ajouter_MouseEnter(sender As Object, e As EventArgs) Handles ajouter.MouseEnter
        ajouter.BackgroundImage = My.Resources.boutonajout3
    End Sub

    Private Sub ajouter_MouseLeave(sender As Object, e As EventArgs) Handles ajouter.MouseLeave
        ajouter.BackgroundImage = My.Resources.boutonajout2
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

    Private Sub ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        If Not (type.SelectedIndex = 0 Or type.SelectedItem = Nothing) Then
            ajoutrendezvous(cnxcin)
            MsgBox("Rendez-vous ajouté avec succès !", vbDefaultButton1, "Succès")
            Me.Close()
        Else
            MsgBox("Vérifier tous les champs !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub AjouterRendezVous1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cin.Text = cnxcin
        type.SelectedIndex = 0
    End Sub
End Class