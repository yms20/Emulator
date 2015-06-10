Imports EmulatorAPI
Imports System.Reflection

Public Class scenePlotter

  Public achsen As New List(Of Achse)

  Public Property scale As Double = 1.7
  Public Property offset As Point = New Point 
  Dim mouseDownPos As Point 

    'Optional drawables
    Public Property isDrawingAxisNames As Boolean = True
    Public Property isDrawingSignalNames As Boolean = true
    Public Property isDrawingSignals As Boolean = true

    Public Property isDrawingParentOffset As Boolean = False
    Public Property isDrawingLocalOrigin   As Boolean = False
    Public Property isDrawingAxisCurrentLocation As Boolean = False


  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.DoubleBuffered = True
    SetStyle(ControlStyles.AllPaintingInWmPaint Or _
    ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

  End Sub

  Private Sub drawAchse(a As Achse, g As Graphics)



      If isDrawingParentOffset then g.DrawLine(Pens.Black , 0,0,a.geber.Plot.Offset.X , a.geber.Plot.Offset.Y ) 

      'move to offeset
      g.TranslateTransform(a.geber.Plot.Offset.X, a.geber.Plot.Offset.Y)
'optionals
      If isDrawingLocalOrigin then  g.DrawEllipse(Pens.Black , New Rectangle (-2,-2,4,4))
      If isDrawingAxisNames   then  g.DrawString(a.name, Font, Brushes.Black, Point.Empty )




  'draw Axis 
      a.plot.draw(g) 
  'draw Geber
      Select Case (a.geber.GetType)
        Case GetType(Geber)
          drawGeber(a.geber, g)
          drawAchseLinear(a, g)
        Case GetType(GeberRotation)
          drawAchseRotation(a, g)
      End Select

      If isDrawingSignals then drawSignals(a, g)

      'geber current pos 
       Dim p As Point = a.geber.getScaledPoint(a.geber.location)
      'Draw SubAchse
        For Each sa As Achse In a.geber.SubAchsen
        'erst verdrehen
          If a.geber.GetType Is GetType(GeberRotation) Then
            p = Point.Empty
            g.RotateTransform(a.geber.Orientation)
          End If
          'dann verschieben
          g.TranslateTransform(p.X, p.Y)
          'jetzt zeichnen
          drawAchse(sa, g)
          'dann zurück schieben
          g.TranslateTransform(-p.X, -p.Y)
          'dann zurück drehen
          If a.geber.GetType Is GetType(GeberRotation) Then
            g.RotateTransform(-a.geber.Orientation)
          End If
        Next

        g.TranslateTransform(-a.geber.Plot.Offset.X, -a.geber.Plot.Offset.Y)

  End Sub

Sub drawAchseLinear(a As Achse, g As Graphics)

      Dim min As Point = a.geber.getScaledPoint(a.geber.min)
      Dim max As Point = a.geber.getScaledPoint(a.geber.max)

      'Draw Axis
      g.DrawLine(Pens.DarkGray, min, max)


    If (isDrawingAxisCurrentLocation) then 
      Dim cur As Point = a.geber.getScaledPoint (a.geber.location )
      g.DrawEllipse (Pens.Black , New Rectangle (cur.X -2, cur.Y -2,4,4) )
    End If

End Sub

Sub drawAchseRotation(a As Achse, g As Graphics)
  Dim size = a.geber.Plot.BoundingBox.Bounds.Size
  Dim rect As New Rectangle(-size.Width / 2, -size.Height / 2, size.Width, size.Height)

  g.DrawEllipse(Pens.White, rect)
  g.DrawLine(Pens.AntiqueWhite, Point.Empty, New Point(Math.Cos(a.geber.OrientationInRad) * size.Width, Math.Sin(a.geber.OrientationInRad) * size.Height))

End Sub

  Sub drawGeber(geber As Geber, g As Graphics)
    Dim p As Point = geber.getScaledPoint(geber.location)  'geber current pos

    'Draw Geber (as defined through Form in XML, currently only a Rechtangle)
    Dim gRect As Rectangle = geber.Plot.BoundingBox.Bounds
    gRect.Offset(p)
    g.DrawRectangle(Pens.Black, gRect)
  End Sub


  Sub drawSignals(a As Achse, g As Graphics)
    'draw Signals 
    For Each s As Signal In a.Signals
      Dim startP As Point = a.geber.getScaledPoint(s.value)
      Dim endP As Point = a.geber.getScaledPoint(s.value2)
      Dim length As Integer = Math.Max(Math.Abs(endP.X - startP.X), 5)
      'paint nice shiny glow if sensor is triggered
      If (s.isTriggered) Then
        Dim triggerShineRadius As Integer = 2
        g.FillEllipse( _
          Brushes.Yellow, _
          New Rectangle( _
            New Point(startP.X - triggerShineRadius / 2, startP.Y - triggerShineRadius / 2), _
            New Size(length + triggerShineRadius, 5 + triggerShineRadius) _
          ) _
        )
      End If
      'indicate that there is a sensor
      g.FillEllipse(Brushes.YellowGreen, New Rectangle(startP, New Size(length, 5)))
      'Benennen der Signale
     If isDrawingSignalNames Then g.DrawString(s.name, Font, Brushes.Blue, New Point(startP.X, startP.Y - Font.Size))
    Next
  End Sub

  Protected Overrides Sub OnPaint(e As PaintEventArgs)
  e.Graphics.ScaleTransform(scale, scale)
  e.Graphics.TranslateTransform (offset.X , offset.Y ) 
  MyBase.OnPaint(e)
    Dim origin = Point.Empty
    For Each a As Achse In achsen
      'drawAchse (origin,a,e.Graphics ) 
      drawAchse(a, e.Graphics)
      'Dim g As Geber = a .geber 
      'dim p As  Point = g.getScaledPoint (g.location )

      ''Draw Axis
      'e.Graphics.DrawLine (Pens.DarkGray  , g.getScaledPoint (g.min ) , g.getScaledPoint (g.max ))    
      'e.Graphics.DrawString (a.name ,Font,Brushes.Black,g.getScaledPoint (g.min ) ) 
      ''e.Graphics.DrawEllipse (Pens.Black ,New Rectangle (p - New Point (5,5) ,New Size (10,10)))

      ''Draw Geber (as defined through Form in XML, currently only a Rechtangle)
      'Dim gRect As Rectangle = g.form.toRectangle
      'gRect.Offset (p)
      'e.Graphics.DrawRectangle  (Pens.Black ,gRect)

      ''draw Signals 
      'For Each  s As Signal In a.signals 
      '  Dim startP  As Point = g.getScaledPoint(s.value )
      '  Dim endP    As Point = g.getScaledPoint(s.value2 )
      '  Dim length  As Integer = Math.Max ( Math.Abs (endP.X - startP.X ) , 5 ) 
      '  'paint nice shiny glow if sensor is triggered
      '  If (s.isTriggered )
      '    Dim triggerShineRadius As Integer = 2
      '    e.Graphics.FillEllipse ( _ 
      '      Brushes.Yellow , _ 
      '      New Rectangle ( _
      '        New Point (startP.X - triggerShineRadius / 2 , startP.Y - triggerShineRadius / 2) , _
      '        New Size (length + triggerShineRadius , 5 + triggerShineRadius ) _ 
      '      ) _ 
      '    )
      '  End If
      '  'indicate that there is a sensor
      '  e.Graphics.FillEllipse (Brushes.YellowGreen ,New Rectangle ( startP ,New Size (length, 5)))

      '  e.Graphics.DrawString (s.name ,Font,Brushes.Blue,startP )
      'Next

      ''Draw SubAchse
      'If (Not IsNothing (a.geber.subAchse ) AndAlso  Not IsNothing (a.geber.subAchse.geber  ) )
      '  Dim g1 As Geber = a.geber.subAchse.geber 
      '  Dim p1 As Point = p + g1.getScaledPoint (g1.location ) 
      '  Dim g1Rect As Rectangle = g1.form.toRectangle 
      '  g1Rect.Offset ( p1 ) 
      '  e.Graphics.DrawLine (Pens.Gray , p + g1.getScaledPoint (g1.min ) , p + g1.getScaledPoint (g1.max ))        
      '  'e.Graphics.DrawEllipse (Pens.Black ,New Rectangle (p1 - New Point (5,5) ,New Size (10,10)))
      '  e.Graphics.DrawRectangle  (Pens.Black ,g1Rect) 

      'End If
    Next
  End Sub

  Private Sub scenePlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Timer1.Enabled = True
    Focus()

    Dim propertyInfo As PropertyInfo() = Me.GetType().GetProperties()

    For Each entry as PropertyInfo in propertyInfo
        If entry.Name.ToLower.Contains("isdrawing")
          Dim mi As New ToolStripMenuItem  (entry.Name )
          mi.Checked = entry.GetValue(Me)
mi.Tag = entry
          AddHandler mi.Click , AddressOf toggleHandler 

          ContextMenuStrip1.items.Add  (mi)

        End If
    Next
  End Sub

Sub toggleHandler (sender As Object , e As EventArgs )

  Dim pi As PropertyInfo = sender.tag 
  Dim item As ToolStripMenuItem = sender 
  item.Checked = Not pi.GetValue(Me) 
  pi.SetValue (Me,Not pi.GetValue(Me) )

End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Refresh()
  End Sub


Private Sub scenePlotter_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
  Select Case e.Button
  Case Windows.Forms.MouseButtons.Left
    mouseDownPos = e.Location 
 
Case Windows.Forms.MouseButtons.Middle
    offset = Point.Empty 
    scale = 1.7
  End Select
End Sub

Private Sub IstHallWeltToolStripMenuItem_Click( sender As Object,  e As EventArgs) 
 'hallt = alles scheisse !

End Sub

Private Sub scenePlotter_MouseMove( sender As Object,  e As MouseEventArgs) Handles MyBase.MouseMove
  If ( mouseDownPos <> Point.Empty )

    Dim delta As Point = (  e.Location - mouseDownPos)
    delta.X = delta.X * 1/scale 
    delta.Y = delta.Y * 1/scale 
    offset += delta
    mouseDownPos = e.Location 
  End If

End Sub

Private Sub scenePlotter_MouseUp( sender As Object,  e As MouseEventArgs) Handles MyBase.MouseUp
  mouseDownPos = Nothing 
End Sub


Private Sub scenePlotter_MouseWheel( sender As Object,  e As MouseEventArgs) Handles MyBase.MouseWheel 
      
      scale += 0.001 * e.Delta 
End Sub
End Class
