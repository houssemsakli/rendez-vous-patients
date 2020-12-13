Imports System.Data.OleDb

Public Class Navigateur
    Dim tablepatients As New DataTable
    Dim tablerendezvous As New DataTable
    Dim mouse_move As System.Drawing.Point
    Public Sub affichepatients(ByVal email As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drPatients As OleDbDataReader
        Dim cmdPatients As New OleDbCommand
        Dim str As String
        str = String.Concat("SELECT * FROM patients WHERE email='", email, "'")
        cmdPatients.CommandText = str
        cmdPatients.Connection = cn
        drPatients = cmdPatients.ExecuteReader
        tablepatients.Clear()
        tablepatients.Columns.Clear()

        tablepatients.Columns.Add("CIN", System.Type.GetType("System.String"))
        tablepatients.Columns.Add("Nom", System.Type.GetType("System.String"))
        tablepatients.Columns.Add("Prénom", System.Type.GetType("System.String"))
        tablepatients.Columns.Add("Genre", System.Type.GetType("System.String"))
        tablepatients.Columns.Add("Date d'ajout", System.Type.GetType("System.DateTime"))

        While drPatients.Read

            Dim newrow As DataRow = tablepatients.NewRow
            newrow("CIN") = drPatients.GetValue(0)
            newrow("Nom") = drPatients.GetValue(1)
            newrow("Prénom") = drPatients.GetValue(2)
            newrow("Genre") = drPatients.GetValue(3)
            newrow("Date d'ajout") = drPatients.GetValue(4)
            tablepatients.Rows.Add(newrow)

        End While
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = tablepatients
        cn.Close()
        cn = Nothing
    End Sub

    Public Sub afficherendez(ByVal cin As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drRendezVous As OleDbDataReader
        Dim cmdRendezVous As New OleDbCommand
        Dim str As String
        str = String.Concat("SELECT * FROM rendezvous WHERE cin=", cin)
        cmdRendezVous.CommandText = str
        cmdRendezVous.Connection = cn
        drRendezVous = cmdRendezVous.ExecuteReader
        tablerendezvous.Clear()
        tablerendezvous.Columns.Clear()

        tablerendezvous.Columns.Add("ID", System.Type.GetType("System.String"))
        tablerendezvous.Columns.Add("Type", System.Type.GetType("System.String"))
        tablerendezvous.Columns.Add("Date de rendez-vous", System.Type.GetType("System.DateTime"))

        While drRendezVous.Read

            Dim newrow As DataRow = tablerendezvous.NewRow
            newrow("ID") = drRendezVous.GetValue(0)
            newrow("Type") = drRendezVous.GetValue(1)
            newrow("Date de rendez-vous") = drRendezVous.GetValue(2)
            tablerendezvous.Rows.Add(newrow)

        End While
        DataGridView2.DataSource = Nothing
        DataGridView2.DataSource = tablerendezvous
        cn.Close()
        cn = Nothing
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
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeb_Click(sender As Object, e As EventArgs) Handles closeb.Click
        Me.Close()
        Accueil.Close()
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

    Private Sub Label1_Paint(sender As Object, e As PaintEventArgs) Handles Label1.Paint
        Label1.Text = "Bienvenue " + cnxprenomcompte + " " + cnxnomcompte + ","
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles patients.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        affichepatients(cnxemail)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        email.Text = cnxemail
        nom.Text = cnxnomcompte
        prenom.Text = cnxprenomcompte
        If cnxgenrecompte = "Homme" Then
            homme.Checked = True
        End If
        If cnxgenrecompte = "Femme" Then
            femme.Checked = True
        End If
        datenaissance.Value = cnxdatenaissance
    End Sub

    Private Sub Navigateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Navigateur_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub deconnexion_Click(sender As Object, e As EventArgs) Handles deconnexion.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub deconnexion_MouseEnter(sender As Object, e As EventArgs) Handles deconnexion.MouseEnter
        deconnexion.BackColor = Color.FromArgb(200, 85, 29, 128)
        deconnexion.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub deconnexion_MouseLeave(sender As Object, e As EventArgs) Handles deconnexion.MouseLeave
        deconnexion.ForeColor = Color.Indigo
        deconnexion.BackColor = Color.Thistle
    End Sub

    Private Sub ajouterpatient_MouseEnter(sender As Object, e As EventArgs) Handles ajouterpatient.MouseEnter
        ajouterpatient.ForeColor = Color.GhostWhite
        ajouterpatient.BackColor = Color.DarkGreen
    End Sub

    Private Sub ajouterpatient_MouseLeave(sender As Object, e As EventArgs) Handles ajouterpatient.MouseLeave
        ajouterpatient.ForeColor = Color.DarkGreen
        ajouterpatient.BackColor = Color.Honeydew
    End Sub

    Private Sub modifierpatient_MouseLeave(sender As Object, e As EventArgs) Handles modifierpatient.MouseLeave
        modifierpatient.BackColor = Color.Lavender
        modifierpatient.ForeColor = Color.DarkBlue
    End Sub

    Private Sub modifierpatient_MouseEnter(sender As Object, e As EventArgs) Handles modifierpatient.MouseEnter
        modifierpatient.BackColor = Color.DarkBlue
        modifierpatient.ForeColor = Color.Lavender
    End Sub

    Private Sub supprimerpatient_MouseLeave(sender As Object, e As EventArgs) Handles supprimerpatient.MouseLeave
        supprimerpatient.ForeColor = Color.Crimson
        supprimerpatient.BackColor = Color.LavenderBlush
    End Sub

    Private Sub supprimerpatient_MouseEnter(sender As Object, e As EventArgs) Handles supprimerpatient.MouseEnter
        supprimerpatient.ForeColor = Color.LavenderBlush
        supprimerpatient.BackColor = Color.Crimson
    End Sub

    Private Sub supprimerrendezvous_MouseEnter(sender As Object, e As EventArgs) Handles supprimerrendezvous.MouseEnter
        supprimerrendezvous.ForeColor = Color.LavenderBlush
        supprimerrendezvous.BackColor = Color.Crimson
    End Sub

    Private Sub supprimerrendezvous_MouseLeave(sender As Object, e As EventArgs) Handles supprimerrendezvous.MouseLeave
        supprimerrendezvous.ForeColor = Color.Crimson
        supprimerrendezvous.BackColor = Color.LavenderBlush
    End Sub

    Private Sub modifierrendezvous_MouseLeave(sender As Object, e As EventArgs) Handles modifierrendezvous.MouseLeave
        modifierrendezvous.BackColor = Color.Lavender
        modifierrendezvous.ForeColor = Color.DarkBlue
    End Sub

    Private Sub modifierrendezvous_MouseEnter(sender As Object, e As EventArgs) Handles modifierrendezvous.MouseEnter
        modifierrendezvous.BackColor = Color.DarkBlue
        modifierrendezvous.ForeColor = Color.Lavender
    End Sub

    Private Sub ajouterrendezvous_MouseEnter(sender As Object, e As EventArgs) Handles ajouterrendezvous.MouseEnter
        ajouterrendezvous.ForeColor = Color.GhostWhite
        ajouterrendezvous.BackColor = Color.DarkGreen
    End Sub

    Private Sub ajouterrendezvous_MouseLeave(sender As Object, e As EventArgs) Handles ajouterrendezvous.MouseLeave
        ajouterrendezvous.ForeColor = Color.DarkGreen
        ajouterrendezvous.BackColor = Color.Honeydew
    End Sub

    Private Sub ajouterpatient_Click(sender As Object, e As EventArgs) Handles ajouterpatient.Click
        AjouterPatient1.Show()
    End Sub

    Private Sub modifierpatient_Click(sender As Object, e As EventArgs) Handles modifierpatient.Click
        If Not cnxcin = Nothing Then
            ModifierPatient1.Show()
        Else
            MsgBox("Sélectionner un Patient tout d'abord !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub supprimerpatient_Click(sender As Object, e As EventArgs) Handles supprimerpatient.Click
        If Not cnxcin = Nothing Then
            SupprimerPatient1.Show()
        Else
            MsgBox("Sélectionner un Patient tout d'abord !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub ajouterrendezvous_Click(sender As Object, e As EventArgs) Handles ajouterrendezvous.Click
        If Not cnxcin = Nothing Then
            AjouterRendezVous1.Show()
        Else
            MsgBox("Sélectionner un Patient tout d'abord !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub modifierrendezvous_Click(sender As Object, e As EventArgs) Handles modifierrendezvous.Click
        If Not cnxid = Nothing Then
            ModifierRendezVous1.Show()
        Else
            MsgBox("Sélectionner un rendez-vous tout d'abord !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim valueid As Object = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        Dim id As Integer = CType(valueid, Integer)
        cnxid = id
        Dim valuetype As Object = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        Dim type As String = CType(valuetype, String)
        cnxtype = type
        Dim valuedaterendezvous As Object = DataGridView2.Rows(e.RowIndex).Cells(2).Value
        Dim daterendezvous As Date = CType(valuedaterendezvous, Date)
        cnxdaterendezvous = daterendezvous
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Dim cinc As String = CType(value, String)
        afficherendez(cinc)
        cnxcin = cinc
        Dim valuenom As Object = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Dim nom As String = CType(valuenom, String)
        cnxnom = nom
        Dim valueprenom As Object = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Dim prenom As String = CType(valueprenom, String)
        cnxprenom = prenom
        Dim valuegenre As Object = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Dim genre As String = CType(valuegenre, String)
        cnxgenre = genre
        Dim valuedate As Object = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Dim dateajout As Date = CType(valuedate, Date)
        cnxdateajout = dateajout
        Label3.Text = "Les Rendez-Vous de " + prenom + " " + nom
    End Sub

    Private Sub supprimerrendezvous_Click(sender As Object, e As EventArgs) Handles supprimerrendezvous.Click
        If Not cnxid = Nothing Then
            SupprimerRendezVous1.Show()
        Else
            MsgBox("Sélectionner un rendez-vous tout d'abord !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub modifiercompte(ByVal emailc As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drComptes As OleDbDataReader
        Dim cmdComptes As New OleDbCommand
        Dim str As String
        Dim genrec As String = Nothing
        If homme.Checked Then
            genrec = "Homme"
        End If
        If femme.Checked Then
            genrec = "Femme"
        End If
        str = String.Concat("UPDATE comptesinscrits SET nom='", nom.Text, "', prenom='", prenom.Text, "', genre='", genrec, "', datenaissance='", datenaissance.Value.Date, "' WHERE email='", emailc, "'")
        cmdComptes.CommandText = str
        cmdComptes.Connection = cn

        Try
            drComptes = cmdComptes.ExecuteReader
            cmdComptes.Dispose()
            cn.Close()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub modifiermdp(ByVal emailc As String, ByVal mdpc As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drComptes As OleDbDataReader
        Dim cmdComptes As New OleDbCommand
        Dim str As String
        str = String.Concat("UPDATE comptesinscrits SET mdp='", mdpnouveau.Text, "' WHERE email='", emailc, "'")
        cmdComptes.CommandText = str
        cmdComptes.Connection = cn

        Try
            drComptes = cmdComptes.ExecuteReader
            cmdComptes.Dispose()
            cn.Close()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function validnom(ByVal x As String) As Boolean
        For i = 1 To x.Length - 1
            If Not (Char.IsLetter(x(i))) Then
                Return False
            End If
        Next
        If (x.Length < 3) Then
            Return False
        End If
        Return True

    End Function

    Private Sub enregistrer_Click(sender As Object, e As EventArgs) Handles enregistrer.Click
        If (validnom(nom.Text) And validnom(prenom.Text) And (homme.Checked Or femme.Checked)) Then
            modifiercompte(cnxemail)
            cnxnomcompte = nom.Text
            cnxprenomcompte = prenom.Text
            Label1.Text = "Bienvenue " + cnxprenomcompte + " " + cnxnomcompte + ","
            MsgBox("Compte modifié avec succès !", vbDefaultButton1, "Succès")
        Else
            MsgBox("Vérifier tous les champs !", vbDefaultButton1, "Erreur")
        End If
    End Sub

    Private Sub enregistrer_MouseEnter(sender As Object, e As EventArgs) Handles enregistrer.MouseEnter
        enregistrer.BackgroundImage = My.Resources.boutonenregistrer2
    End Sub

    Private Sub enregistrer_MouseLeave(sender As Object, e As EventArgs) Handles enregistrer.MouseLeave
        enregistrer.BackgroundImage = My.Resources.boutonenregistrer
    End Sub

    Private Sub enregistrermdp_MouseEnter(sender As Object, e As EventArgs) Handles enregistrermdp.MouseEnter
        enregistrermdp.BackgroundImage = My.Resources.boutonenregistrer2
    End Sub

    Private Sub enregistrermdp_MouseLeave(sender As Object, e As EventArgs) Handles enregistrermdp.MouseLeave
        enregistrermdp.BackgroundImage = My.Resources.boutonenregistrer
    End Sub

    Private Sub enregistrermdp_Click(sender As Object, e As EventArgs) Handles enregistrermdp.Click
        If (mdpnouveau.Text.Length >= 6 And cnxmdp = mdpactuel.Text And mdpnouveau.Text = mdpconfirmer.Text) Then
            modifiermdp(cnxemail, mdpconfirmer.Text)
            cnxmdp = mdpconfirmer.Text
            MsgBox("Mot de passe modifié avec succès !", vbDefaultButton1, "Succès")
            mdpactuel.Clear()
            mdpnouveau.Clear()
            mdpconfirmer.Clear()
        Else
            If Not (mdpactuel.Text = cnxmdp) Then
                MsgBox("Mot de passe actuel incorrect !", vbDefaultButton1, "Erreur")
            Else
                If (mdpnouveau.Text.Length < 6) Then
                    MsgBox("Le nouveau mot de passe doit contenir au moins 6 caractères !", vbDefaultButton1, "Erreur")
                Else
                    If Not (mdpnouveau.Text = mdpconfirmer.Text) Then
                        MsgBox("Le champ nouveau mot de passe et le champ confirmer mot de passe ne sont pas identiques !", vbDefaultButton1, "Erreur")
                    Else
                        MsgBox("Vérifier tout les champs !", vbDefaultButton1, "Erreur")
                    End If
                End If
            End If
        End If
    End Sub
End Class