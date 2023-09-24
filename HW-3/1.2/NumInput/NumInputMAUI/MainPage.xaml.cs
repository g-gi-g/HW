namespace NumInputMAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            Label.Text = "Ви ввели число " + Entry.Text;

        }
    }
}