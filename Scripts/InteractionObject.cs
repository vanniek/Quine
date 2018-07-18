using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour {

	public bool pinventory; 
	public bool openable; 
	public bool locked; 
	public GameObject itemNeeded;

	public void DoInteraction()
	{
		gameObject.SetActive (false);
	}
}
