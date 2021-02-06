@ECHO OFF

for /l %x in (1, 1, 10) do (
	RMQ.Consumer.exe %x
) 