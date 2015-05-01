Public Class frm_olopon

    Dim img0 As Object = My.Resources.pebb0
    Dim img1 As Object = My.Resources.pebb1
    Dim img2 As Object = My.Resources.pebb2
    Dim img3 As Object = My.Resources.pebb3
    Dim img4 As Object = My.Resources.pebb4
    Dim img5 As Object = My.Resources.pebb5
    Dim img6 As Object = My.Resources.pebb6
    Dim img7 As Object = My.Resources.pebb7
    Dim img8 As Object = My.Resources.pebb8
    Dim img9 As Object = My.Resources.pebb9
    Dim img10 As Object = My.Resources.pebb10
    Dim img11 As Object = My.Resources.pebb11
    Dim img12 As Object = My.Resources.pebb12

    Dim imghand1 As Object = My.Resources.playerhand_1
    Dim imghand2 As Object = My.Resources.playerhand_2

    Private player_1_score As Integer = 0
    Private player_2_score As Integer = 0

    Private current_player As String = "player_1"
    Private side As String = "a"

    Dim max_seed_num As Int16 = 48

    Friend WithEvents myTimer As New Timer

    Dim dbug_msg As String = ""

    Private Sub frm_olopon_Load(sender As Object, e As EventArgs) Handles Me.Load

        pbx_b6.Image = img4
        pbx_b5.Image = img4
        pbx_b4.Image = img4
        pbx_b3.Image = img4
        pbx_b2.Image = img4
        pbx_b1.Image = img4

        pbx_a6.Image = img4
        pbx_a5.Image = img4
        pbx_a4.Image = img4
        pbx_a3.Image = img4
        pbx_a2.Image = img4
        pbx_a1.Image = img4

        pbx_hand_a1.Image = imghand1
        pbx_hand_b1.Image = imghand2

        lbl_p2_turn.Visible = False

        myTimer.Interval = 500
        myTimer.Start()
    End Sub

    Private Sub pbx_a1_Click(sender As Object, e As EventArgs) Handles pbx_a1.Click
        side = "a"
        pbx_trig(pbx_a1)
        change_player()
    End Sub

    Private Sub pbx_a2_Click(sender As Object, e As EventArgs) Handles pbx_a2.Click
        side = "a"
        pbx_trig(pbx_a2)
        change_player()
    End Sub

    Private Sub pbx_a3_Click(sender As Object, e As EventArgs) Handles pbx_a3.Click
        side = "a"
        pbx_trig(pbx_a3)
        change_player()
    End Sub

    Private Sub pbx_a4_Click(sender As Object, e As EventArgs) Handles pbx_a4.Click
        side = "a"
        pbx_trig(pbx_a4)
        change_player()
    End Sub

    Private Sub pbx_a5_Click(sender As Object, e As EventArgs) Handles pbx_a5.Click
        side = "a"
        pbx_trig(pbx_a5)
        change_player()
    End Sub

    Private Sub pbx_a6_Click(sender As Object, e As EventArgs) Handles pbx_a6.Click
        side = "a"
        pbx_trig(pbx_a6)
        change_player()
    End Sub

    Private Sub pbx_b1_Click(sender As Object, e As EventArgs) Handles pbx_b1.Click
        side = "b"
        pbx_trig(pbx_b1)
        change_player()
    End Sub

    Private Sub pbx_b2_Click(sender As Object, e As EventArgs) Handles pbx_b2.Click
        side = "b"
        pbx_trig(pbx_b2)
        change_player()
    End Sub

    Private Sub pbx_b3_Click(sender As Object, e As EventArgs) Handles pbx_b3.Click
        side = "b"
        pbx_trig(pbx_b3)
        change_player()
    End Sub

    Private Sub pbx_b4_Click(sender As Object, e As EventArgs) Handles pbx_b4.Click
        side = "b"
        pbx_trig(pbx_b4)
        change_player()
    End Sub

    Private Sub pbx_b5_Click(sender As Object, e As EventArgs) Handles pbx_b5.Click
        side = "b"
        pbx_trig(pbx_b5)
        change_player()
    End Sub

    Private Sub pbx_b6_Click(sender As Object, e As EventArgs) Handles pbx_b6.Click
        side = "b"
        pbx_trig(pbx_b6)
        change_player()
    End Sub

    Private Sub pbx_trig(ByVal pict_bx As PictureBox)
        If player_side_checker(current_player, pict_bx) Then
            If pict_bx.Image Is img0 Then

            ElseIf pict_bx.Image Is img1 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 1, current_player)
            ElseIf pict_bx.Image Is img2 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 2, current_player)
            ElseIf pict_bx.Image Is img3 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 3, current_player)
            ElseIf pict_bx.Image Is img4 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 4, current_player)
            ElseIf pict_bx.Image Is img5 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 5, current_player)
            ElseIf pict_bx.Image Is img6 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 6, current_player)
            ElseIf pict_bx.Image Is img7 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 7, current_player)
            ElseIf pict_bx.Image Is img8 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 8, current_player)
            ElseIf pict_bx.Image Is img9 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 9, current_player)
            ElseIf pict_bx.Image Is img10 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 10, current_player)
            ElseIf pict_bx.Image Is img11 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 11, current_player)
            ElseIf pict_bx.Image Is img12 Then
                pict_bx.Image = img0
                pbx_change(pict_bx, 12, current_player)
            End If

        Else
            MsgBox("Please " & return_proper(current_player) & " pick seeds from your side of the board")
            change_player()
        End If
    End Sub

    Private Sub pbx_change(ByVal pict_bx As PictureBox, ByVal seed_num As Int16, ByVal player As String)

        Try


            Dim start_bx As Int32 = get_num(pict_bx.Name.ToString)
            Dim counter = 0

            'To determine Player side, a or b, representing P1 and P2 respectively
            'If start_bx Mod 6 = 0 And counter = 0 Then
            '    change_side()
            '    counter += 1
            'End If

            For i As Int16 = (start_bx + 1) To (seed_num + start_bx)

                dbug_msg &= (i.ToString + ",  ")

                'To determine Player side, a or b, representing P1 and P2 respectively
                If i Mod 6 = 1 Then
                    change_side()
                End If

                'Beginning of hand animation
                Dim handpbx_str As String = ""
                If i <= 7 Then
                    handpbx_str = "pbx_hand_" & side & (i - 1)
                ElseIf i > 7 Then
                    Dim catch12 As Int16 = i

                    catch12 = i Mod 7
                    If catch12 = 0 Then
                        catch12 = 6
                    End If
                    handpbx_str = "pbx_hand_" & side & (catch12)
                End If

                Dim handpbx As PictureBox = DirectCast(Me.Controls.Find(handpbx_str, True).FirstOrDefault(), PictureBox)
                handpbx.Image = Nothing


                Dim nu_handpbx_str As String = ""
                If i < 7 Then
                    nu_handpbx_str = "pbx_hand_" & side & (i)
                ElseIf i > 6 Then
                    Dim catch12 As Int16 = i

                    If catch12 Mod 6 = 0 Then
                        catch12 = 6
                    Else
                        catch12 = i Mod 6
                    End If
                    nu_handpbx_str = "pbx_hand_" & side & (catch12)
                End If

                Dim nu_handpbx As PictureBox = DirectCast(Me.Controls.Find(nu_handpbx_str, True).FirstOrDefault(), PictureBox)

                If side = "a" Then
                    nu_handpbx.Image = imghand1
                ElseIf side = "b" Then
                    nu_handpbx.Image = imghand2
                End If


                Dim nupbx_str As String = ""

                If i <= 6 Then
                    nupbx_str = "pbx_" & side & (i)
                ElseIf i > 6 Then
                    Dim catch12 As Int16 = i

                    If catch12 Mod 6 = 0 Then
                        catch12 = 6
                    Else
                        catch12 = i Mod 6
                    End If
                    nupbx_str = "pbx_" & side & (catch12)
                End If

                Dim nupbx As PictureBox = DirectCast(Me.Controls.Find(nupbx_str, True).FirstOrDefault(), PictureBox)

                If nupbx.Image Is img0 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img1
                        Exit For
                    Else
                        nupbx.Image = img1
                    End If
                ElseIf nupbx.Image Is img1 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 2, current_player)
                    Else
                        nupbx.Image = img2
                    End If
                ElseIf nupbx.Image Is img2 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 3, current_player)
                    Else
                        nupbx.Image = img3
                    End If
                ElseIf nupbx.Image Is img3 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        If current_player = "player_1" Then
                            player_1_score += 4
                            lbl_score_a.Text = player_1_score.ToString
                        ElseIf current_player = "player_2" Then
                            player_2_score += 4
                            lbl_score_b.Text = player_2_score.ToString
                        End If
                    Else
                        nupbx.Image = img4
                    End If
                ElseIf nupbx.Image Is img4 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 5, current_player)
                    Else
                        nupbx.Image = img5
                    End If
                ElseIf nupbx.Image Is img5 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 6, current_player)
                    Else
                        nupbx.Image = img6
                    End If
                ElseIf nupbx.Image Is img6 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 7, current_player)
                    Else
                        nupbx.Image = img7
                    End If
                ElseIf nupbx.Image Is img7 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 8, current_player)
                    Else
                        nupbx.Image = img8
                    End If
                ElseIf nupbx.Image Is img8 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 9, current_player)
                    Else
                        nupbx.Image = img9
                    End If
                ElseIf nupbx.Image Is img9 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 10, current_player)
                    Else
                        nupbx.Image = img10
                    End If
                ElseIf nupbx.Image Is img10 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 11, current_player)
                    Else
                        nupbx.Image = img11
                    End If
                ElseIf nupbx.Image Is img11 Then
                    If i = (seed_num + start_bx) Then
                        nupbx.Image = img0
                        dbug_msg &= ("Picked" & vbCrLf)
                        pbx_change(nupbx, 12, current_player)
                    Else
                        nupbx.Image = img12
                    End If
                    'ElseIf nupbx.Image Is img12 Then
                    '    If i = (seed_num + start_bx) Then
                    '        nupbx.Image = img0
                    '        pbx_change(nupbx, 7, current_player)
                    '    Else
                    '        nupbx.Image = img7
                    '    End If
                End If

                dbug_msg &= (nupbx_str & vbCrLf)
                counter += 1

                Me.Refresh()
                System.Threading.Thread.Sleep(600)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Shared Function get_num(ByVal value As String) As Integer
        Dim returnVal As String = ""
        Dim myChars() As Char = value.ToCharArray()
        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                returnVal += ch.ToString
            End If
        Next
        Return Convert.ToInt32(returnVal)
    End Function

    Private Sub change_player()
        If current_player = "player_1" Then
            myTimer.Stop()
            current_player = "player_2"

            lbl_p1_turn.Visible = False
            lbl_p2_turn.Visible = True
            lbl_player_status.Text = "2"
            myTimer.Start()
        ElseIf current_player = "player_2" Then
            myTimer.Stop()
            current_player = "player_1"

            lbl_p1_turn.Visible = True
            lbl_p2_turn.Visible = False
            lbl_player_status.Text = "1"
            myTimer.Start()
        End If
    End Sub

    Private Sub change_side()
        If side = "a" Then
            side = "b"
        ElseIf side = "b" Then
            side = "a"
        End If
    End Sub

    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        If current_player = "player_1" Then
            lbl_p1_turn.Visible = Not lbl_p1_turn.Visible
        ElseIf current_player = "player_2" Then
            lbl_p2_turn.Visible = Not lbl_p2_turn.Visible
        End If
    End Sub

    Private Sub btn_diagnosis_Click(sender As Object, e As EventArgs) Handles btn_diagnosis.Click
        Dim nu_dbg As Form = New frm_diagnosis(dbug_msg)
        nu_dbg.Show()
    End Sub

    Private Function player_side_checker(ByVal player As String, ByVal played As PictureBox) As Boolean
        Dim nupbx_str As String = ""

        If played.Name.ToString.Contains("a") And player = "player_1" Then
            Return True
        ElseIf played.Name.ToString.Contains("b") And player = "player_2" Then
            Return True
        Else
            For j As Int16 = 1 To 6
                If played.Name.ToString.Contains("a") Then
                    nupbx_str = "pbx_a" & j.ToString
                ElseIf played.Name.ToString.Contains("b") Then
                    nupbx_str = "pbx_b" & j.ToString
                End If

                Dim pbx As PictureBox = DirectCast(Me.Controls.Find(nupbx_str, True).FirstOrDefault(), PictureBox)
                If Not pbx.Image Is img0 Then
                    Return False
                End If

            Next
        End If

        'Return True
    End Function

    Private Function return_proper(ByVal player As String) As String
        If player = "player_1" Then
            Return "Player 1"
        ElseIf player = "player_2" Then
            Return "Player 2"
        End If
    End Function

    Private Sub btn_new_game_Click(sender As Object, e As EventArgs) Handles btn_new_game.Click
        Me.Refresh()
        InvokePaint(Me, e)
        frm_olopon_Load(sender, e)
    End Sub
End Class
