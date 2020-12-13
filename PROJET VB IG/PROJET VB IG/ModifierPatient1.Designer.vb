<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifierPatient1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifierPatient1))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.annuler = New System.Windows.Forms.PictureBox()
        Me.modifier = New System.Windows.Forms.PictureBox()
        Me.dateajout = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.femme = New System.Windows.Forms.RadioButton()
        Me.homme = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.annuler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modifier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.closeb)
        Me.Panel4.Controls.Add(Me.minimize)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(474, 53)
        Me.Panel4.TabIndex = 8
        '
        'closeb
        '
        Me.closeb.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.close3
        Me.closeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeb.Location = New System.Drawing.Point(413, -2)
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
        Me.minimize.Location = New System.Drawing.Point(359, -2)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(48, 49)
        Me.minimize.TabIndex = 0
        Me.minimize.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label11.Location = New System.Drawing.Point(3, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(330, 37)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Modifier Patient"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.annuler)
        Me.Panel1.Controls.Add(Me.modifier)
        Me.Panel1.Controls.Add(Me.dateajout)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.femme)
        Me.Panel1.Controls.Add(Me.homme)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.prenom)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 397)
        Me.Panel1.TabIndex = 9
        '
        'annuler
        '
        Me.annuler.BackColor = System.Drawing.Color.Transparent
        Me.annuler.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.boutonannuler
        Me.annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annuler.Location = New System.Drawing.Point(274, 325)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(153, 48)
        Me.annuler.TabIndex = 20
        Me.annuler.TabStop = False
        '
        'modifier
        '
        Me.modifier.BackColor = System.Drawing.Color.Transparent
        Me.modifier.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.boutonmodifier
        Me.modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifier.Location = New System.Drawing.Point(75, 325)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(153, 48)
        Me.modifier.TabIndex = 19
        Me.modifier.TabStop = False
        '
        'dateajout
        '
        Me.dateajout.CalendarFont = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateajout.Font = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateajout.Location = New System.Drawing.Point(178, 261)
        Me.dateajout.Name = "dateajout"
        Me.dateajout.Size = New System.Drawing.Size(250, 29)
        Me.dateajout.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(25, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 27)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date d'ajout:"
        '
        'femme
        '
        Me.femme.AutoSize = True
        Me.femme.BackColor = System.Drawing.Color.Transparent
        Me.femme.Font = New System.Drawing.Font("Source Sans Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femme.ForeColor = System.Drawing.Color.Gainsboro
        Me.femme.Location = New System.Drawing.Point(299, 196)
        Me.femme.Name = "femme"
        Me.femme.Size = New System.Drawing.Size(110, 34)
        Me.femme.TabIndex = 16
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
        Me.homme.Location = New System.Drawing.Point(178, 196)
        Me.homme.Name = "homme"
        Me.homme.Size = New System.Drawing.Size(115, 34)
        Me.homme.TabIndex = 15
        Me.homme.TabStop = True
        Me.homme.Text = "Homme"
        Me.homme.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(90, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Genre:"
        '
        'prenom
        '
        Me.prenom.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom.Location = New System.Drawing.Point(178, 138)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(249, 36)
        Me.prenom.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(70, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Prénom:"
        '
        'nom
        '
        Me.nom.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(178, 79)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(249, 36)
        Me.nom.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(106, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nom:"
        '
        'cin
        '
        Me.cin.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin.Location = New System.Drawing.Point(178, 19)
        Me.cin.Name = "cin"
        Me.cin.Size = New System.Drawing.Size(249, 36)
        Me.cin.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(118, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CIN:"
        '
        'ModifierPatient1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifierPatient1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjouterPatient"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.annuler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modifier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents closeb As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents prenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cin As TextBox
    Friend WithEvents homme As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents femme As RadioButton
    Friend WithEvents dateajout As DateTimePicker
    Friend WithEvents modifier As PictureBox
    Friend WithEvents annuler As PictureBox
End Class
