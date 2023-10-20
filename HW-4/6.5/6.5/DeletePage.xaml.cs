namespace _6._5;

public partial class DeletePage : ContentPage
{
	public DeletePage()
	{
		InitializeComponent();
	}

    private async void OnDeleteBtnClicked(object sender, EventArgs e)
    {
        if (!int.TryParse(IndexEntry.Text, out int index))
        {
            await DisplayAlert("�����������",
                "�� ����� ������� ������",
                "��");
            return;
        }

        if (DeleteBookRadioBtn.IsChecked)
        {
            if (index <= 0 || index > MainPage.NumberOfBooks)
            {
                await DisplayAlert("�����������",
                "�� ����� ������� ������",
                "��");
            }

            else
            {
                MessagingCenter.Send<DeletePage, int>(this, "DeleteBook", index);

                await Navigation.PopAsync();
            }
        }

        else
        {
            if (index <= 0 || index > MainPage.NumberOfFoods)
            {
                await DisplayAlert("�����������",
                "�� ����� ������� ������",
                "��");
            }

            else
            {
                MessagingCenter.Send<DeletePage, int>(this, "DeleteFood", index);

                await Navigation.PopAsync();
            }
        }
    }
}