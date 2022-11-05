'#Language "WWB-COM

'The command is spoken as: "wheel down <number of times to execute>"
'This allows the mouse scroll wheel to be used, which is something that can't be done out of the box using Dragon.
'#Language "WWB-COM"
Declare Function mouse_event Lib "user32.dll" (ByVal dB As Long, ByVal dX As Long, ByVal dY As Long, ByVal dP As Long, ByVal dE As Long) As Long
 
Sub Main
  dist = CInt(ListVar1)
  mouse_event(&H800,0,0,120*dist,0) 
End Sub
