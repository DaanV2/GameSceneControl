using GameSceneControl;

namespace GameSceneControl.Controls;

public partial class TimeOfDaySlider : ContentView {
    public event EventHandler<ValueChangedEventArgs> ValueChanged;
    public event EventHandler DragCompleted;
    public event EventHandler DragStarted;

    public TimeOfDayValue TimeOfDay { get; set; }

    public TimeOfDaySlider() {
        InitializeComponent();

        this.timeSlider.DragCompleted += TimeSlider_DragCompleted;
        this.timeSlider.DragStarted += TimeSlider_DragStarted;
        this.timeSlider.ValueChanged += TimeSlider_ValueChanged;
    }

    private void TimeSlider_ValueChanged(object sender, ValueChangedEventArgs e) {
        this.ValueChanged?.Invoke(sender, e);
    }

    private void TimeSlider_DragStarted(object sender, EventArgs e) {
        this.DragStarted?.Invoke(sender, e);
    }

    private void TimeSlider_DragCompleted(object sender, EventArgs e) {
        this.TimeOfDay.Value = this.timeSlider.Value;
        this.DragCompleted?.Invoke(this, e);
    }
}