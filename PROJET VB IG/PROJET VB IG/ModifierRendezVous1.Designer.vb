<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifierRendezVous1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifierRendezVous1))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.ComboBox()
        Me.annuler = New System.Windows.Forms.PictureBox()
        Me.modifier = New System.Windows.Forms.PictureBox()
        Me.daterendezvous = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.closeb)
        Me.Panel4.Controls.Add(Me.minimize)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(474, 53)
        Me.Panel4.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(306, 26)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Modifier Rendez-Vous"
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.type)
        Me.Panel1.Controls.Add(Me.annuler)
        Me.Panel1.Controls.Add(Me.modifier)
        Me.Panel1.Controls.Add(Me.daterendezvous)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 390)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(137, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 27)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID:"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(191, 38)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(249, 36)
        Me.id.TabIndex = 22
        '
        'type
        '
        Me.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"Sélectionner", "Normal", "Urgent", "Très Urgent"})
        Me.type.Location = New System.Drawing.Point(190, 173)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(250, 37)
        Me.type.TabIndex = 21
        '
        'annuler
        '
        Me.annuler.BackColor = System.Drawing.Color.Transparent
        Me.annuler.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.boutonannuler
        Me.annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.annuler.Location = New System.Drawing.Point(256, 312)
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
        Me.modifier.Location = New System.Drawing.Point(56, 312)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(153, 48)
        Me.modifier.TabIndex = 19
        Me.modifier.TabStop = False
        '
        'daterendezvous
        '
        Me.daterendezvous.CalendarFont = New System.Drawing.Font("Source Sans Pro Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daterendezvous.Font = New System.Drawing.Font("Source Sans Pro", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daterendezvous.Location = New System.Drawing.Point(191, 250)
        Me.daterendezvous.Name = "daterendezvous"
        Me.daterendezvous.Size = New System.Drawing.Size(249, 29)
        Me.daterendezvous.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Date de Rendez-Vous:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(112, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Type:"
        '
        'cin
        '
        Me.cin.Enabled = False
        Me.cin.Font = New System.Drawing.Font("Source Sans Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin.Location = New System.Drawing.Point(190, 101)
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
        Me.Label1.Location = New System.Drawing.Point(125, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CIN:"
        '
        'ModifierRendezVous1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModifierRendezVous1"
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
    Friend WithEvents cin As TextBox
    Friend WithEvents modifier As PictureBox
    Friend WithEvents annuler As PictureBox
    Friend WithEvents type As ComboBox
    Friend WithEvents daterendezvous As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As TextBox
End Class
