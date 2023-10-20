namespace _6._5;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();

        AddBookRadioBtn.CheckedChanged += (sender, e) =>
        {
            ExpireEntry.IsVisible = false;
            ExpireLabel.IsVisible = false;

            AmountEntry.IsVisible = false;
            AmountLabel.IsVisible = false;

            UnitEntry.IsVisible = false;
            UnitLabel.IsVisible = false;

            PagesEntry.IsVisible = true;
            PagesLabel.IsVisible = true;

            PublishingHouseEntry.IsVisible = true;
            PublishingHouseLabel.IsVisible = true;

            WriterEntry.IsVisible = true;
            WriterLabel.IsVisible = true;
        };

        AddFoodRadioBtn.CheckedChanged += (sender, e) =>
        {
            ExpireEntry.IsVisible = true;
            ExpireLabel.IsVisible = true;

            AmountEntry.IsVisible = true;
            AmountLabel.IsVisible = true;

            UnitEntry.IsVisible = true;
            UnitLabel.IsVisible = true;

            PagesEntry.IsVisible = false;
            PagesLabel.IsVisible = false;

            PublishingHouseEntry.IsVisible = false;
            PublishingHouseLabel.IsVisible = false;

            WriterEntry.IsVisible = false;
            WriterLabel.IsVisible = false;
        };
    }

    private void ChooseMethod(object sender, EventArgs e) 
    {
        if (AddFoodRadioBtn.IsChecked == true)
        {
            AddFood(sender, e);
        }

        else 
        {
            AddBook(sender, e);
        }
    }

    private async void AddFood(object sender, EventArgs e)
    {
        if (!int.TryParse(PriceEntry.Text, out int price))
        {
            await DisplayAlert("Повідомлення",
                "Ви ввели невірну ціну",
                "ОК");
            return;
        }

        if (!int.TryParse(AmountEntry.Text, out int amount))
        {
            await DisplayAlert("Повідомлення",
                "Ви ввели невірну кількість",
                "ОК");
            return;
        }

        MessagingCenter.Send<AddPage, Supply.Food>(this, "AddFood", 
            new Supply.Food(price, OriginEntry.Text, NameEntry.Text, PackingEntry.Text,
            DescriptionEntry.Text, ExpireEntry.Text, amount, UnitEntry.Text));

        await Navigation.PopAsync();
    }

    private async void AddBook(object sender, EventArgs e)
    {
        if (!int.TryParse(PriceEntry.Text, out int price))
        {
            await DisplayAlert("Повідомлення",
                "Ви ввели невірну ціну",
                "ОК");
            return;
        }

        if (!int.TryParse(PagesEntry.Text, out int pages)) 
        {
            await DisplayAlert("Повідомлення",
                "Ви ввели невірну кількість сторінок",
                "ОК");
            return;
        }

        MessagingCenter.Send<AddPage, Supply.Book>(this, "AddBook", 
            new Supply.Book(price, OriginEntry.Text, NameEntry.Text, PackingEntry.Text,
            DescriptionEntry.Text, pages, PublishingHouseEntry.Text, WriterEntry.Text));


        await Navigation.PopAsync();
    }
}