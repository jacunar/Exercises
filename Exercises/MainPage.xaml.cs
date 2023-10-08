using CommunityToolkit.Maui.Views;

namespace Exercises; 
public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
        //DeviceDisplay.Current.KeepScreenOn = true;
    }

    async void OnShowVideoLibraryClicked(object sender, EventArgs e) {
        //try {
        //    Button button = sender as Button;
        //    button.IsEnabled = false;

        //    var pickedVideo = await MediaPicker.PickVideoAsync();
        //    if (!string.IsNullOrWhiteSpace(pickedVideo?.FileName)) {
        //        video.Source = MediaSource.FromFile(pickedVideo.FileName);
        //        video.Play();
        //    }

        //    button.IsEnabled = true;
        //} catch (Exception ex) {
        //    await DisplayAlert("Error", ex.Message, "Ok");
        //}        
    }

    public void ContentPage_Unloaded(object sender, EventArgs e) {
        video.Handler?.DisconnectHandler();
    }
}