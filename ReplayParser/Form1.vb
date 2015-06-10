Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Runtime.Remoting

Public Class Form1

Dim movements As New Dictionary(Of Date, Bewegung)

  Dim commads  As EmulatorAPI.ICommands


Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
  OpenFileDialog1.ShowDialog()
  TextBox1.Text = OpenFileDialog1.FileName

End Sub
Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk

End Sub

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

movements = New Dictionary(Of Date, Bewegung)

Try

  Dim needles As New Generic.List(Of String)(TextBox2_SucheLinks.Text.Split(Environment.NewLine))
  needles.AddRange(TextBox5_SucheRechts.Text.Split(Environment.NewLine))

  Dim sr As New StreamReader(TextBox1.Text)
  Dim s As String = sr.ReadLine
  Do While Not IsNothing(s)
    Dim datee As DateTime
    If s.Length > NumericUpDown1.Value Then
      DateTime.TryParse(s.Substring(0, NumericUpDown1.Value), datee)
    End If

    Dim dateNull = New Date
    If datee > dateNull And containsOne(s, needles) Then

      Dim pattern As String = "[^\(\d+\,\s\d+\,\s\d+\)]"
      Dim replacement As String = " "
      Dim rgx As New Regex(pattern)
      Dim result As String = rgx.Replace(s, replacement)

      Dim rest As String = result
      Dim res1 As String() = rest.Split("(")

      Dim von As String = res1(1).Replace(")", "")
      Dim nach As String = res1(2).Replace(")", "")

      Dim vonStrings As String() = von.Split(",")
      Dim nachStrings As String() = nach.Split(",")

      Dim von_koord As New RegalKoordinate
      Integer.TryParse(vonStrings(0), von_koord.Xticks)
      Integer.TryParse(vonStrings(1), von_koord.Yticks)
      Integer.TryParse(vonStrings(2), von_koord.drehwinkel)

      Dim nach_koord As New RegalKoordinate
      Integer.TryParse(nachStrings(0), nach_koord.Xticks)
      Integer.TryParse(nachStrings(1), nach_koord.Yticks)
      Integer.TryParse(nachStrings(2), nach_koord.drehwinkel)

      Dim bewegung As New Bewegung
      bewegung.von = von_koord
      bewegung.nach = nach_koord
      bewegung.zeitpunkt = datee
      If (s.Contains("left")) Then
        bewegung.seite = ReplayParser.Bewegung.seiten.links
      Else
        bewegung.seite = ReplayParser.Bewegung.seiten.rechts
      End If
      movements.Add(datee, bewegung)

      'TextBox3.AppendText( s & Environment.newLine)
      'TextBox3.AppendText(datee.ToString & ": " & von_koord.ToString  & "   " & nach_koord.ToString  & Environment.NewLine)

    End If
    'dont forget the progress
    s = sr.ReadLine
  Loop


Catch ex As Exception
  TextBox3.AppendText(ex.Message & Environment.NewLine)
End Try


displayMovements()

End Sub


Sub displayMovements()
  Dim keys As List(Of Date) = movements.Keys.ToList
  keys.Sort()

  For Each d As Date In keys
    Dim spaces As String = ""
    If (movements(d).seite = Bewegung.seiten.rechts) Then
      spaces = " ".PadLeft(40, " ")

    End If
      Dim source As  EmulatorAPI.XYTCoord 
      source.x = movements(d).von.Xticks 
      source.y = movements(d).von.Yticks 
      source.t = movements(d).von.drehwinkel

      Dim target As  EmulatorAPI.XYTCoord 
      target.x = movements(d).nach.Xticks 
      target.y = movements(d).nach.Yticks 
      target.t = movements(d).nach.drehwinkel

If Not IsNothing(commads )
    If (movements(d).seite = Bewegung.seiten.rechts) Then
      ''commads.place (4,movements(d).von.Xticks )
      'commads.drive (4,movements(d).von.Xticks )
      'commads.drive (5,movements(d).von.Yticks )
      'commads.drive (8,movements(d).von.drehwinkel )

      ''commads.place (4,movements(d).von.Xticks )
      'commads.drive (4,movements(d).nach.Xticks )
      'commads.drive (5,movements(d).nach.Yticks )
      'commads.drive (8,movements(d).nach.drehwinkel )
      commads.driveRight (source )
      commads.driveRight (target )

    End If
    If (movements(d).seite = Bewegung.seiten.links) Then

      ''commads.place (4,movements(d).von.Xticks )
      'commads.drive (2,movements(d).von.Xticks )
      'commads.drive (3,movements(d).von.Yticks )
      'commads.drive (6,movements(d).von.drehwinkel )
      ''commads.place (4,movements(d).von.Xticks )
      'commads.drive (2,movements(d).nach.Xticks )
      'commads.drive (3,movements(d).nach.Yticks )
      'commads.drive (6,movements(d).nach.drehwinkel )
      commads.driveLeft (source )
      commads.driveLeft  (target )
    End If
End If


    TextBox3.AppendText(spaces & movements(d).von.ToString & movements(d).nach.ToString & Environment.NewLine)
Next
End Sub

''' <summary>
''' Compars all String in needles with the haystack (lowers all chars)
''' </summary>
''' <param name="haystack"></param>
''' <param name="needles"></param>
Function containsOne(haystack As String, needles As Generic.List(Of String)) As Boolean

For Each needle As String In needles
  If haystack.ToLower.Contains(needle.Trim.ToLower) Then
    Return True
  End If
Next

Return False

End Function

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    Dim exePath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
    Console.WriteLine(exePath)
    Console.WriteLine("Configuring remotable objects....")
    RemotingConfiguration.Configure(exePath & ".config", False)

    commads   = Activator.GetObject (GetType (EmulatorAPI.ICommands ), "tcp://127.0.0.1:1337/Machine")

 Button2.Enabled = false
End Sub

Private Sub Button3_Click( sender As Object,  e As EventArgs) 

End Sub
End Class


Public Class Bewegung
  Enum seiten
    links
    rechts
  End Enum

  Public zeitpunkt As Date
  Public seite As seiten
  Public von As RegalKoordinate
  Public nach As RegalKoordinate

End Class

Public Class RegalKoordinate

Public Xticks As Integer = 0
Public Yticks As Integer = 0
Public drehwinkel As Integer = 180 '180 rechts,0 links,90 vorn

Public Overrides Function ToString() As String
Return String.Format("[{0},{1},{2}]", Xticks, Yticks, drehwinkel)
End Function
End Class




