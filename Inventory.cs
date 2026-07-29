using Godot;
using System;

public enum BagType
{
	backpack,
	cardboard_box,
	crate
}

public partial class Inventory : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.AddChild(new InventoryGrid(2, 2));
	}

	public Inventory(int x, int y, BagType bagType = BagType.backpack)
	{
		
	}
	
}
