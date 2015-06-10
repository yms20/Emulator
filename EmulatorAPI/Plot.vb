
Imports System.Xml.Serialization
Imports System.ComponentModel
Imports System.Drawing

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Plot

  <XmlAttribute()> _
  Public Property enabled As Boolean = True  'show
  <XmlAttribute()> _
  Public Property scale As Double = 1  'location (ticks) / pixel  

  Public Property color as Color 

  Public Property Offset As New PointEMU 'Relative Pixel to parent
  Public Property BoundingBox As New Rect() ' placeholder, graphicspath is not 
  

  Public Sub draw(g As Graphics ) 
    g.TranslateTransform (Offset.x ,Offset.y)

    g.DrawRectangle (new Pen(  color)  , BoundingBox.Bounds) 

    g.TranslateTransform (- Offset.x , - Offset.y)

  End Sub

End Class


<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class PointEMU

  <XmlAttribute > _ 
  public Property x As Integer  = 0
  <XmlAttribute > _ 
  public Property y As Integer = 0

  Public Sub new
  End Sub

  Public Sub new (x As Integer, y As Integer)
    Me.x = x 
    Me.y = y 
  End Sub

End Class


<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Rect
 
public Sub new 
End Sub

public Sub New(x As Integer, y As Integer, w As Integer, h As Integer)
' TODO: Complete member initialization 
  Me.x = x 
  Me.y = y 
  Me.width = w 
  Me.height = h  
 End Sub 

<XmlAttribute > _ 
public Property x As Integer = 0
<XmlAttribute > _ 
public Property y As Integer = 0
<XmlAttribute > _ 
public Property width As Integer = 10
<XmlAttribute > _ 
public Property height As Integer = 10

Public Function Bounds As Rectangle
  Return New Rectangle (x,y,width,height )
End Function
End Class