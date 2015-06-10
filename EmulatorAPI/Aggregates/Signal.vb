Imports System.ComponentModel
Imports System.Xml.Serialization

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Signal
Inherits Aggregat

Enum ruleType
  greater
  lesser
  equal
  between
End Enum

<XmlAttribute> _
Public Property rule As ruleType
<XmlAttribute> _
Public Property value As Double
<XmlAttribute> _
Public Property value2 As Double

<XmlAttribute > _ 
Public isTriggered As Boolean = False

Private lastvalue As New Queue(Of Double)(5)

Public Event triggered(sender As Aggregat)
Public Event untriggered(sender As Aggregat)

Private driver As Aggregat

Public Sub New()
  name = "Signal"
End Sub


Public Sub handleMove(sender As Aggregat, value As Double)

  Me.driver = sender

  lastvalue.Enqueue(value)
  If (lastvalue.Count > 5) Then
    lastvalue.Dequeue()
  End If

  Select Case rule
    Case ruleType.between
      'if value between
      If (value > Me.value And value < Me.value2) Then
        If Not isTriggered Then
          Me.isTriggered = True
          RaiseEvent triggered(Me)
        End If

      Else 'if not between
        If isTriggered Then
          isTriggered = False
          RaiseEvent untriggered(Me)
        End If
      End If

'TODO implement all other rules
  End Select

End Sub

Public Function getDriver() As Aggregat
  Return driver
End Function

End Class
