namespace ChatX;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	public async void JoinButtonClick(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new JoinPage());
	}
	public async void HostButtonClick(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new HostPage());
	}
}

