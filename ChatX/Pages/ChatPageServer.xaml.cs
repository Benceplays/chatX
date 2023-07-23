using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatX.Pages;

public partial class ChatPageServer : ContentPage
{
    public int code;
    public ChatPageServer()
    {
        InitializeComponent();
        CodeGenerate();
    }
    public void CodeGenerate()
    {
        Random random = new Random();
        code = random.Next(1000, 100000);
        codeLabel.Text = $"Code: {code}";
    }
    public void sendButton(object sender, EventArgs e)
    {
        string message = messagetext.Text;
    }

}