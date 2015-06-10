Imports System.Xml.Serialization

Public Class Aggregat

  Public Event valueChanged(sender As Aggregat)

  Public Shared instance_ctr As Integer = 0

  <XmlAttribute()> _
  Public Property  name As String = "Aggregat"
  <XmlAttribute()> _
  Public Property id As Integer


  Public Sub New()
    'inc id
    id = instance_ctr
    instance_ctr += 1
  End Sub


End Class
