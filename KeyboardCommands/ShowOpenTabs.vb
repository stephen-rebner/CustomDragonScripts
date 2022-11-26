Declare Function keybd_event Lib "user32.dll" (ByVal vKey As _
Long, bScan As Long, ByVal Flag As Long, ByVal exInfo As Long) As Long

Const VK_TAB = 9
Const VK_CTRL = 17

Sub Main
	keybd_event(VK_CTRL,0,0,0)  'Hold down the CTRL key
    Wait 0.1
	keybd_event(VK_TAB,0,0,0)  'Hold down the Tab key
    Wait 0.1
	keybd_event(VK_TAB,0,2,0)  'Releases the Tab Key
End Sub
