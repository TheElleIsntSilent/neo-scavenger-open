using Godot;
using System;

public partial class GameState : Node
{
	
	private int _health;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_health = 100;
	}

	public int GetHealth()
	{
		return _health;
	}

	public void SetHealth(int newHealth)
	{
		_health = newHealth;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


}
