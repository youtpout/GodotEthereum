using Godot;
using Nethereum.WalletConnect;
using System;
using WalletConnectSharp.Sign.Models;
using WalletConnectSharp.Sign;
using WalletConnectSharp.Sign.Models.Engine;
using WalletConnectSharp.Core;
using System.Threading.Tasks;

public class WalletConnectNode : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    public static async Task<ConnectedData> GetConnectData()
    {
        var options = new SignClientOptions()
        {
            ProjectId = "002243e654eae5271202b831393246d3",
            Metadata = new Metadata()
            {
                Description = "An example project to showcase WalletConnectSharpv2",
                Icons = new[] { "https://walletconnect.com/meta/favicon.ico" },
                Name = "WC Example",
                Url = "https://walletconnect.com"
            }
        };



        var client = await WalletConnectSignClient.Init(options);

        GD.Print("client", client.Name);
        var connectData = await client.Connect(NethereumWalletConnectService.GetDefaultConnectOptions());
        return connectData;
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
