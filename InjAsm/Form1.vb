Public Class Form1
    Dim a As New asm

    Private Sub btnInj_Click(sender As Object, e As EventArgs) Handles btnInj.Click


        

        For Each line In txtAsm.Lines
            a.Asm(line)
        Next



        MsgBox(a.ToString & " - " & a.pos)
        a.Clear

        
    End Sub
End Class
