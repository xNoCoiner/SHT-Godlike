Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1

    'Felder
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methoden

    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Buttons'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.Maroon
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Links Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            Iconcurrentform.IconChar = currentBtn.IconChar
            Iconcurrentform.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Maroon
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        Iconcurrentform.IconChar = IconChar.Home
        Iconcurrentform.IconColor = Color.Bisque
        lblFormTitle.Text = "Home"
    End Sub



    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitlebar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'Remove transparent border in maximized state'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub


    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub btnfuhrpark_Click(sender As Object, e As EventArgs) Handles btnfuhrpark.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormFurhpark)
    End Sub

    Private Sub btntouren_Click(sender As Object, e As EventArgs) Handles btntouren.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormTouren)
    End Sub

    Private Sub btnmitarbeiter_Click(sender As Object, e As EventArgs) Handles btnmitarbeiter.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormMitarbeiter)
    End Sub

    Private Sub btnkunden_Click(sender As Object, e As EventArgs) Handles btnkunden.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormKunden)
    End Sub

    Private Sub btnmaterialien_Click(sender As Object, e As EventArgs) Handles btnmaterialien.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormMaterialien)
    End Sub

    Private Sub btntools_Click(sender As Object, e As EventArgs) Handles btntools.Click
        ActiveButton(sender, Color.Bisque)
        OpenChildForm(New FormTools)
    End Sub

    Private Sub picboxlogo_Click(sender As Object, e As EventArgs) Handles picboxlogo.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub PanelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles PanelDesktop.Paint

    End Sub
End Class
