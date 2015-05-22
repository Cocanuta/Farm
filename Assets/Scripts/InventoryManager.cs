using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour {

	public List<InvItem> inventory = new List<InvItem>();

	public void AddItem(Item item, int ammount)
	{
		foreach(InvItem i in inventory)
		{
			if(i.item == item)
			{
				i.quantity += ammount;
				return;
			}
		}
		inventory.Add (new InvItem (item, ammount));
	}
	
}
