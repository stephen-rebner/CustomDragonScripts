Declare Function keybd_event Lib "user32.dll" (ByVal vKey As _
Long, bScan As Long, ByVal Flag As Long, ByVal exInfo As Long) As Long

Const VK_CTRL = 17

Sub Main
	SendDragonKeys "{Enter}"
    Wait 0.1
	keybd_event(VK_CTRL,0,2,0)  'Releases the CTRL Key
End Sub
