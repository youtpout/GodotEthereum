using Godot;
using System;

public interface IQRGenerator
{
    public int correct_level { get; set; }
    public string text { get; set; }
}
