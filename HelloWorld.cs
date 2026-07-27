using Godot;
using System;

public partial class HelloWorld : Node2D
{
	private GameState _gameState;
	private VBoxContainer _vBoxContainer;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gameState = GetNode<GameState>("/root/GameState");
		_vBoxContainer = GetNode<VBoxContainer>("VBoxContainer");

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
		Label label = new Label();
		_vBoxContainer.AddChild(label);
		label.Text = $"Health: {newHealth}";
	}	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
