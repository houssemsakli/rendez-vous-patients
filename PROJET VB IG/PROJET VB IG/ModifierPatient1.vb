Imports System.Data.OleDb

Public Class ModifierPatient1

    Dim mouse_move As System.Drawing.Point

    Private Sub modifierpatient(ByVal emailc As String, ByVal cinc As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drPatients As OleDbDataReader
        Dim cmdPatients As New OleDbCommand
        Dim str As String
        Dim genrec As String = Nothing
        If homme.Checked Then
            genrec = "Homme"
        End If
        If femme.Checked Then
            genrec = "Femme"
        End If
        str = String.Concat("UPDATE patients SET cin=", cin.Text, ", nom='", nom.Text, "', prenom='", prenom.Text, "', genre='", genrec, "', dateajout='", dateajout.Value.Date, "' WHERE cin=", cinc)
        cmdPatients.CommandText = str
        cmdPatients.Connection = cn

        Try
            drPatients = cmdPatients.ExecuteReader
            cmdPatients.Dispose()
            cn.Close()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        modifiercinrendezvous(cinc)
        Navigateur.affichepatients(cnxemail)
    End Sub
    Private Sub modifiercinrendezvous(ByVal cinc As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drRendezVous As OleDbDataReader
        Dim cmdRendezVous As New OleDbCommand
        Dim str As String

        str = String.Concat("UPDATE rendezvous SET cin=", cin.Text, " WHERE cin=", cinc)
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
    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

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

    Private Function validcin(ByVal x As String) As Boolean
        For i = 1 To x.Length - 1
            If Not (Char.IsDigit(x(i))) Then
                Return False
            End If
        Next
        If (x.Length <> 8) Then
            Return False
        End If
        Return True
    End Function

    Private Function cinexist(ByVal x As String) As Boolean
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drPatients As OleDbDataReader
        Dim cmdPatients As New OleDbCommand
        cmdPatients.CommandText = "SELECT * FROM patients"
        cmdPatients.Connection = cn
        drPatients = cmdPatients.ExecuteReader
        If x = Nothing Then
            Return False
        End If
        While drPatients.Read
            If (drPatients.GetValue(0) = x) Then
                Return True
            End If
        End While
        cn.Close()
        cn = Nothing
        Return False
    End Function
    Private Sub modifier_Click(sender As Object, e As EventArgs) Handles modifier.Click
        If (validnom(nom.Text) And validnom(prenom.Text) And validcin(cin.Text) And (homme.Checked Or femme.Checked) And (cinexist(cin.Text) = False Or cin.Text = cnxcin)) Then
            modifierpatient(cnxemail, cnxcin)
            MsgBox("Patient modifié avec succès !", vbDefaultButton1, "Succès")
            Me.Close()
        Else
            If (cinexist(cin.Text) = True And cnxcin = cin.Text) Then
                MsgBox("Un patient avec ce CIN existe déja !", vbDefaultButton1, "Erreur")
            Else
                MsgBox("Vérifier tous les champs !", vbDefaultButton1, "Erreur")
            End If
        End If
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
    Private Sub ModifierPatient1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cin.Text = cnxcin
        nom.Text = cnxnom
        prenom.Text = cnxprenom
        If cnxgenre = "Homme" Then
            homme.Checked = True
        End If
        If cnxgenre = "Femme" Then
            femme.Checked = True
        End If
        dateajout.Value = cnxdateajout
    End Sub

End Class