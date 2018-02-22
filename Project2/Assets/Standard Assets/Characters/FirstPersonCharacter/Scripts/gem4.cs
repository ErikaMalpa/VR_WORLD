using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem4 : MonoBehaviour,IInventoryItem {
	public string Name
	{
		get{
			return "Gem4";
		}
	}

	public Sprite _Image = null;
	public Sprite Image
	{
		get
		{ 
			return _Image;
		}
	}

	public void OnPickup()
	{
		//set object invisible when user collide with it
		gameObject.SetActive (false);
	}
}
