using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

	public GameObject[] pinventory = new GameObject[10];

	public void AddItem(GameObject treasure)
	{
		bool itemAdded = false;

		for (int i = 0; i < pinventory.Length; i++) {
			if (pinventory [i] == null) {
				pinventory [i] = treasure;
				Debug.Log (treasure.name + " was added");
				itemAdded = true;
				break;
			}
		}

		if (!itemAdded) {
			Debug.Log ("Inventory is full - item not added");
		}
	}

	public bool FindItem(GameObject Key){
		for (int i = 0; i < pinventory.Length; i++) {
			if (pinventory [i] = Key) {
				return true; 
			}
		}

		return false; 
	}
}
