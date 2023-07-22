namespace ChatX.Pages;

public partial class ChatPage : ContentPage
{
	public ChatPage()
	{
		InitializeComponent();
		CodeGenerate();

    }
	public void CodeGenerate()
	{
		int code;
		Random random = new Random();
		code = random.Next(1000, 100000);
		codeLabel.Text = $"Code: {code}";

    }
	public void sendButton(object sender, EventArgs e)
	{
		string message = messagetext.Text;
	}

}