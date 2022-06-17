

.PHONY: build android
build android:
	dotnet clean -f:net6.0-android -c:Release
	dotnet publish -f:net6.0-android -c:Release