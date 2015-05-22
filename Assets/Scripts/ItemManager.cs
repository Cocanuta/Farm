using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ItemDatabase")]
public class ItemManager : MonoBehaviour {
	[XmlArray("Items")]
	[XmlArrayItem("Item")]
	public List<Item> items = new List<Item>();

	void Start()
	{
		AddItem ("Hoe", "Used to till soil.", Item.itemType.Tool);
		AddItem ("Watering Can", "Used to water plants.", Item.itemType.Tool);
		AddItem ("Turnip Seeds", "Plant them to grow turnips.", Item.itemType.Seeds);
		AddItem ("Turnip", "A fully grown turnip.", Item.itemType.Crops);
		SaveItems ();
	}

	public void AddItem(string name, string description, Item.itemType type)
	{
		int id = 0;
		if(items.Count > 0)
		{
			foreach(Item i in items)
			{
				if(i.id >= id)
				{
					id = i.id + 1;
				}
			}
		}

		items.Add(new Item(id, name, description, type));
	}

	public Item GetItemFromID(int id)
	{
			foreach(Item i in items)
			{
				if(i.id == id)
				{
					return i;
				}
			}
			Debug.LogError ("No item found with ID \"" + id + "\".");
			return null;
	}

	public void SaveItems()
	{
		
		MyXML.SerializeToXML(items, Application.dataPath + "/Resources/XML/Items.xml");
	}
	public void LoadItems()
	{
		
		items = MyXML.DeserializeFromXML<Item>(Application.dataPath + "/Resources/XML/Items.xml");
		
	}
	
	
	
}
