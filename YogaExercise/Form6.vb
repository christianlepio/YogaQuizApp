Public Class Form6

    Dim maxVal, scoreA, scoreB, scoreC, scoreD, scoreE As Integer

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Form3.a1.Checked Then
            scoreA += 1
        ElseIf Form3.b1.Checked Then
            scoreB += 1
        ElseIf Form3.c1.Checked Then
            scoreC += 1
        ElseIf Form3.d1.Checked Then
            scoreD += 1
        ElseIf Form3.e1.Checked Then
            scoreE += 1
        End If

        If Form3.a2.Checked Then
            scoreA += 1
        ElseIf Form3.b2.Checked Then
            scoreB += 1
        ElseIf Form3.c2.Checked Then
            scoreC += 1
        ElseIf Form3.d2.Checked Then
            scoreD += 1
        ElseIf Form3.e2.Checked Then
            scoreE += 1
        End If

        If Form3.a3.Checked Then
            scoreA += 1
        ElseIf Form3.b3.Checked Then
            scoreB += 1
        ElseIf Form3.c3.Checked Then
            scoreC += 1
        ElseIf Form3.d3.Checked Then
            scoreD += 1
        ElseIf Form3.e3.Checked Then
            scoreE += 1
        End If

        If Form3.a4.Checked Then
            scoreA += 1
        ElseIf Form3.b4.Checked Then
            scoreB += 1
        ElseIf Form3.c4.Checked Then
            scoreC += 1
        ElseIf Form3.d4.Checked Then
            scoreD += 1
        ElseIf Form3.e4.Checked Then
            scoreE += 1
        End If

        If Form4.a5.Checked Then
            scoreA += 1
        ElseIf Form4.b5.Checked Then
            scoreB += 1
        ElseIf Form4.c5.Checked Then
            scoreC += 1
        ElseIf Form4.d5.Checked Then
            scoreD += 1
        End If

        If Form4.a6.Checked Then
            scoreA += 1
        ElseIf Form4.b6.Checked Then
            scoreB += 1
        ElseIf Form4.c6.Checked Then
            scoreC += 1
        ElseIf Form4.d6.Checked Then
            scoreD += 1
        ElseIf Form4.e6.Checked Then
            scoreE += 1
        End If

        If Form4.a7.Checked Then
            scoreA += 1
        ElseIf Form4.b7.Checked Then
            scoreB += 1
        ElseIf Form4.c7.Checked Then
            scoreC += 1
        ElseIf Form4.d7.Checked Then
            scoreD += 1
        ElseIf Form4.e7.Checked Then
            scoreE += 1
        End If

        If Form4.a8.Checked Then
            scoreA += 1
        ElseIf Form4.b8.Checked Then
            scoreB += 1
        ElseIf Form4.c8.Checked Then
            scoreC += 1
        ElseIf Form4.d8.Checked Then
            scoreD += 1
        ElseIf Form4.e8.Checked Then
            scoreE += 1
        End If

        If Form5.a9.Checked Then
            scoreA += 1
        ElseIf Form5.b9.Checked Then
            scoreB += 1
        ElseIf Form5.c9.Checked Then
            scoreC += 1
        ElseIf Form5.d9.Checked Then
            scoreD += 1
        ElseIf Form5.e9.Checked Then
            scoreE += 1
        End If

        If Form5.a10.Checked Then
            scoreA += 1
        ElseIf Form5.b10.Checked Then
            scoreB += 1
        ElseIf Form5.c10.Checked Then
            scoreC += 1
        ElseIf Form5.d10.Checked Then
            scoreD += 1
        ElseIf Form5.e10.Checked Then
            scoreE += 1
        End If

        Dim result() As Integer = {scoreA, scoreB, scoreC, scoreD, scoreE}
        maxVal = result.Max

        If (maxVal = scoreA) Then
            MessageBox.Show("Hi " & Form2.txtlname.Text & ", You are an EXTROVERT " & vbNewLine & vbNewLine & "You’re never a wallflower but, more likely, a trailblazer belting out the latest karaoke tune or taking flamenco
lessons. You like a strong confident scent that reflects your outspoken and flamboyant attitude." & vbNewLine & vbNewLine & "         Scent family – floral with a touch of fruit or spice. Try: Perhaps, Bob Mackie, Nokomis, Coty, Starring,
Avon, 5th Avenue, Elizabeth Arden She, Revlon", "Findings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (maxVal = scoreB) Then
            MessageBox.Show("Hi " & Form2.txtlname.Text & ", You are a SPORTY " & vbNewLine & vbNewLine & "Shopping or dancing? No thanks, you’d rather go hiking or to the gym. A nature lover, you prefer a fresh scent
that recalls the wide-open spaces." & vbNewLine & vbNewLine & "         Scent family – green or citrus. Try: Acqua di Gio, Giorgio Armani, Happy, Clinique, Envy, Gucci, Cool
Water Woman, Davidoff sport scents from Escada, Liz Claiborne and Ralph Lauren Polo", "Findings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (maxVal = scoreC) Then
            MessageBox.Show("Hi " & Form2.txtlname.Text & ", You are SOPHISTICATE " & vbNewLine & vbNewLine & "From haute cuisine to silk lingerie, you cherish the finer things in life—and you’ll save up to buy the best quality
possible. Good taste rules your life and you make sure everyone knows it." & vbNewLine & vbNewLine & "         Scent family – floral-oriented. Try: Allure, Chanel Contradiction, Calvin Klein Organza, Givenchy Dolce
Vita, Christian Dior 4, Faubourgh, Hermès", "Findings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (maxVal = scoreD) Then
            MessageBox.Show("Hi " & Form2.txtlname.Text & ", You are an INTROVERT " & vbNewLine & vbNewLine & "There’s nothing you love better than to curl up with an absorbing book on a chilly day. Content to be in the
background, you’re confident but understated and don’t want your fragrance to enter a room before you do." & vbNewLine & vbNewLine & "         Scent family – very soft floral. Try: Ocean Dream, Giorgio Beverly Hills L’eau d’Issey, Issey Miyake Au thé
vert, Bvlgari, Chanel No. 5, Journey, Mary Kay", "Findings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (maxVal = scoreE) Then
            MessageBox.Show("Hi " & Form2.txtlname.Text & ", You are ROMANTIC " & vbNewLine & vbNewLine & "No fads or gimmicks for you. Passionate yet tender, you believe in traditional values. Pretty fragrance bottles line
your vanity, and you’d never share your scent with a man." & vbNewLine & vbNewLine & "         Scent family – white floral or floral-citrus. Try: Pure, Alfred Sung, Song de Chine, Crabtree & Evelyn, So de
la Renta, Oscar de la Renta, Pleasures, Estée Lauder, Tommy Girl, Tommy Hilfiger", "Findings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        scoreA = 0
        scoreB = 0
        scoreC = 0
        scoreD = 0
        scoreE = 0

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scoreA = 0
        scoreB = 0
        scoreC = 0
        scoreD = 0
        scoreE = 0
        Me.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form1.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class