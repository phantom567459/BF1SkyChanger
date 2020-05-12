Public Class DataParser
    Public Shared Function ParseSkyData(ByVal Filename As String, ByVal SearchVal As Byte()) As Object
        'Dim Search1 As Byte()
        'Dim Search2 As Byte()
        ' Search1 = {154, 28, 85, 80} 'nearscenerange
        ' Search2 = {123, 43, 25, 1} 'farscenerange

        Dim b() As Byte = IO.File.ReadAllBytes(Filename)
        Dim fs As New IO.FileStream(Filename, IO.FileMode.Open)
        Dim binary_reader As New IO.BinaryReader(fs)
        Dim Startindex = 0
        Dim bFound As Boolean = True
        Dim encoding As New System.Text.ASCIIEncoding

        Dim locByteValues
        Dim locBVasString As String

        For i As Integer = 0 To b.Length - SearchVal.Length - 1
            If b(i) = SearchVal(0) Then
                bFound = True
                For j As Integer = 0 To SearchVal.Length - 1
                    If b(i + j) <> SearchVal(j) Then
                        bFound = False
                        Exit For
                    End If
                Next
                If bFound Then
                    fs.Position = i + 4
                    Dim numfields As Integer
                    numfields = binary_reader.ReadByte()
                    For q As Integer = 0 To numfields - 1
                        locByteValues = binary_reader.ReadBytes(4)
                        locBVasString = locBVasString & BitConverter.ToSingle(locByteValues, 0).ToString()
                        If q <> numfields - 1 Then
                            locBVasString = locBVasString & ","
                        End If
                    Next
                    Exit For 'THIS MAY NEED REMOVED DEPENDING ON EXTENSIBILITY!  FogColor shows up more than once in a sky file, take the first one!
                End If
            End If
            'End If
        Next

        binary_reader.Close()
        fs.Close()

        Return locBVasString
    End Function

    Public Shared Function WriteSkyData(ByVal Filename As String, ByVal SearchVal As Byte(), ByVal writeVals As String) As Object
        Dim b() As Byte = IO.File.ReadAllBytes(Filename)
        Dim fs As New IO.FileStream(Filename, IO.FileMode.Open)
        Dim binary_writer As New IO.BinaryWriter(fs)

        Dim Startindex = 0
        Dim bFound As Boolean = True
        Dim encoding As New System.Text.ASCIIEncoding


        Dim valueArray

        valueArray = writeVals.Split(",")
        For i As Integer = 0 To b.Length - SearchVal.Length - 1
            If b(i) = SearchVal(0) Then
                bFound = True
                For j As Integer = 0 To SearchVal.Length - 1
                    If b(i + j) <> SearchVal(j) Then
                        bFound = False
                        Exit For
                    End If
                Next
                If bFound Then
                    fs.Position = i + 5
                    For Each value As String In valueArray
                        Dim bytevalue = Convert.ToSingle(value)
                        binary_writer.Write(bytevalue)
                        'UpdateProjectLog(value)
                    Next
                    Exit For 'THIS MAY NEED REMOVED DEPENDING ON EXTENSIBILITY!  FogColor shows up more than once in a sky file, take the first one!
                End If
            End If
        Next

        binary_writer.Close()
        fs.Close()
    End Function

    Sub UpdateProjectLog(ByVal projlog As String)
        'this updates the project log.  new log is generated on run
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("log.txt", True)
        file.Write(projlog)
        file.Close()
    End Sub


End Class
