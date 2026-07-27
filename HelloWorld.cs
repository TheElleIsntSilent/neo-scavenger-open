using Godot;
using System;

public partial class HelloWorld : Node2D
{
	private Label _label;
	private GameState _gameState;
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gameState = GetNode<GameState>("/root/GameState");
		_label = GetNode<Label>("Label");

		_gameState.HealthChanged += OnHealthChanged;
	}

	private void OnButtonPress_Plus()
	{
		int health = _gameState.GetHealth() + 10;
		_gameState.SetHealth(health);
	}

	private void OnButtonPress_Minus()
	{
		int health = _gameState.GetHealth() - 10;
		_gameState.SetHealth(health);
	}

	private void OnHealthChanged(int newHealth)
	{
		_label.Text = $"Health: {newHealth}";
	}	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
