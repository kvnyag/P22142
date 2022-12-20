@echo off 
if "%1" == "h" goto begin 
mshta vbscript:createobject("wscript.shell").run("%~nx0 h",0)(window.close)&&exit 
:begin 

cd %cd%/platform-tools/
adb -d shell "am broadcast -a android.intent.action.MEDIA_MOUNTED -d file:///sdcard"
adb shell am broadcast -a com.action.a
