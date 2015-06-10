Imports System.Xml.Serialization
Imports System.Drawing
Imports System.ComponentModel

<TypeConverter(GetType(ExpandableObjectConverter))> _
<XmlType(TypeName:="Geber")> _
Public Class Geber
Inherits Aggregat

  Public Enum Extreme
    min
    max
  End Enum

  Public Property SubAchsen As New  List(Of  Achse )


  <XmlAttribute()> _
  Public Property location As Double = 20
  <XmlAttribute()> _
  Public Property ref_location As Double = 20 'also the pivot for rotation

  <XmlAttribute()> _
  Public Property tolerance As Double = 100 '+/- tolerance for positioning by controller
  <XmlAttribute()> _
  Public Property min As Double = Double.MinValue
  <XmlAttribute()> _
  Public Property  max As Double = Double.MaxValue

  Public Property Plot As New Plot
  


  Dim m_orientation As Double      = 90 ' 360 degree 

<XmlAttribute()> _
Public Overridable Property  Orientation As Double
  Get 
      Return m_orientation 
  End Get
  Set(value As Double)
    m_orientation  = value 
  End Set
End Property

  Public Property OrientationInRad As Double 
  Get
    Return Orientation /180 * Math.PI 
  End Get
  Set(value As Double)
    Orientation = value / Math.PI * 180
  End Set
  End Property



  Public Event movedTo(sender As Aggregat, location As Double) 'sends absolut location
  Public Event endPosReached(sender As Aggregat, e As Extreme)


  Public Sub New()
    name = "Geber"
  End Sub

  Public Overridable Sub handleMove(sender As Aggregat, delta As Double)
    location += delta

    If location < min Then
      location = min
      RaiseEvent endPosReached(Me, Extreme.min)
    End If

    If location > max Then
      location = max
      RaiseEvent endPosReached(Me, Extreme.max)
    End If

    'Console.WriteLine("{0}  moved {1} about {2}  to {3} ", sender.name, name, delta, location)
    RaiseEvent movedTo(Me, location)
  End Sub


  'Public Function getScaledPoint(location As Double  ) As Point
  '    dim p As New Point (  Plot.pos.X  + Math.Cos(OrientationInRad   ) * (location - ref_location ) * Plot.scale , _ 
  '                          Plot.pos.Y  + Math.Sin(OrientationInRad ) * (location - ref_location ) * Plot.scale )
  '    Return p
  'End Function


  Public Function getScaledPoint(location As Double  ) As Point
      dim p As New Point (    Math.Cos(OrientationInRad   ) * (location - ref_location ) * Plot.scale , _ 
                              Math.Sin(OrientationInRad ) * (location - ref_location ) * Plot.scale )
      Return p
  End Function


End Class

