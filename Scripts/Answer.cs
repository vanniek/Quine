using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Answer : MonoBehaviour, IDropHandler {
	public bool rightAnswer = false; 

	public GameObject item {
		get {
			if(transform.childCount>0){
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		if(!item){
			
			if (DragHandeler.itemBeingDragged.tag == "True") {
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				ExecuteEvents.ExecuteHierarchy<IHasChanged> (gameObject, null, (x, y) => x.HasChanged ());
				rightAnswer = true; 
				Debug.Log ("@@!");
			}

		}
	}
	#endregion

	public bool FoundAnswer(bool rightAnswer){
		if (rightAnswer == true) {
			return true; 
		} else {
			return false; 
		}
	}
}
