using ChatX.Pages;

namespace ChatX;

public partial class HostPage : ContentPage
{
	public HostPage()
	{
		InitializeComponent();
	}
	public async void HostClick(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ChatPage());
    }
}