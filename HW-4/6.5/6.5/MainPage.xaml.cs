using Supply;

namespace _6._5;

public partial class MainPage : ContentPage
{
    public static List<Food> ListOfFood;

    public static List<Book> ListOfBooks;

    public MainPage()
	{
		InitializeComponent();

        ListOfFood = new List<Food>();

        ListOfBooks = new List<Book>();
    }

	private async void OnAddBtnClicked(object evt, EventArgs e) 
	{
		await Navigation.PushAsync(new ChooseBookOrFoodPage());
	}

    private void RefreshGrid(object sender, EventArgs e)
    {
        Grid.RowDefinitions.Clear();
        Grid.ColumnDefinitions.Clear();

        foreach (var item in ListOfFood)
        {
            Grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            var nameLabel = new Label { Text = item.Name };
            var originLabel = new Label { Text = item.CountryOfOrigin };
            var priceLabel = new Label { Text = item.Price.ToString() };
            var packingLabel = new Label { Text = item.PackingDate };
            var descriptionLabel = new Label { Text = item.Description };
            var expireLabel = new Label { Text = item.ExpireDate };
            var amountLabel = new Label { Text = item.Amount.ToString() };
            var unitLabel = new Label { Text = item.Unit };


            Grid.Add(nameLabel, 0, Grid.RowDefinitions.Count - 1);
            Grid.Add(originLabel, 1, Grid.RowDefinitions.Count - 1);
            Grid.Add(priceLabel, 2, Grid.RowDefinitions.Count - 1);
            Grid.Add(packingLabel, 3, Grid.RowDefinitions.Count - 1);
            Grid.Add(descriptionLabel, 4, Grid.RowDefinitions.Count - 1);
            Grid.Add(expireLabel, 5, Grid.RowDefinitions.Count - 1);
            Grid.Add(amountLabel, 6, Grid.RowDefinitions.Count - 1);
            Grid.Add(unitLabel, 7, Grid.RowDefinitions.Count - 1);
        }
    }
}

