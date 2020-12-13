Imports System.Data.OleDb

Public Class Accueil
    Dim mouse_move As System.Drawing.Point
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub connexion_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub connexion_MouseEnter(sender As Object, e As EventArgs)
        connexion.BackgroundImage = My.Resources.boutoncnxv2
        connexion.BackColor = Color.Transparent
    End Sub

    Private Sub connexion_MouseLeave(sender As Object, e As EventArgs)
        connexion.BackgroundImage = My.Resources.boutoncnx3_1
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles connexion.MouseEnter
        connexion.BackgroundImage = My.Resources.boutoncnxv2
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles connexion.MouseLeave
        connexion.BackgroundImage = My.Resources.boutoncnx3_1
    End Sub

    Private Sub inscription_MouseEnter(sender As Object, e As EventArgs) Handles inscription.MouseEnter
        inscription.BackgroundImage = My.Resources.boutoninsv2
    End Sub

    Private Sub inscription_MouseLeave(sender As Object, e As EventArgs) Handles inscription.MouseLeave
        inscription.BackgroundImage = My.Resources.boutonins
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.BackColor = Color.FromArgb(70, 192, 255, 192)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Panel3.BackColor = Color.FromArgb(70, 230, 235, 174)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            mdp.UseSystemPasswordChar = False
        Else
            mdp.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            mdp2.UseSystemPasswordChar = False
        Else
            mdp2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ajoutcompte()
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim str As String
        str = "INSERT INTO comptesinscrits(email,nom,prenom,genre,mdp,datenaissance) VALUES(?,?,?,?,?,?)"
        Dim cmdComptes As New OleDbCommand(str, cn)
        Dim genrec As String = Nothing
        If homme.Checked Then
            genrec = "Homme"
        End If
        If femme.Checked Then
            genrec = "Femme"
        End If
        cmdComptes.Parameters.Add(New OleDbParameter("email", CType(email.Text, String)))
        cmdComptes.Parameters.Add(New OleDbParameter("nom", CType(nom.Text, String)))
        cmdComptes.Parameters.Add(New OleDbParameter("prenom", CType(prenom.Text, String)))
        cmdComptes.Parameters.Add(New OleDbParameter("genre", CType(genrec, String)))
        cmdComptes.Parameters.Add(New OleDbParameter("mdp", CType(mdp.Text, String)))
        cmdComptes.Parameters.Add(New OleDbParameter("datenaissance", CType(datenaissance.Value.Date, Date)))
        Try
            cmdComptes.ExecuteNonQuery()
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

    Private Function validemail(ByVal x As String) As Boolean

        If Not (x.Length >= 8 And x.Contains("@") And x.Contains(".")) Then
            Return False
        End If
        Return True

    End Function

    Private Function emailexist(ByVal x As String) As Boolean
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drComptes As OleDbDataReader
        Dim cmdComptes As New OleDbCommand
        cmdComptes.CommandText = "SELECT * FROM comptesinscrits"
        cmdComptes.Connection = cn
        drComptes = cmdComptes.ExecuteReader
        While drComptes.Read
            If (drComptes.GetValue(0) = x) Then
                Return True
            End If
        End While
        cn.Close()
        cn = Nothing
        Return False
    End Function

    Public Sub changecnx(ByVal x As String)
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drComptes As OleDbDataReader
        Dim cmdComptes As New OleDbCommand
        cmdComptes.CommandText = "SELECT * FROM comptesinscrits"
        cmdComptes.Connection = cn
        drComptes = cmdComptes.ExecuteReader
        While drComptes.Read
            If (drComptes.GetValue(0) = x) Then
                cnxnomcompte = drComptes.GetValue(1)
                cnxprenomcompte = drComptes.GetValue(2)
                cnxgenrecompte = drComptes.GetValue(3)
                cnxdatenaissance = drComptes.GetValue(5)
            End If
        End While
        cn.Close()
        cn = Nothing
    End Sub

    Private Function verifycnx(ByVal xemail As String, ByVal xmdp As String) As Boolean
        Dim cn As OleDbConnection
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ProjetVB.accdb"
        cn.Open()
        Dim drComptes As OleDbDataReader
        Dim cmdComptes As New OleDbCommand
        cmdComptes.CommandText = "SELECT * FROM comptesinscrits"
        cmdComptes.Connection = cn
        drComptes = cmdComptes.ExecuteReader
        While drComptes.Read
            If (drComptes.GetValue(0) = xemail And drComptes.GetValue(4) = xmdp) Then
                Return True
            End If
        End While
        cn.Close()
        cn = Nothing
        Return False
    End Function

    Private Sub inscription_Click(sender As Object, e As EventArgs) Handles inscription.Click
        If (validnom(nom.Text) And validnom(prenom.Text) And validemail(email.Text) And mdp.Text.Length >= 6 And (homme.Checked Or femme.Checked) And emailexist(email.Text) = False) Then
            ajoutcompte()
            nom.Clear()
            prenom.Clear()
            email.Clear()
            mdp.Clear()
            MsgBox("Votre compte a été créé avec succès !", vbDefaultButton1, "Succès")
        Else
            If (emailexist(email.Text) = True) Then
                MsgBox("Un compte avec cet email existe déja !", vbDefaultButton1, "Erreur")
            Else
                MsgBox("Vérifier tous les champs !", vbDefaultButton1, "Erreur")
            End If
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeb.Click
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

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub connexion_Click(sender As Object, e As EventArgs) Handles connexion.Click
        If (verifycnx(email2.Text, mdp2.Text) = True) Then
            Me.Hide()
            Navigateur.Show()
            cnxemail = email2.Text
            cnxmdp = mdp2.Text
            changecnx(cnxemail)
            email2.Clear()
            mdp2.Clear()

        Else
            MsgBox("Email ou Mot de passe incorrect !", vbDefaultButton1, "Erreur")
        End If
    End Sub
End Class
