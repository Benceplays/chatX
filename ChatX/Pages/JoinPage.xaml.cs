using ChatX.Pages;
using System.Net.Sockets;

namespace ChatX;

public partial class JoinPage : ContentPage
{
    NetworkStream serverStream = default(NetworkStream);
    public JoinPage()
	{
		InitializeComponent();
	}
	public async void JoinButton(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new ChatPageClient());
	}
}