Imports System.Threading

Public Class Form1
    Private tread As Thread

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tread = New Thread(AddressOf DoShit)
        tread.Start()
        Timer1.Start()



    End Sub

    Private fgt As String

    Public Sub RecDir(Dirt As String)
        For Each File As String In My.Computer.FileSystem.GetFiles(Dirt)
            If File.ToLower.Contains("stuxnet") Then
                MsgBox("we find stux.net == done! " & File)
            Else
                fgt = File

            End If
        Next

        For Each Dir As String In My.Computer.FileSystem.GetDirectories(Dirt)
            Try
                RecDir(Dir)
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub DoShit()
        RecDir("C:\")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = fgt

    End Sub
End Class
