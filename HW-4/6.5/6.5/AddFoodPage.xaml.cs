namespace _6._5;

public partial class AddFoodPage : ContentPage
{
	public AddFoodPage()
	{
		InitializeComponent();
	}

    private void AddFood(object sender, EventArgs e)
    {
        int.TryParse(PriceEntry.Text, out int price);

        int.TryParse(AmountEntry.Text, out int amount);

        MainPage.ListOfFood.Add(new Supply.Food(price, OriginEntry.Text, NameEntry.Text, PackingEntry.Text,
            DescriptionEntry.Text, ExpireEntry.Text, amount, UnitEntry.Text));
    }
}