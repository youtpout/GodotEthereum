using Godot;
using WalletConnectSharp.Sign.Models.Engine;

public class Menu : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public async override void _Ready()
    {

        object child = GetNode<TextureRect>("QrImage").Get("text");
        GD.Print("child txt " + child);


    }

    bool firstCall = true;

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if (firstCall)
        {
            firstCall = false;
            GetData();
        }
    }

    public async void GetData()
    {
        ConnectedData test = await WalletConnectNode.GetConnectData();

        GD.Print("data uri " + test.Uri);
    }
}
