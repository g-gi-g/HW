using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Supply;
using static System.Net.Mime.MediaTypeNames;

namespace _6._5;

public partial class MainPage : ContentPage
{
    public static int NumberOfBooks { get; set; } = 0;

    public static int NumberOfFoods { get; set; } = 0;

    private int numberOfParameters = 9;

    public MainPage()
    {
        InitializeComponent();

        MessagingCenter.Subscribe<AddPage, Supply.Food>(this, "AddFood", async (sender, arg) =>
        {
            AddFoodToGrid(arg);
        });

        MessagingCenter.Subscribe<AddPage, Supply.Book>(this, "AddBook", async (sender, arg) =>
        {
            AddBookToGrid(arg);
        });

        MessagingCenter.Subscribe<DeletePage, int>(this, "DeleteFood", async(sender, arg) => 
        {
            DeleteFoodFromGrid(arg);
        });

        MessagingCenter.Subscribe<DeletePage, int>(this, "DeleteBook", async (sender, arg) =>
        {
            DeleteBookFromGrid(arg);
        });

        FoodGrid.Add(new Label { Text = "Номер" }, 0, 0);

        FoodGrid.Add(new Label { Text = "Назва" }, 1, 0);

        FoodGrid.Add(new Label { Text = "Походження" }, 2, 0);

        FoodGrid.Add(new Label { Text = "Ціна" }, 3, 0);

        FoodGrid.Add(new Label { Text = "Дата пакування" }, 4, 0);

        FoodGrid.Add(new Label { Text = "Опис" }, 5, 0);

        FoodGrid.Add(new Label { Text = "Строк придатності" }, 6, 0);

        FoodGrid.Add(new Label { Text = "Кількість" }, 7, 0);

        FoodGrid.Add(new Label { Text = "Одиниця виміру" }, 8, 0);

        BookGrid.Add(new Label { Text = "Номер" }, 0, 0);

        BookGrid.Add(new Label { Text = "Назва" }, 1, 0);

        BookGrid.Add(new Label { Text = "Походження" }, 2, 0);

        BookGrid.Add(new Label { Text = "Ціна" }, 3, 0);

        BookGrid.Add(new Label { Text = "Дата пакування" }, 4, 0);

        BookGrid.Add(new Label { Text = "Опис" }, 5, 0);

        BookGrid.Add(new Label { Text = "Кількість сторінок" }, 6, 0);

        BookGrid.Add(new Label { Text = "Видавництво" }, 7, 0);

        BookGrid.Add(new Label { Text = "Автори" }, 8, 0);
    }

    private async void OnAddBtnClicked(object evt, EventArgs e)
    {
        await Navigation.PushAsync(new AddPage());
    }

    private async void OnDeleteBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeletePage());
    }

    private void AddFoodToGrid(Food food)
    {
        NumberOfFoods++;

        FoodGrid.AddRowDefinition(new RowDefinition { Height = GridLength.Auto });

        FoodGrid.Add(new Label
        {
            Text = (NumberOfFoods).ToString()
        }, 0, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.Name
        }, 1, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.CountryOfOrigin
        }, 2, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.Price.ToString()
        }, 3, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.PackingDate
        }, 4, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.Description
        }, 5, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.ExpireDate
        }, 6, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.Amount.ToString()
        }, 7, NumberOfFoods);

        FoodGrid.Add(new Label
        {
            Text = food.Unit
        }, 8, NumberOfFoods);
    }

    private void AddBookToGrid(Book book)
    {
        NumberOfBooks++;

        FoodGrid.AddRowDefinition(new RowDefinition { Height = GridLength.Auto });

        BookGrid.Add(new Label
        {
            Text = (NumberOfBooks).ToString()
        }, 0, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.Name
        }, 1, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.CountryOfOrigin
        }, 2, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.Price.ToString()
        }, 3, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.PackingDate
        }, 4, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.Description
        }, 5, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.NumberOfPages.ToString()
        }, 6, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.PublishingHouse
        }, 7, NumberOfBooks);

        BookGrid.Add(new Label
        {
            Text = book.Writers
        }, 8, NumberOfBooks);
    }

    private void DeleteFoodFromGrid(int index) 
    {
        for (int i = numberOfParameters * index; i < FoodGrid.Children.Count - numberOfParameters; i++) 
        { 
            var upperLabelChild = FoodGrid.Children[i];

            if (FoodGrid.GetColumn(upperLabelChild) == 0 
                || FoodGrid.GetRow(upperLabelChild) == 0) 
            {
                continue;
            }
            
            var lowerLabelChild = FoodGrid.Children[i + numberOfParameters];

            Label upperLabel = (Label)upperLabelChild;

            Label lowerLabel = (Label)lowerLabelChild;

            upperLabel.Text = lowerLabel.Text;
        }

        foreach (var child in FoodGrid.Children.ToList())
        {
            if (FoodGrid.GetRow(child) == NumberOfFoods)
            {
                FoodGrid.Children.Remove(child);
            }
        }

        NumberOfFoods--;
    }

    private void DeleteBookFromGrid(int index)
    {
        for (int i = numberOfParameters * index; i < BookGrid.Children.Count - numberOfParameters; i++)
        {
            var upperLabelChild = BookGrid.Children[i];

            if (BookGrid.GetColumn(upperLabelChild) == 0
                || BookGrid.GetRow(upperLabelChild) == 0)
            {
                continue;
            }

            var lowerLabelChild = BookGrid.Children[i + numberOfParameters];

            Label upperLabel = (Label)upperLabelChild;

            Label lowerLabel = (Label)lowerLabelChild;

            upperLabel.Text = lowerLabel.Text;
        }

        foreach(var child in BookGrid.Children.ToList())
        {
            if (BookGrid.GetRow(child) == NumberOfBooks)
            {
                BookGrid.Children.Remove(child);
            }  
        }

        NumberOfBooks--;
    }
}