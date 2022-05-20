using GameSceneControl;

namespace GameScenceControl;

public partial class App : Application {
    public App() {
        InitializeComponent();

        DataStorage.Initialize();
        MainPage = new AppShell();
    }
}
