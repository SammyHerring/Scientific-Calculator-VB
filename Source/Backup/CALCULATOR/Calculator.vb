Public Class FormCalculator

    Dim sign_Indicator As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim addBit As Integer = 0
    Dim subBit As Integer = 0
    Dim multBit As Integer = 0
    Dim divBit As Integer = 0
    Dim modBit As Integer = 0
    Dim powerBit As Integer = 0
    Dim permBit As Integer = 0
    Dim combBit As Integer = 0
    Dim andBit As Integer = 0
    Dim orBit As Integer = 0
    Dim xorBit As Integer = 0
    Dim powerFunctionBit As Integer = 0
    Dim trigFunctionBit As Integer = 0
    Dim HypertrigFunctionBit As Integer = 0
    Dim InversetrigFunctionBit As Integer = 0
    Dim otherFuncsBit As Integer = 0
    Dim logicalFuncsBit As Integer = 0
    Dim memFuncsBit As Integer = 0
    Dim fl As Integer = 0
    Dim memoryVariable As Double = 0
    Dim scientificModeBit As Integer = 0

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(0)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 0
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(1)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 1
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(2)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 2
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(3)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 3
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(4)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 4
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(5)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 5
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(6)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 6
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(7)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 7
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(8)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 8
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(9)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 9
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub displayText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles displayText.KeyPress
        e.Handled = True
        If e.KeyChar Like "[0-9]" Or e.KeyChar = Chr(&H8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        If displayText.Text.Length = 0 Then
            displayText.Text = displayText.Text + CStr("-")
        ElseIf displayText.Text <> "." Then
            displayText.Text = displayText.Text * -1
        End If
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        displayText.Clear()
        sign_Indicator = 0
        variable1 = 0
        variable2 = 0
        memoryVariable = 0
        reset_SignBits()
    End Sub

    Private Sub btnClearTextbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTextbox.Click
        displayText.Clear()
    End Sub

    Private Function reset_SignBits()
        addBit = 0
        subBit = 0
        multBit = 0
        divBit = 0
        modBit = 0
        powerBit = 0
        permBit = 0
        combBit = 0
        andBit = 0
        orBit = 0
        xorBit = 0
        fl = 0
        Return 0
    End Function

    Private Function permutation(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = Factorial(variable1) / Factorial(variable1 - variable2)
        Return result
    End Function

    Private Function combination(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = Factorial(variable1) / (Factorial(variable2) * Factorial(variable1 - variable2))
        Return result
    End Function

    Private Function Calculate()
        If displayText.Text <> "." Then

            variable2 = displayText.Text
            If fl = False Then
                variable1 = variable2
            ElseIf addBit = 1 Then
                variable1 = variable1 + variable2
            ElseIf subBit = 1 Then
                variable1 = variable1 - variable2
            ElseIf multBit = 1 Then
                variable1 = variable1 * variable2
            ElseIf divBit = 1 Then
                variable1 = variable1 / variable2
            ElseIf modBit = 1 Then
                variable1 = variable1 Mod variable2
            ElseIf powerBit = 1 Then
                variable1 = Math.Pow(variable1, variable2)
            ElseIf permBit = 1 Then
                variable1 = permutation(variable1, variable2)
            ElseIf combBit = 1 Then
                variable1 = combination(variable1, variable2)
            ElseIf andBit = 1 Then
                variable1 = variable1 And variable2
            ElseIf orBit = 1 Then
                variable1 = variable1 Or variable2
            ElseIf xorBit = 1 Then
                variable1 = variable1 Xor variable2
            Else
                variable1 = variable2
            End If
            displayText.Text = CStr(variable1)

        End If
        Return 0
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            addBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click

        If displayText.Text.Length <> 0 Then
            variable2 = displayText.Text
            Calculate()
            reset_SignBits()
            subBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            multBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            divBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnModulus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModulus.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            modBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            powerBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnPerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerm.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            permBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnComb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComb.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            combBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            AndBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            OrBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnNot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNot.Click
        If displayText.Text.Length <> 0 Then
            variable1 = CDbl(displayText.Text)
            variable1 = Not variable1
            displayText.Text = CStr(variable1)
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnXor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXor.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            xorBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEqual.Click

        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        Dim i As Integer
        Dim chr As Char
        Dim decimal_Indicator As Integer = 0

        If sign_Indicator <> 1 Then
            For i = 0 To displayText.Text.Count - 1
                chr = displayText.Text(i)
                If chr = "." Then
                    decimal_Indicator = 1
                End If
            Next

            If decimal_Indicator <> 1 Then
                displayText.Text = displayText.Text & CStr(".")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeString
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        btnClose.Visible = 1
        lblTime.Visible = 1
        gbMain1.Visible = 1
        btnTime.Visible = True
        btnColour.Visible = True
        btna.Visible = 1
        btnb.Visible = 1
        btnc.Visible = 1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        lblTime.Visible = 0
        btnClose.Visible = 0
        btnTime.Visible = 0
        gbMain1.Visible = 0
        btna.Visible = 0
        btnb.Visible = 0
        btnc.Visible = 0
    End Sub

    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        BackColor = Color.DimGray
        btn0.BackColor = Color.Chocolate
        btn1.BackColor = Color.Chocolate
        btn2.BackColor = Color.Chocolate
        btn3.BackColor = Color.Chocolate
        btn4.BackColor = Color.Chocolate
        btn5.BackColor = Color.Chocolate
        btn6.BackColor = Color.Chocolate
        btn7.BackColor = Color.Chocolate
        btn8.BackColor = Color.Chocolate
        btn9.BackColor = Color.Chocolate
    End Sub

    Private Sub btnb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb.Click
        BackColor = Color.SlateGray
        btn0.BackColor = Color.DimGray
        btn1.BackColor = Color.DimGray
        btn2.BackColor = Color.DimGray
        btn3.BackColor = Color.DimGray
        btn4.BackColor = Color.DimGray
        btn5.BackColor = Color.DimGray
        btn6.BackColor = Color.DimGray
        btn7.BackColor = Color.DimGray
        btn8.BackColor = Color.DimGray
        btn9.BackColor = Color.DimGray
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        BackColor = Color.Black
        btn0.BackColor = Color.DarkRed
        btn1.BackColor = Color.DarkRed
        btn2.BackColor = Color.DarkRed
        btn3.BackColor = Color.DarkRed
        btn4.BackColor = Color.DarkRed
        btn5.BackColor = Color.DarkRed
        btn6.BackColor = Color.DarkRed
        btn7.BackColor = Color.DarkRed
        btn8.BackColor = Color.DarkRed
        btn9.BackColor = Color.DarkRed
    End Sub

    Private Sub btnBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text.Remove(displayText.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverse.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = 1 / displayText.Text
        End If
    End Sub

    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Sin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Cos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Tan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPI.Click
        displayText.Text = Math.PI
        sign_Indicator = 1
    End Sub

    Private Sub btnSinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinh.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Sinh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCosh.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Cosh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnTanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanh.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Tanh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Log10(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnln.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Log(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btne.Click
        displayText.Text = Math.E
        sign_Indicator = 1
    End Sub

    Private Sub btnex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnex.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Exp(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnsqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsqrt.Click
        If displayText.Text.Length <> 0 Then
            If displayText.Text <> "." Then
                displayText.Text = Math.Sqrt(displayText.Text)
            End If
            sign_Indicator = 1
        End If
    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Round(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnTruncate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTruncate.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Truncate(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCeil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCeil.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Ceiling(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnFloor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFloor.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Floor(temp)
        End If
        sign_Indicator = 1
    End Sub

    Public Function Factorial(ByVal temp)
        Dim result As Double = temp
        If temp = 0 Then
            Return 1
        Else
            For i = temp - 1 To 1 Step -1
                result = result * i
            Next
        End If
        Return result
    End Function

    Private Sub btnFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFact.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            Dim result = Factorial(temp)
            displayText.Text = CStr(result)
        End If
        sign_Indicator = 1
    End Sub


    Private Sub btnSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquare.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnCube_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCube.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnxPower4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxPower4.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text * displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnScientificMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScientificMode.Click
        If scientificModeBit = 0 Then
            btnFact.Enabled = 1
            btnPerm.Enabled = 1
            btnComb.Enabled = 1
            btnPI.Enabled = 1
            btnsqrt.Enabled = 1
            btnlog.Enabled = 1
            btnex.Enabled = 1
            btnln.Enabled = 1
            btnInverse.Enabled = 1
            btnModulus.Enabled = 1
            btne.Enabled = 1
            btnPower.Enabled = 1
            btnSquare.Enabled = 1
            btnCube.Enabled = 1
            btnxPower4.Enabled = 1
            btnAnd.Enabled = 1
            btnOr.Enabled = 1
            btnNot.Enabled = 1
            btnXor.Enabled = 1
            btnSin.Enabled = 1
            btnCos.Enabled = 1
            btnTan.Enabled = 1
            btnSinh.Enabled = 1
            btnCosh.Enabled = 1
            btnTanh.Enabled = 1
            btnInvSin.Enabled = 1
            btnInvCos.Enabled = 1
            btnInvTan.Enabled = 1
            btnRound.Enabled = 1
            btnFloor.Enabled = 1
            btnTruncate.Enabled = 1
            btnCeil.Enabled = 1
            btnM.Enabled = 1
            btnMplus.Enabled = 1
            btnMminus.Enabled = 1

            scientificModeBit = 1
        ElseIf scientificModeBit = 1 Then
            btnFact.Enabled = 0
            btnPerm.Enabled = 0
            btnComb.Enabled = 0
            btnPI.Enabled = 0
            btnsqrt.Enabled = 0
            btnlog.Enabled = 0
            btnex.Enabled = 0
            btnln.Enabled = 0
            btnInverse.Enabled = 0
            btnModulus.Enabled = 0
            btne.Enabled = 0
            btnPower.Enabled = 0
            btnSquare.Enabled = 0
            btnCube.Enabled = 0
            btnxPower4.Enabled = 0
            btnAnd.Enabled = 0
            btnOr.Enabled = 0
            btnNot.Enabled = 0
            btnXor.Enabled = 0
            btnSin.Enabled = 0
            btnCos.Enabled = 0
            btnTan.Enabled = 0
            btnSinh.Enabled = 0
            btnCosh.Enabled = 0
            btnTanh.Enabled = 0
            btnInvSin.Enabled = 0
            btnInvCos.Enabled = 0
            btnInvTan.Enabled = 0
            btnRound.Enabled = 0
            btnFloor.Enabled = 0
            btnTruncate.Enabled = 0
            btnCeil.Enabled = 0
            btnM.Enabled = 0
            btnMplus.Enabled = 0
            btnMminus.Enabled = 0

            scientificModeBit = 0
        End If
    End Sub

    Private Sub btnPowerFunctions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowerFunctions.Click
        If powerFunctionBit = 0 Then
            btnPower.Enabled = 1
            btnSquare.Enabled = 1
            btnCube.Enabled = 1
            btnxPower4.Enabled = 1
            powerFunctionBit = 1

        ElseIf powerFunctionBit = 1 Then
            btnPower.Enabled = 0
            btnSquare.Enabled = 0
            btnCube.Enabled = 0
            btnxPower4.Enabled = 0
            powerFunctionBit = 0
        End If
    End Sub

    Private Sub btnTrignometric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrignometric.Click
        If trigFunctionBit = 0 Then
            btnSin.Enabled = 1
            btnCos.Enabled = 1
            btnTan.Enabled = 1
            trigFunctionBit = 1

        ElseIf trigFunctionBit = 1 Then
            btnSin.Enabled = 0
            btnCos.Enabled = 0
            btnTan.Enabled = 0
            trigFunctionBit = 0
        End If
    End Sub

    Private Sub btnInverseTrigFuncs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInverseTrigFuncs.Click
        If InversetrigFunctionBit = 0 Then
            btnInvSin.Enabled = 1
            btnInvCos.Enabled = 1
            btnInvTan.Enabled = 1
            InversetrigFunctionBit = 1
        ElseIf InversetrigFunctionBit = 1 Then
            btnInvSin.Enabled = 0
            btnInvCos.Enabled = 0
            btnInvTan.Enabled = 0
            InversetrigFunctionBit = 0
        End If
    End Sub

    Private Sub btnHyperbolicTrig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHyperbolicTrig.Click
        If HypertrigFunctionBit = 0 Then
            btnSinh.Enabled = 1
            btnCosh.Enabled = 1
            btnTanh.Enabled = 1
            HypertrigFunctionBit = 1

        ElseIf HypertrigFunctionBit = 1 Then
            btnSinh.Enabled = 0
            btnCosh.Enabled = 0
            btnTanh.Enabled = 0
            HypertrigFunctionBit = 0
        End If
    End Sub

    Private Sub btnOtherFuncs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherFuncs.Click
        If otherFuncsBit = 0 Then
            btnRound.Enabled = 1
            btnFloor.Enabled = 1
            btnTruncate.Enabled = 1
            btnCeil.Enabled = 1
            otherFuncsBit = 1

        ElseIf otherFuncsBit = 1 Then
            btnRound.Enabled = 0
            btnFloor.Enabled = 0
            btnTruncate.Enabled = 0
            btnCeil.Enabled = 0
            otherFuncsBit = 0
        End If
    End Sub

    Private Sub btnLogicalFuncs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogicalFuncs.Click
        If logicalFuncsBit = 0 Then
            btnAnd.Enabled = 1
            btnOr.Enabled = 1
            btnNot.Enabled = 1
            btnXor.Enabled = 1
            logicalFuncsBit = 1

        ElseIf logicalFuncsBit = 1 Then
            btnAnd.Enabled = 0
            btnOr.Enabled = 0
            btnNot.Enabled = 0
            btnXor.Enabled = 0
            logicalFuncsBit = 0
        End If
    End Sub

    Private Sub btnMemFuncs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemFuncs.Click
        If memFuncsBit = 0 Then
            btnM.Enabled = 1
            btnMplus.Enabled = 1
            btnMminus.Enabled = 1
            memFuncsBit = 1

        ElseIf memFuncsBit = 1 Then
            btnM.Enabled = 0
            btnMplus.Enabled = 0
            btnMminus.Enabled = 0
            memFuncsBit = 0
        End If
    End Sub

    Private Sub btnInvSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvSin.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Asin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnInvCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvCos.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Acos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnInvTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvTan.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Atan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        If displayText.Text.Length <> 0 Then
            If memoryVariable = 0 Then
                memoryVariable = CDbl(displayText.Text)
            End If
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub btnMplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMplus.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable + memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub btnMminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMminus.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable - memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub


    Private Sub btnConstants_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConstants.Click
        Dim new_Form As New FormConstants
        new_Form.Show()
    End Sub

    Private Sub btnConversions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversions.Click
        Dim new_Form As New FormConversions
        new_Form.Show()
    End Sub

    Private Sub gbMain1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbMain1.Enter

    End Sub

    Private Sub FormCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
