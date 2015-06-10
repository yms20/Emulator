Imports System.ComponentModel
Imports System.Drawing
Imports System.Xml.Serialization

<XmlInclude(GetType(GeberRotation))> _ 
<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Achse
Inherits Aggregat
  <CategoryAttribute("Aggregats"), DisplayName("Motor")> _
  Public Property motor As Motor
  Public Property getriebe As Getriebe
  
  <XmlAttribute()> _
  Public Property can_id As Integer

  'sorgt dafür das XML Tag richtig benannt wird
  <XmlElement(Type:=GetType(Geber )  )> _
  <XmlElement(Type:=GetType(GeberRotation )  )> _ 
  Public Property geber As Geber

  Public Property plot As new Plot 


  Public Signals As New List(Of Signal)
  <CategoryAttribute("Aggregats"), DisplayName("Signals")> _
  Public Property SignalsList As Signal()
    Get
      Return Signals.ToArray
    End Get
    Set(value As Signal())
      Signals = New List(Of Signal)(value)
    End Set
  End Property

  Public Sub New()
    name = "Achse"
  End Sub

Public Shared Function config1() As Achse

  Dim a As New Achse
  a.motor = New Motor
  a.getriebe = New Getriebe
  a.geber = New Geber With {.max = 100, .min = -100, .Orientation = 0}
  a.geber.Plot.Offset = New PointEMU(15, 15)

  a.geber.plot.enabled = True
  a.geber.Plot.BoundingBox = New Rect(0, 0, 20, 5)

  Dim aInner As New Achse

  aInner.motor = New Motor
  aInner.getriebe = New Getriebe With {.traslation = 10}
  aInner.geber = New Geber With { .max = 100, .min = -100, .Orientation = 90}
  aInner.geber.Plot.Offset = New PointEMU(0, 15)
  
  a.geber.SubAchsen.Add (aInner )

  Dim s As New Signal
  s.value = 1
  s.value2 = 2
s.name = "Referenz Sensor"
  s.rule = Signal.ruleType.between

  a.Signals.Add(s)

  a.setConnections()
  Return a

End Function

Public Sub setConnections()
  If Not IsNothing(motor) _
  And Not IsNothing(getriebe) _
  And Not IsNothing(geber) Then
    'set up Motor -> Getriebe -> Geber
    AddHandler motor.moved, AddressOf getriebe.handleMotorMove
    AddHandler getriebe.moved, AddressOf geber.handleMove

    'Connect all Signals to the geber
    For Each s As Signal In Signals
      AddHandler geber.movedTo, AddressOf s.handleMove
    Next

  Else
    Console.WriteLine("Achse: setConnections: not all inited")
  End If
End Sub

Public Overrides Function ToString() As String
Return String.Format ("{0} M-Name {1}",name,motor.name  )
End Function

End Class



Public Class Achsen
Public Achsen As New List(Of Achse)
End Class
