using Godot;
using System;


interface IQrCode
{
    public int error_correct_level { get; set; }
   
}

public class qr_view : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GDScript qrScript = (GDScript)GD.Load("res://addons/ethereum_node/qr_code.gd");
        object qrCode = qrScript.New(); // This is a GodotObject
       


    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
