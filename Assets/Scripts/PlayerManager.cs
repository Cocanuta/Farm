using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public ItemManager itemManager;
	public InventoryManager invManager;

	public bool inventoryScreen = false;
	private Vector2 scrollPosition;


	// Use this for initialization
	void Start () {

		itemManager = GameObject.Find ("GameManager").GetComponent<ItemManager> ();
		invManager = this.GetComponent<InventoryManager> ();

		invManager.AddItem (itemManager.items [0], 1);
		invManager.AddItem (itemManager.items [1], 1);
		invManager.AddItem (itemManager.items [2], 1);
		invManager.AddItem (itemManager.items [3], 2);
		invManager.AddItem (itemManager.items [1], 1);
		invManager.AddItem (itemManager.items [3], 5);
		invManager.AddItem (itemManager.items [3], 4);
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

}
