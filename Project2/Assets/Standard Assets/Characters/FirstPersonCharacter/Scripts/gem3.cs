using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem3 : MonoBehaviour,IInventoryItem {
	public string Name
	{
		get{
			return "Gem3";
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
