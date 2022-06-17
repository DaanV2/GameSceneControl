using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GameSceneControl.Classes.BaseViewModel {
    ///DOLATER <summary>add description for class: BaseViewModel</summary>
    public partial class BaseViewModel : INotifyPropertyChanged {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String name = null) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
