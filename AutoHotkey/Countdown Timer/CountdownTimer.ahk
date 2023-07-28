/*
	=======================================
	==============ChangeLog================
	=======================================
	Author: 		Sharvin Suntoobacus
	Date: 			10:29 PM 2/15/2021
	Version: 		1.0
	Description:	CountDown Timer
	Modifications:	
		12:37 PM 6/30/2021: Modifying script to show countdown timer instead of epic seven Timer
							Change to #NoTrayIcon
							Change Icon to use when compiled as an executable
							Remove GuiClose, ExitApp -> the app will not exit when user clicks on close button
							Change msgbox to a custom gui with no activate.
							Adding logic to prompt user to add a task if there are no active tasks, timer 10 minutes.
		3:03 PM 8/9/2021: Modifying script to track one task at a time.
						  Allow for multiple instances.
						  Give GUI unique id to pinpoint.
		10:40 AM 8/10/2021: Updated script to show task name as title.
		6:55 PM 27-Mar-22: Change notification placement to middle of screen.
*/
#NoEnv
#Persistent
#SingleInstance, Off
SetWorkingDir %A_ScriptDir%
SetFormat, Float, 0.0
#NoTrayIcon

TaskAdded1 := false
Gui +HwndThis
TitleName := "Task Timer"
SetGuiTitle(TitleName, This, NewTitle)
Gui, 1:New, , %NewTitle%
Gui, 1:Add, Text, x10 y10 vTimerName1, 00:00
Gui, 1:Add, Edit, x50 y7 w200 vEditTimer1, Take a Break
Gui, 1:Add, Edit, x265 y7 w30 center vEditTimer1Hour, 0
Gui, 1:Add, Edit, x300 y7 w30 center vEditTimer1Minute, 45
Gui, 1:Add, Button, x340 y7 gStartTimer1, Start
Gui, 1:Add, Button, x385 y7 gResetTimer1, Reset

Gui, 1:Show

SetTimer, checkActiveTask, 300000

return

StartTimer1:
	TaskAdded1 := true
	Gui, Submit, NoHide
	Timer1Sleep := (EditTimer1Hour * 3600) + (EditTimer1Minute * 60)
	GuiControl, 1:, TimerName1, %Timer1Sleep%
	SetGuiTitle(EditTimer1, This, NewTitle)
	WinSetTitle, %NewTitle%
	SetTimer, Timer1, 60000
return

ResetTimer1:
	TaskAdded1 := false
	SetTimer, Timer1, Delete
	GuiControl, 1:, TimerName1, 00:00
	GuiControl, 1:, EditTimer1, 
	GuiControl, 1:, EditTimer1Hour, 0
	GuiControl, 1:, EditTimer1Minute, 0
return

Timer1:
	Timer1Sleep := Timer1Sleep - 60
	hhmm1 := FormatSeconds(Timer1Sleep)
	GuiControl, 1:, TimerName1, %hhmm1%
	if(Timer1Sleep <= 0){
		ShowMessage(EditTimer1)
		SetTimer, Timer1, Delete
		TaskAdded1 := false
	}
return

checkActiveTask:
	If (TaskAdded1 = false)
	{
		SetTimer, checkActiveTask, Off
		SetTimer, changeMsgBoxButtonName, 100
		Msgbox, 262193, Be Productive - %NewTitle%, Add a task boss!!!
		IfMsgBox, OK
		{
			WinRestore, %NewTitle%
			Sleep, 100
			WinActivate, %NewTitle%
		}
		SetTimer, checkActiveTask, On
	}
return

FormatSeconds(NumberOfSeconds)
{
	hour := NumberOfSeconds // 3600
	minutes := Mod(NumberOfSeconds, 3600) // 60
return hour ":" minutes
}
return

ShowMessage(msg){
	Gui, 2:New, +AlwaysOnTop -Resize -SysMenu -Caption, %msg%
	Gui, 2:Color, Lime, Navy
	Gui, 2:Font, s30,
	Gui, 2:Add, Text, , %msg%
	Gui, 2:Show, NoActivate xCenter yCenter,
	Sleep, 10000
	Gui, 2:Destroy
}
return

changeMsgBoxButtonName:
	IfWinNotExist, Be Productive - %NewTitle%
		return
	ControlSetText, Button2, Snooze, Be Productive - %NewTitle%
return

GuiClose:
	Msgbox, 262193, Exit %NewTitle%, Are you sure you want to EXIT!!!
	IfMsgBox, OK
	{
		WinClose, %NewTitle%
		ExitApp
	}
return

SetGuiTitle(TitleName, hwndId, ByRef NewTitle) {
	NewTitle = %TitleName% - %hwndId%
}