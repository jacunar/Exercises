namespace Exercises; 
public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
        //DeviceDisplay.Current.KeepScreenOn = true;
    }

    public void ContentPage_Unloaded(object? sender, EventArgs e) {
        mediaElement.Handler?.DisconnectHandler();
    }
}