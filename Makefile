all:



.PHONY: build-android-debug
build-android-debug:
	dotnet clean -f:net6.0-android -c:Debug GameSceneControl
	dotnet publish -f:net6.0-android -c:Debug GameSceneControl

.PHONY: build-android-release
build-android-release:
	dotnet clean -f:net6.0-android -c:Release GameSceneControl
	dotnet publish -f:net6.0-android -c:Release GameSceneControl