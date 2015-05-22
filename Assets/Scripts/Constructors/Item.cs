using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

[System.Serializable]

public class Item {
	[XmlAttribute("id")]
	public int id;
	[XmlAttribute("name")]
	public string name;
	[XmlAttribute("description")]
	public string description;
	[XmlAttribute("type")]
	public itemType type;

	
	public enum itemType{Tool, Seeds, Crops, Food, Fish, Bug, Flower};

	public Item(int newId, string newName, string newDescription, itemType newType)
	{
		id = newId;
		name = newName;
		description = newDescription;
		type = newType;
	}

	public Item()
	{

	}

}
