using Godot;
using System;
using WalletConnectSharp.Sign.Models.Engine;

public class Menu : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public async override void _Ready()
    {
        ConnectedData test = await WalletConnectNode.GetConnectData();
        Node child = GetNode("QrImage");
        GD.Print("child exist" + child is null);
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
