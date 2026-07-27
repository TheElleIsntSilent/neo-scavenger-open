using Godot;
using System;

public partial class HelloWorld : Node2D
{
	private Label _label;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_label = GetNode<Label>("Label");
	}

	private void OnButtonPressed()
	{
		_label.Text = "You clicked it 1!";
	}
	private void OnButtonPressed3()
	{
		_label.Text = "You clicked it again!";
	}

	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
