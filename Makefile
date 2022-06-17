all:



.PHONY: build android
build android:
	dotnet clean -f:net6.0-android -c:Debug
	dotnet publish -f:net6.0-android -c:Debug

.PHONY: build android release
build android release:
	dotnet clean -f:net6.0-android -c:Release
	dotnet publish -f:net6.0-android -c:Release