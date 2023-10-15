namespace _6._5;

public partial class AddBookPage : ContentPage
{
	public AddBookPage()
	{
		InitializeComponent();
	}

    private void AddBook(object sender, EventArgs e)
    {
		int.TryParse(PriceEntry.Text, out int price);

        int.TryParse(PagesEntry.Text, out int pages);

        MainPage.ListOfBooks.Add(new Supply.Book(price, OriginEntry.Text, NameEntry.Text, PackingEntry.Text, 
            DescriptionEntry.Text, pages, PublishingHouseEntry.Text, WriterEntry.Text));
    }
}