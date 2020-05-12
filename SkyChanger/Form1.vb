Imports SkyChanger.DataParser
Public Class Form1

    Private Sub openFile_click(sender As Object, e As EventArgs) Handles openFileButton.Click
        Dim Search1, Search2, Search3, Search4 As Byte()

        Dim dlg As New OpenFileDialog
        dlg.DefaultExt = ".lvl"
        dlg.Filter = "LVL Files (.lvl)|*.lvl"
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        If result = True Then
            'open
            Dim filename As String = dlg.FileName
            FileNameTextBox.Text = filename

            Search1 = {154, 28, 85, 80} 'nearscenerange
            Search2 = {123, 43, 25, 1} 'farscenerange
            Search3 = {206, 31, 59, 2} 'fogcolor
            Search4 = {212, 168, 73, 207} 'fogrange

            Dim range As String = ParseSkyData(filename, Search1) 'return nsr
            nsdTextbox.Text = range

            range = ParseSkyData(filename, Search2) 'return fsr
            fsdTextbox.Text = range

            range = ParseSkyData(filename, Search3) 'return fogcolor
            fogColorTextbox.Text = range

            range = ParseSkyData(filename, Search4) 'return fog range
            fogRangeTextbox.Text = range

            FileNameTextBox.Visible = True
            fsd.Visible = True
            nsd.Visible = True
            nsdTextbox.Visible = True
            fsdTextbox.Visible = True
            ChangeButton.Visible = True
        End If

    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Dim filename = FileNameTextBox.Text

        If Not My.Computer.FileSystem.FileExists(filename) Then
            MsgBox("File does not exist")
            Exit Sub
        End If

        Dim Search1, Search2, Search3, Search4 As Byte()
        Search1 = {154, 28, 85, 80} 'nearscenerange
        Search2 = {123, 43, 25, 1} 'farscenerange
        Search3 = {206, 31, 59, 2} 'fogcolor
        Search4 = {212, 168, 73, 207} 'fogrange

        WriteSkyData(filename, Search1, nsdTextbox.Text)
        WriteSkyData(filename, Search2, fsdTextbox.Text)
        WriteSkyData(filename, Search3, fogColorTextbox.Text)
        WriteSkyData(filename, Search4, fogRangeTextbox.Text)

        MsgBox("Values Changed")

    End Sub

    Private Sub helpbtn_Click(sender As Object, e As EventArgs) Handles helpbtn.Click
        Process.Start("http://www.swbfgamers.com/index.php?topic=8418.msg91007#msg91007")
    End Sub
End Class
