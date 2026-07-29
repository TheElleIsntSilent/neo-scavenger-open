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
	private Button _template_InventorySlot;
	private GridContainer _template_InventoryGrid;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}
	public Inventory(){}
	public Inventory(int x, int y, BagType bagType = BagType.backpack)
	{
		
	}
	
	private void OnButtonPress()
	{
		int x = 20;
		int y = 20;
		_template_InventorySlot = GetNode<Button>("InventorySlot");
		_template_InventoryGrid = GetNode<GridContainer>("InventoryGrid");

		_template_InventorySlot.Visible = false;
		_template_InventoryGrid.Visible = false;
		
		GridContainer tempGrid = (GridContainer) _template_InventoryGrid.Duplicate();
		tempGrid.Columns = x;
		
		for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < y; j++)
			{
				Button tempSlot = (Button) _template_InventorySlot.Duplicate();
				tempSlot.Visible = true;
				tempGrid.AddChild(tempSlot);
			}
		}
		tempGrid.Visible = true;
		this.AddChild(tempGrid);
		
	}

}
/*
public partial class InventoryGrid : GridContainer
{
	private int x_slots;
	private int y_slots;
	private InventoryGrid _invGridContainer;
	private InventorySlot _inventorySlot;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_inventorySlot = GetNode<InventorySlot>("%InventorySlot");
		_inventorySlot.Visible = false;
		_invGridContainer = GetNode<InventoryGrid>("%InventoryGrid");
		_invGridContainer.Visible = false;
	}
	public InventoryGrid(){}
	public InventoryGrid(int x, int y)
	{
		x_slots = x;
		y_slots = y;
		//InventoryGrid tempContainer = (InventoryGrid) _invGridContainer.Duplicate();
		this.Columns = x_slots;
		for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < y; j++)
			{
				InventorySlot tempslot = (InventorySlot) _inventorySlot.Duplicate();
				this.AddChild(tempslot);
				tempslot.Visible = true;
			}
		}
		this.Visible = true;

	}



}
*/