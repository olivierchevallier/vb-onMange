<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Romain", 0)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Ophélie", 0)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Olivier", 0)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Clothilde", 0)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Benoît", 0)
        Me.picManger = New System.Windows.Forms.PictureBox()
        Me.lblLoginTitre = New System.Windows.Forms.Label()
        Me.imgLstUtilisateurs = New System.Windows.Forms.ImageList(Me.components)
        Me.lstUtilisateurs = New System.Windows.Forms.ListView()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.timTip = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picManger
        '
        Me.picManger.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picManger.Image = Global.OnMange.My.Resources.Resources.logo_long
        Me.picManger.Location = New System.Drawing.Point(101, 27)
        Me.picManger.Name = "picManger"
        Me.picManger.Size = New System.Drawing.Size(222, 95)
        Me.picManger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picManger.TabIndex = 18
        Me.picManger.TabStop = False
        '
        'lblLoginTitre
        '
        Me.lblLoginTitre.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLoginTitre.AutoSize = True
        Me.lblLoginTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblLoginTitre.Location = New System.Drawing.Point(65, 134)
        Me.lblLoginTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginTitre.Name = "lblLoginTitre"
        Me.lblLoginTitre.Size = New System.Drawing.Size(306, 26)
        Me.lblLoginTitre.TabIndex = 20
        Me.lblLoginTitre.Text = "S'identifier - Famille Chevallier"
        '
        'imgLstUtilisateurs
        '
        Me.imgLstUtilisateurs.ImageStream = CType(resources.GetObject("imgLstUtilisateurs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLstUtilisateurs.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLstUtilisateurs.Images.SetKeyName(0, "people.png")
        '
        'lstUtilisateurs
        '
        Me.lstUtilisateurs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstUtilisateurs.BackColor = System.Drawing.Color.White
        Me.lstUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstUtilisateurs.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.lstUtilisateurs.LargeImageList = Me.imgLstUtilisateurs
        Me.lstUtilisateurs.Location = New System.Drawing.Point(12, 173)
        Me.lstUtilisateurs.MultiSelect = False
        Me.lstUtilisateurs.Name = "lstUtilisateurs"
        Me.lstUtilisateurs.Size = New System.Drawing.Size(402, 216)
        Me.lstUtilisateurs.TabIndex = 21
        Me.lstUtilisateurs.UseCompatibleStateImageBehavior = False
        '
        'lblTip
        '
        Me.lblTip.AutoSize = True
        Me.lblTip.Location = New System.Drawing.Point(171, 398)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(84, 20)
        Me.lblTip.TabIndex = 22
        Me.lblTip.Text = "Bienvenue"
        '
        'timTip
        '
        Me.timTip.Interval = 1000
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 427)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.lstUtilisateurs)
        Me.Controls.Add(Me.lblLoginTitre)
        Me.Controls.Add(Me.picManger)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.Text = "On mange ! - Connexion"
        CType(Me.picManger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picManger As PictureBox
    Friend WithEvents lblLoginTitre As Label
    Friend WithEvents imgLstUtilisateurs As ImageList
    Friend WithEvents lstUtilisateurs As ListView
    Friend WithEvents lblTip As Label
    Friend WithEvents timTip As Timer
End Class
