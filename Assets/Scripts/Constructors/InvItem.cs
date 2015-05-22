using UnityEngine;
using System.Collections;

[System.Serializable]

public class InvItem {

	public Item item;
	public int quantity;

	public InvItem(Item newItem, int newQuantity)
	{
		item = newItem;
		quantity = newQuantity;
	}

}
