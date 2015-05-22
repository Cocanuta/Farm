using UnityEngine;
using System.Collections;

public class EquipmentManager : MonoBehaviour {

	public Item equipedItem = null;
	public ItemManager itemManager;

	// Use this for initialization
	void Start () {
		itemManager = GameObject.Find ("GameManager").GetComponent<ItemManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EquipItem(Item item)
	{
		equipedItem = item;
		Mesh equipmentMesh = null;
		this.GetComponent<MeshFilter> ().mesh = equipmentMesh;
		this.GetComponent<MeshRenderer> ().enabled = true;
	}

	public void UnequipItem()
	{
		equipedItem = null;
		this.GetComponent<MeshRenderer> ().enabled = false;
		this.GetComponent<MeshFilter> ().mesh = null;
	}
}
