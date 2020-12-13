<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupprimerRendezVous1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupprimerRendezVous1))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.non = New System.Windows.Forms.Button()
        Me.oui = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(329, 26)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Supprimer Rendez-Vous"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PROJET_VB_IG.My.Resources.Resources.background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.non)
        Me.Panel1.Controls.Add(Me.oui)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 166)
        Me.Panel1.TabIndex = 9
        '
        'non
        '
        Me.non.BackColor = System.Drawing.Color.MistyRose
        Me.non.Cursor = System.Windows.Forms.Cursors.Hand
        Me.non.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.non.FlatAppearance.BorderSize = 2
        Me.non.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.non.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.non.ForeColor = System.Drawing.Color.Brown
        Me.non.Location = New System.Drawing.Point(255, 85)
        Me.non.Name = "non"
        Me.non.Size = New System.Drawing.Size(79, 34)
        Me.non.TabIndex = 12
        Me.non.Text = "Non"
        Me.non.UseVisualStyleBackColor = False
        '
        'oui
        '
        Me.oui.BackColor = System.Drawing.Color.LightCyan
        Me.oui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.oui.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.oui.FlatAppearance.BorderSize = 2
        Me.oui.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.oui.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oui.ForeColor = System.Drawing.Color.Navy
        Me.oui.Location = New System.Drawing.Point(101, 85)
        Me.oui.Name = "oui"
        Me.oui.Size = New System.Drawing.Size(79, 34)
        Me.oui.TabIndex = 11
        Me.oui.Text = "Oui"
        Me.oui.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Voulez-vous vraiment supprimer ce rendez-vous ?"
        '
        'SupprimerRendezVous1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 219)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SupprimerRendezVous1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjouterPatient"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents closeb As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents non As Button
    Friend WithEvents oui As Button
End Class
