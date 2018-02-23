using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour {
	private const int SLOTS = 9;
	private static List<IInventoryItem> mItems = new List<IInventoryItem> ();
	public static event EventHandler<InventoryEventArgs> ItemAdded;
	public static void Additem(IInventoryItem item)
	{
		if (mItems.Count < SLOTS) {
			Collider collider = (item as MonoBehaviour).GetComponent<Collider> ();
			if (collider.enabled) {
				collider.enabled = false;
				mItems.Add(item);
				item.OnPickup ();
			}
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
