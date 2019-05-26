Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            Me.Dispose()
            Me.Close()



        End If


    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs)







    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter



    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'TextBox1.Text = ListBox2.SelectedItem
        'AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem


        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.settings.setMode("Loop", True)
        Label2.Hide()
        


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        Label2.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        AxWindowsMediaPlayer1.Ctlcontrols.stop()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Button7.Enabled = False
        Label2.Hide()
        Label3.Hide()

    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem.Click

    End Sub

    Private Sub FullToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub FullScreenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click

        AxWindowsMediaPlayer1.fullScreen = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        AxWindowsMediaPlayer1.settings.mute = True

        Label3.Show()

        Button7.Enabled = True
        Button6.Enabled = False


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        AxWindowsMediaPlayer1.settings.mute = False

        Label3.Hide()

        Button6.Enabled = True
        Button7.Enabled = False

    End Sub

    Dim paths As String()
    Dim filename As String()
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click


        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            filename = OpenFileDialog1.SafeFileNames
            paths = OpenFileDialog1.FileNames

            For i As Integer = 0 To filename.Length - 1
                ListBox2.Items.Add(filename(i))
                AxWindowsMediaPlayer1.URL = paths(ListBox2.SelectedItem + 0)

            Next

            ' Load and Highlight


            If ListBox2.SelectedIndex = ListBox2.Items.Count - 1 Then
                ListBox2.SelectedIndex = 0
            Else
                ListBox2.SelectedIndex += 1
            End If



        End If



        ' OpenFileDialog1.ShowDialog()
        '  AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        'TextBox1.Text = System.IO.Path.GetFileName(ListBox2.SelectedItem)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

       

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

      
    End Sub
   
    Private Sub Button8_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        about.Visible = True

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked




    End Sub

    Private Sub ListBox2_Click(sender As Object, e As EventArgs) Handles ListBox2.Click

        
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick

        

    End Sub

    Private Sub ListBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseClick


    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick

   


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged


        AxWindowsMediaPlayer1.URL = paths(ListBox2.SelectedIndex)

       



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


        AxWindowsMediaPlayer1.Ctlcontrols.play()


    End Sub

    Private Sub ListBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedValueChanged



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        'me.

        ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1

        'AxWindowsMediaPlayer1.settings.setMode("Loop", True)







    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click


        ListBox2.SelectedIndex = ListBox2.SelectedIndex - 1



    End Sub

End Class
