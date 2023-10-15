namespace _6._5;

public partial class ChooseBookOrFoodPage : ContentPage
{
	public ChooseBookOrFoodPage()
	{
		InitializeComponent();
	}

    private async void OnBookAddBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddBookPage());
    }

    private async void OnFoodAddBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddFoodPage());
    }
}