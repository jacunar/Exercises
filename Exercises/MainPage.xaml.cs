namespace Exercises; 
public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }

    public void ContentPage_Unloaded(object? sender, EventArgs e) {
        mediaElement.Handler?.DisconnectHandler();
    }
}