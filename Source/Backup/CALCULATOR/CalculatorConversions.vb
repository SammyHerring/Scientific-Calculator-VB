Public Class FormConversions

    Dim WithEvents textbox1 As New TextBox
    'Dim WithEvents textbox1 As New System.Windows.Forms.TextBox()
    Dim WithEvents submitBtn As New Button
    Dim WithEvents resetBtn As New Button

    Dim WithEvents textbox2 As New TextBox
    Dim WithEvents textbox3 As New TextBox
    Dim WithEvents lbl1 As New Label
    Dim WithEvents lbl2 As New Label
    Dim WithEvents lbl3 As New Label

    Private Sub btnTemperature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemperature.Click

        textbox1.Location = New Point(7, 30)
        textbox1.Size = New Point(130, 17)
        textbox1.TextAlign = HorizontalAlignment.Center
        textbox1.Font = New System.Drawing.Font("Calibri", 11, Drawing.FontStyle.Bold)

        Me.Controls.Add(textbox1)

        lbl1.Location = New Point(148, 30)
        lbl1.FlatStyle = FlatStyle.Popup
        lbl1.Size = New Point(100, 20)
        lbl1.Font = New System.Drawing.Font("Calibri", 12, Drawing.FontStyle.Bold)
        lbl1.TextAlign = ContentAlignment.MiddleCenter
        lbl1.Text = "CENTIGRADE"
        Me.Controls.Add(lbl1)


        textbox2.Location = New Point(7, 60)
        textbox2.Size = New Point(130, 17)
        textbox2.TextAlign = HorizontalAlignment.Center
        textbox2.Font = New System.Drawing.Font("Calibri", 11, Drawing.FontStyle.Bold)
        Me.Controls.Add(textbox2)

        lbl2.Location = New Point(148, 60)
        lbl2.FlatStyle = FlatStyle.Popup
        lbl2.Size = New Point(100, 20)
        lbl2.Font = New System.Drawing.Font("Calibri", 12, Drawing.FontStyle.Bold)
        lbl2.TextAlign = ContentAlignment.MiddleCenter
        lbl2.Text = "FARENHEIT"
        Me.Controls.Add(lbl2)

        textbox3.Location = New Point(7, 90)
        textbox3.Size = New Point(130, 17)
        textbox3.TextAlign = HorizontalAlignment.Center
        textbox3.Font = New System.Drawing.Font("Calibri", 11, Drawing.FontStyle.Bold)
        Me.Controls.Add(textbox3)

        lbl3.Location = New Point(148, 90)
        lbl3.FlatStyle = FlatStyle.Popup
        lbl3.Size = New Point(100, 20)
        lbl3.Font = New System.Drawing.Font("Calibri", 12, Drawing.FontStyle.Bold)
        lbl3.TextAlign = ContentAlignment.MiddleCenter
        lbl3.Text = "KELVIN"
        Me.Controls.Add(lbl3)

    End Sub

    Dim temp As Double

    Private Sub submitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitBtn.Click
        If textbox1.Text.Length <> 0 Then
            temp = CDbl(textbox1.Text)
            textbox2.Text = CStr(9 / 5 * temp + 32)
            textbox3.Text = CStr(temp + 273.16)
        ElseIf textbox2.Text.Length <> 0 Then
            temp = CDbl(textbox2.Text)
            textbox1.Text = CStr(5 / 9 * (temp - 32))
            textbox3.Text = CStr(temp + 273.16)
        ElseIf textbox3.Text.Length <> 0 Then
            temp = CDbl(textbox3.Text)
            textbox2.Text = CStr(9 / 5 * temp + 32)
            textbox1.Text = CStr(5 / 9 * (temp - 32))
        End If
    End Sub


    Private Sub frmConversions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        submitBtn.BackColor = Color.DimGray
        submitBtn.Location = New Point(93, 500)
        submitBtn.FlatStyle = FlatStyle.Standard
        submitBtn.Size = New Point(79, 28)
        submitBtn.Font = New System.Drawing.Font("Calibri", 12, Drawing.FontStyle.Bold)
        submitBtn.TextAlign = ContentAlignment.MiddleCenter
        submitBtn.Text = "SUBMIT"
        Me.Controls.Add(submitBtn)

        resetBtn.BackColor = Color.DimGray
        resetBtn.Location = New Point(93, 460)
        resetBtn.FlatStyle = FlatStyle.Standard
        resetBtn.Size = New Point(79, 28)
        resetBtn.Font = New System.Drawing.Font("Calibri", 12, Drawing.FontStyle.Bold)
        resetBtn.TextAlign = ContentAlignment.MiddleCenter
        resetBtn.Text = "RESET"
        Me.Controls.Add(resetBtn)

    End Sub

    Private Sub resetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetBtn.Click
        textbox1.Clear()
        textbox2.Clear()
        textbox3.Clear()
    End Sub

    'Private Sub btnTemperature_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTemperature.LostFocus
    '   Dim visibleBit As Integer = 0
    ' If  visibleBit = 0
    '    textbox1.Visible = 0
    '   textbox2.Visible = 0
    '  textbox3.Visible = 0
    ' lbl1.Visible = 0
    ' lbl2.Visible = 0
    ' lbl3.Visible = 0
    'End Sub

End Class