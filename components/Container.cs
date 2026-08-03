using Godot;
using System;

public partial class Container : Control
{
	
}

/*
public enum BagType
{
	backpack,
	cardboard_box,
	crate
}

public partial class Container : Control
{
	private Button _template_ContainerSlot;
	private GridContainer _template_ContainerGrid;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}
	public Container(){}
	public Container(int x, int y, BagType bagType = BagType.backpack)
	{
		
	}
	
	private void OnButtonPress()
	{
		int x = 20;
		int y = 20;
		_template_ContainerSlot = GetNode<Button>("ContainerSlot");
		_template_ContainerGrid = GetNode<GridContainer>("ContainerGrid");

		_template_ContainerSlot.Visible = false;
		_template_ContainerGrid.Visible = false;
		
		GridContainer tempGrid = (GridContainer) _template_ContainerGrid.Duplicate();
		tempGrid.Columns = x;
		
		for (int i = 0; i < x; i++)
		{
			for (int j = 0; j < y; j++)
			{
				Button tempSlot = (Button) _template_ContainerSlot.Duplicate();
				tempSlot.Visible = true;
				tempGrid.AddChild(tempSlot);
			}
		}
		tempGrid.Visible = true;
		this.AddChild(tempGrid);
		
	}

}
*/