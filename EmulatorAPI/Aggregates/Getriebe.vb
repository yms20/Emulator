Imports System.Xml.Serialization
Imports System.ComponentModel

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Getriebe
Inherits Aggregat

<XmlAttribute()> _
Public Property traslation As Double = 1.0 / 2.0


 ' output revolutions / inupt revolutions

Public Event moved(sender As Aggregat, delta As Double)

Public Sub New()
  name = "Getriebe"
End Sub

'extern connected
Public Sub handleMotorMove(sender As Aggregat, delta As Double)

  RaiseEvent moved(Me, traslation * delta)
End Sub

End Class