using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem1 : MonoBehaviour,IInventoryItem {
	public string Name
	{
		get{
			return "Gem1";
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
		gameObject.SetActive (false);
	}
}
