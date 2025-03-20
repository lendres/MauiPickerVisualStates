namespace PickerTextColor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			MonkeyPicker1.SelectedIndex = 1;
			MonkeyPicker2.SelectedIndex = 1;
        }

		private void OnNavigateForward(object sender, EventArgs e)
		{
			Shell.Current.GoToAsync(nameof(SecondPage), true, new Dictionary<string, object> { });
		}
    }
}