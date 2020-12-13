<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datenaissance = New System.Windows.Forms.DateTimePicker()
        Me.femme = New System.Windows.Forms.RadioButton()
        Me.homme = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inscription = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mdp2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.email2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.connexion = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.inscription, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.connexion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 590)
        Me.Panel1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.closeb)
        Me.Panel4.Controls.Add(Me.minimize)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(833, 53)
        Me.Panel4.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.logoapp1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(634, 398)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 180)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label11.Location = New System.Drawing.Point(305, -4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 48)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Accueil"
        '
        'closeb
        '
        Me.closeb.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.close3
        Me.closeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeb.Location = New System.Drawing.Point(780, -1)
        Me.closeb.Name = "closeb"
        Me.closeb.Size = New System.Drawing.Size(48, 49)
        Me.closeb.TabIndex = 1
        Me.closeb.TabStop = False
        '
        'minimize
        '
        Me.minimize.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.minimize3
        Me.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Location = New System.Drawing.Point(726, -1)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(48, 49)
        Me.minimize.TabIndex = 0
        Me.minimize.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.datenaissance)
        Me.Panel2.Controls.Add(Me.femme)
        Me.Panel2.Controls.Add(Me.homme)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.mdp)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.email)
        Me.Panel2.Controls.Add(Me.prenom)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.nom)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.inscription)
        Me.Panel2.Location = New System.Drawing.Point(10, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 508)
        Me.Panel2.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Location = New System.Drawing.Point(137, 362)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 25)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Mot de passe visible"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Matura MT Script Capitals", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(367, 40)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Créer un nouveau compte"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Date de naissance:"
        '
        'datenaissance
        '
        Me.datenaissance.CalendarFont = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenaissance.Font = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datenaissance.Location = New System.Drawing.Point(136, 394)
        Me.datenaissance.Name = "datenaissance"
        Me.datenaissance.Size = New System.Drawing.Size(250, 29)
        Me.datenaissance.TabIndex = 16
        '
        'femme
        '
        Me.femme.AutoSize = True
        Me.femme.BackColor = System.Drawing.Color.Transparent
        Me.femme.Font = New System.Drawing.Font("Source Sans Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femme.ForeColor = System.Drawing.Color.Gainsboro
        Me.femme.Location = New System.Drawing.Point(277, 195)
        Me.femme.Name = "femme"
        Me.femme.Size = New System.Drawing.Size(110, 34)
        Me.femme.TabIndex = 15
        Me.femme.TabStop = True
        Me.femme.Text = "Femme"
        Me.femme.UseVisualStyleBackColor = False
        '
        'homme
        '
        Me.homme.AutoSize = True
        Me.homme.BackColor = System.Drawing.Color.Transparent
        Me.homme.Font = New System.Drawing.Font("Source Sans Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homme.ForeColor = System.Drawing.Color.Gainsboro
        Me.homme.Location = New System.Drawing.Point(137, 195)
        Me.homme.Name = "homme"
        Me.homme.Size = New System.Drawing.Size(115, 34)
        Me.homme.TabIndex = 14
        Me.homme.TabStop = True
        Me.homme.Text = "Homme"
        Me.homme.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(44, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Genre:"
        '
        'mdp
        '
        Me.mdp.Font = New System.Drawing.Font("Source Sans Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdp.Location = New System.Drawing.Point(136, 326)
        Me.mdp.Name = "mdp"
        Me.mdp.Size = New System.Drawing.Size(251, 30)
        Me.mdp.TabIndex = 12
        Me.mdp.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(0, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mot de passe:"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Source Sans Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(137, 263)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(249, 30)
        Me.email.TabIndex = 10
        '
        'prenom
        '
        Me.prenom.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(137, 132)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(249, 36)
        Me.prenom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(47, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Prénom:"
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(137, 65)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(249, 36)
        Me.nom.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(60, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nom:"
        '
        'inscription
        '
        Me.inscription.BackColor = System.Drawing.Color.Transparent
        Me.inscription.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.boutonins
        Me.inscription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inscription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inscription.Location = New System.Drawing.Point(110, 445)
        Me.inscription.Name = "inscription"
        Me.inscription.Size = New System.Drawing.Size(153, 48)
        Me.inscription.TabIndex = 4
        Me.inscription.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.mdp2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.email2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.connexion)
        Me.Panel3.Location = New System.Drawing.Point(429, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(394, 293)
        Me.Panel3.TabIndex = 6
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox2.Location = New System.Drawing.Point(132, 179)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(169, 25)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Mot de passe visible"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Matura MT Script Capitals", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(44, -2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 44)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Connectez-Vous"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mdp2
        '
        Me.mdp2.Font = New System.Drawing.Font("Source Sans Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdp2.Location = New System.Drawing.Point(132, 147)
        Me.mdp2.Name = "mdp2"
        Me.mdp2.Size = New System.Drawing.Size(249, 30)
        Me.mdp2.TabIndex = 18
        Me.mdp2.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(3, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mot de passe:"
        '
        'email2
        '
        Me.email2.Font = New System.Drawing.Font("Source Sans Pro", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email2.Location = New System.Drawing.Point(132, 83)
        Me.email2.Name = "email2"
        Me.email2.Size = New System.Drawing.Size(249, 30)
        Me.email2.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(47, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 27)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Email:"
        '
        'connexion
        '
        Me.connexion.BackColor = System.Drawing.Color.Transparent
        Me.connexion.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.boutoncnx3_1
        Me.connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.connexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.connexion.Location = New System.Drawing.Point(121, 224)
        Me.connexion.Name = "connexion"
        Me.connexion.Size = New System.Drawing.Size(153, 48)
        Me.connexion.TabIndex = 3
        Me.connexion.TabStop = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(837, 590)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(50, 50)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.inscription, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.connexion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents connexion As PictureBox
    Friend WithEvents inscription As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mdp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents homme As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents femme As RadioButton
    Friend WithEvents datenaissance As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents mdp2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents email2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents closeb As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
