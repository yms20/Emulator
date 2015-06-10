Imports EmulatorAPI

Public Class Plotter
  Enum scaleModes 
    Dynamic
    Fixed 
  End Enum

  Private values As New Queue(Of Double)
  Public maxVals As Integer = Me.Width 'max data count - one value in queue per pixel
  Public scaleMode As scaleModes = scaleModes.Dynamic
  Public min As Double = 0
  Public max As Double = 1 
  Public lastValue As Double = min
   

  Public lbAchseSet As Boolean = False 
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.DoubleBuffered = True
    SetStyle(ControlStyles.AllPaintingInWmPaint Or _
    ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)

  End Sub

    'returns 1 or if bigger unsigned difference between min and max 
    Public ReadOnly Property ValueRange As Double 
      Get
          Return Math.Max(Math.Abs(min - max), 1)
      End Get
    End Property

  Sub calcDynamicScale 
    Dim yVals As List(Of Double)
    SyncLock (values)
      yVals = values.ToList
    End SyncLock
    'calc scale factor for Y Axis
    min = yVals.Min 
    max = yVals.Max

  End Sub

  Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

    If values.Count <= 0 Then
      Return
    End If

    Dim path As New System.Drawing.Drawing2D.GraphicsPath()

    Dim yVals As List(Of Double)

    SyncLock (values)
      yVals = values.ToList
    End SyncLock

    If me.scaleMode = scaleModes.Dynamic
      calcDynamicScale 
    End If
    
    'calc scale factor for Y Axis
    Dim factor As Double = (Me.Height - 4) / ValueRange

    Dim x As Integer = 0
    For Each y As Double In yVals
      Dim yInt As Integer = Me.Height - 2 - CInt((y - min) * factor)
      path.AddLine(x, yInt, x, yInt)
      x += 1
    Next
    If (path.PointCount > 2) Then
      e.Graphics.DrawPath(Pens.Black, path)
    End If

  End Sub

  Public Sub addValue(value As Double)

    SyncLock (values)
    values.Enqueue(value)
    If values.Count > maxVals Then
      values.Dequeue()
    End If
    End SyncLock

  End Sub

  Public Sub addValue(sender As Aggregat, value As Double)
      
      If (Not lbAchseSet )
        'set Name only once
        setAchsenText ( sender)
        lbAchseSet = True 
      End If

      addValue (value) 
  End Sub

  Function setAchsenText ( sender As Aggregat )
    If lbAchse.InvokeRequired 
      lbAchse.Invoke ( Function ()   setAchsenText(sender)  )
    Else
      lbAchse.Text = sender.name 
    End If
  End Function

Private Sub Plotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub

Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
  Refresh 
End Sub

Private Sub Plotter_Resize( sender As Object,  e As EventArgs) Handles MyBase.Resize
  maxVals = Me.Width
  For i As Integer = 0 To maxVals
    addValue(min)
  Next
  Timer1.Enabled = True 
End Sub
End Class
