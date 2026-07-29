using Godot;
using System;

public partial class InventoryGrid : GridContainer
{
	private int x_slots;
	private int y_slots;
	private GridContainer gridContainer;
	private Button inventorySlot;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//inventorySlot = GetNode<Button>("InventorySlot");
	}

	public InventoryGrid(int x, int y)
	{
		x_slots = x;
		y_slots = y;
		gridContainer = new GridContainer();
		gridContainer.Columns = x_slots;
		for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < y; j++)
			{
				this.AddChild(new InventorySlot());
			}
		}
	}



}
