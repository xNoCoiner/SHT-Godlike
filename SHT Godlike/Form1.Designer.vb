<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btntools = New FontAwesome.Sharp.IconButton()
        Me.btnmaterialien = New FontAwesome.Sharp.IconButton()
        Me.btnkunden = New FontAwesome.Sharp.IconButton()
        Me.btnmitarbeiter = New FontAwesome.Sharp.IconButton()
        Me.btntouren = New FontAwesome.Sharp.IconButton()
        Me.btnfuhrpark = New FontAwesome.Sharp.IconButton()
        Me.btndashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.picboxlogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.Iconcurrentform = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.picboxlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitlebar.SuspendLayout()
        CType(Me.Iconcurrentform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Maroon
        Me.PanelMenu.Controls.Add(Me.btntools)
        Me.PanelMenu.Controls.Add(Me.btnmaterialien)
        Me.PanelMenu.Controls.Add(Me.btnkunden)
        Me.PanelMenu.Controls.Add(Me.btnmitarbeiter)
        Me.PanelMenu.Controls.Add(Me.btntouren)
        Me.PanelMenu.Controls.Add(Me.btnfuhrpark)
        Me.PanelMenu.Controls.Add(Me.btndashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 972)
        Me.PanelMenu.TabIndex = 0
        '
        'btntools
        '
        Me.btntools.Dock = System.Windows.Forms.DockStyle.Top
        Me.btntools.FlatAppearance.BorderSize = 0
        Me.btntools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btntools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntools.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntools.ForeColor = System.Drawing.Color.Gainsboro
        Me.btntools.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btntools.IconColor = System.Drawing.Color.Bisque
        Me.btntools.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btntools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntools.Location = New System.Drawing.Point(0, 740)
        Me.btntools.Name = "btntools"
        Me.btntools.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btntools.Size = New System.Drawing.Size(250, 100)
        Me.btntools.TabIndex = 7
        Me.btntools.Text = "Tools"
        Me.btntools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntools.UseVisualStyleBackColor = True
        '
        'btnmaterialien
        '
        Me.btnmaterialien.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmaterialien.FlatAppearance.BorderSize = 0
        Me.btnmaterialien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnmaterialien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmaterialien.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmaterialien.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnmaterialien.IconChar = FontAwesome.Sharp.IconChar.Tags
        Me.btnmaterialien.IconColor = System.Drawing.Color.Bisque
        Me.btnmaterialien.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnmaterialien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmaterialien.Location = New System.Drawing.Point(0, 640)
        Me.btnmaterialien.Name = "btnmaterialien"
        Me.btnmaterialien.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmaterialien.Size = New System.Drawing.Size(250, 100)
        Me.btnmaterialien.TabIndex = 6
        Me.btnmaterialien.Text = "Materialien"
        Me.btnmaterialien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmaterialien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnmaterialien.UseVisualStyleBackColor = True
        '
        'btnkunden
        '
        Me.btnkunden.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnkunden.FlatAppearance.BorderSize = 0
        Me.btnkunden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnkunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkunden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkunden.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnkunden.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnkunden.IconColor = System.Drawing.Color.Bisque
        Me.btnkunden.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnkunden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkunden.Location = New System.Drawing.Point(0, 540)
        Me.btnkunden.Name = "btnkunden"
        Me.btnkunden.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnkunden.Size = New System.Drawing.Size(250, 100)
        Me.btnkunden.TabIndex = 5
        Me.btnkunden.Text = "Kunden"
        Me.btnkunden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkunden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnkunden.UseVisualStyleBackColor = True
        '
        'btnmitarbeiter
        '
        Me.btnmitarbeiter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmitarbeiter.FlatAppearance.BorderSize = 0
        Me.btnmitarbeiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnmitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmitarbeiter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmitarbeiter.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnmitarbeiter.IconChar = FontAwesome.Sharp.IconChar.UserSecret
        Me.btnmitarbeiter.IconColor = System.Drawing.Color.Bisque
        Me.btnmitarbeiter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnmitarbeiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmitarbeiter.Location = New System.Drawing.Point(0, 440)
        Me.btnmitarbeiter.Name = "btnmitarbeiter"
        Me.btnmitarbeiter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmitarbeiter.Size = New System.Drawing.Size(250, 100)
        Me.btnmitarbeiter.TabIndex = 4
        Me.btnmitarbeiter.Text = "Mitarbeiter"
        Me.btnmitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmitarbeiter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnmitarbeiter.UseVisualStyleBackColor = True
        '
        'btntouren
        '
        Me.btntouren.Dock = System.Windows.Forms.DockStyle.Top
        Me.btntouren.FlatAppearance.BorderSize = 0
        Me.btntouren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btntouren.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntouren.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntouren.ForeColor = System.Drawing.Color.Gainsboro
        Me.btntouren.IconChar = FontAwesome.Sharp.IconChar.Road
        Me.btntouren.IconColor = System.Drawing.Color.Bisque
        Me.btntouren.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btntouren.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntouren.Location = New System.Drawing.Point(0, 340)
        Me.btntouren.Name = "btntouren"
        Me.btntouren.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btntouren.Size = New System.Drawing.Size(250, 100)
        Me.btntouren.TabIndex = 3
        Me.btntouren.Text = "Touren"
        Me.btntouren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntouren.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntouren.UseVisualStyleBackColor = True
        '
        'btnfuhrpark
        '
        Me.btnfuhrpark.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnfuhrpark.FlatAppearance.BorderSize = 0
        Me.btnfuhrpark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnfuhrpark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfuhrpark.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfuhrpark.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnfuhrpark.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnfuhrpark.IconColor = System.Drawing.Color.Bisque
        Me.btnfuhrpark.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnfuhrpark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfuhrpark.Location = New System.Drawing.Point(0, 240)
        Me.btnfuhrpark.Name = "btnfuhrpark"
        Me.btnfuhrpark.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnfuhrpark.Size = New System.Drawing.Size(250, 100)
        Me.btnfuhrpark.TabIndex = 2
        Me.btnfuhrpark.Text = "Fuhrpark"
        Me.btnfuhrpark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfuhrpark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfuhrpark.UseVisualStyleBackColor = True
        '
        'btndashboard
        '
        Me.btndashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btndashboard.FlatAppearance.BorderSize = 0
        Me.btndashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btndashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btndashboard.IconColor = System.Drawing.Color.Bisque
        Me.btndashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.Location = New System.Drawing.Point(0, 140)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndashboard.Size = New System.Drawing.Size(250, 100)
        Me.btndashboard.TabIndex = 1
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndashboard.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.picboxlogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'picboxlogo
        '
        Me.picboxlogo.Image = Global.SHT_Godlike.My.Resources.Resources.Logo_schriftfarbe_transparent
        Me.picboxlogo.Location = New System.Drawing.Point(-1, 12)
        Me.picboxlogo.Name = "picboxlogo"
        Me.picboxlogo.Size = New System.Drawing.Size(218, 103)
        Me.picboxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxlogo.TabIndex = 0
        Me.picboxlogo.TabStop = False
        '
        'PanelTitlebar
        '
        Me.PanelTitlebar.BackColor = System.Drawing.Color.Maroon
        Me.PanelTitlebar.Controls.Add(Me.btnMinimize)
        Me.PanelTitlebar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitlebar.Controls.Add(Me.btnMaximize)
        Me.PanelTitlebar.Controls.Add(Me.Iconcurrentform)
        Me.PanelTitlebar.Controls.Add(Me.btnExit)
        Me.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitlebar.Location = New System.Drawing.Point(250, 0)
        Me.PanelTitlebar.Name = "PanelTitlebar"
        Me.PanelTitlebar.Size = New System.Drawing.Size(1870, 75)
        Me.PanelTitlebar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackgroundImage = Global.SHT_Godlike.My.Resources.Resources.minimize
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1798, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(19, 16)
        Me.btnMinimize.TabIndex = 8
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(51, 33)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(44, 16)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackgroundImage = Global.SHT_Godlike.My.Resources.Resources.maximize_size_option
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Location = New System.Drawing.Point(1823, 2)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(19, 16)
        Me.btnMaximize.TabIndex = 9
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'Iconcurrentform
        '
        Me.Iconcurrentform.BackColor = System.Drawing.Color.Maroon
        Me.Iconcurrentform.ForeColor = System.Drawing.Color.Bisque
        Me.Iconcurrentform.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Iconcurrentform.IconColor = System.Drawing.Color.Bisque
        Me.Iconcurrentform.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Iconcurrentform.Location = New System.Drawing.Point(17, 25)
        Me.Iconcurrentform.Name = "Iconcurrentform"
        Me.Iconcurrentform.Size = New System.Drawing.Size(32, 32)
        Me.Iconcurrentform.TabIndex = 0
        Me.Iconcurrentform.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.SHT_Godlike.My.Resources.Resources.close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(1848, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(19, 16)
        Me.btnExit.TabIndex = 10
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(250, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1870, 897)
        Me.PanelDesktop.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(2120, 972)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitlebar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "SH Transporte - Godlike"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.picboxlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitlebar.ResumeLayout(False)
        Me.PanelTitlebar.PerformLayout()
        CType(Me.Iconcurrentform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents picboxlogo As PictureBox
    Friend WithEvents btnkunden As FontAwesome.Sharp.IconButton
    Friend WithEvents btnmitarbeiter As FontAwesome.Sharp.IconButton
    Friend WithEvents btntouren As FontAwesome.Sharp.IconButton
    Friend WithEvents btnfuhrpark As FontAwesome.Sharp.IconButton
    Friend WithEvents btndashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnmaterialien As FontAwesome.Sharp.IconButton
    Friend WithEvents btntools As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Iconcurrentform As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PanelDesktop As Panel
End Class
