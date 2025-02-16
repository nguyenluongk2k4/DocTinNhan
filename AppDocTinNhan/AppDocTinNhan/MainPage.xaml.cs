namespace AppDocTinNhan
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSpeakButtonClicked(object sender, EventArgs e)
        {
            await SpeakText("Xin chào! Đây là giọng đọc của .NET MAUI.");
        }

        private async Task SpeakText(string text)
        {
            // Lấy MainActivity từ Application Context
            var activity = Microsoft.Maui.ApplicationModel.Platform.CurrentActivity as MainActivity;
            activity?.AcquireWakeLock(); // Giữ máy hoạt động

            await TextToSpeech.Default.SpeakAsync(text);

            activity?.ReleaseWakeLock(); // Thả Wake Lock khi đọc xong
        }

    }

}
