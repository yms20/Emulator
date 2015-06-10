Imports System.ComponentModel
Imports System.Xml.Serialization

<TypeConverter(GetType(ExpandableObjectConverter))> _
<XmlType(TypeName:="GeberRotation")> _
Public Class GeberRotation
Inherits Geber
  
  <XmlAttribute()> _
  Public Property default_direction As Integer = 1  '1:right turning motor -1:left turning motor

  <XmlAttribute()> _
  Public Overrides Property Orientation As Double
    Get
    Return MyBase.Orientation + ( location * default_direction  )
    End Get
    Set
    location  = ( value * default_direction ) 
    End Set
  End Property

End Class
