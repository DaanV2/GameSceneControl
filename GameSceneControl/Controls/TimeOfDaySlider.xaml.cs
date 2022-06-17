namespace GameSceneControl.Controls;

public partial class TimeOfDaySlider : ContentView {
    private TimeOfDayValue timeOfDay;

    public event EventHandler<ValueChangedEventArgs> ValueChanged;
    public event EventHandler DragCompleted;
    public event EventHandler DragStarted;

    public TimeOfDayValue TimeOfDay {
        get => this.timeOfDay;
        set {
            this.timeOfDay = value;
            this.timeSlider.Value = this.timeOfDay.Value;
        }
    }

    public TimeOfDaySlider() {

        this.InitializeComponent();

        this.TimeOfDay = new TimeOfDayValue();
        this.timeSlider.DragCompleted += this.TimeSlider_DragCompleted;
        this.timeSlider.DragStarted += this.TimeSlider_DragStarted;
        this.timeSlider.ValueChanged += this.TimeSlider_ValueChanged;
    }

    private void TimeSlider_ValueChanged(Object sender, ValueChangedEventArgs e) {
        this.ValueChanged?.Invoke(sender, e);
    }

    private void TimeSlider_DragStarted(Object sender, EventArgs e) {
        this.DragStarted?.Invoke(sender, e);
    }

    private void TimeSlider_DragCompleted(Object sender, EventArgs e) {
        this.TimeOfDay.Value = this.timeSlider.Value;
        this.DragCompleted?.Invoke(this, e);
    }
}