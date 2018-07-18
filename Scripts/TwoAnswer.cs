using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TwoAnswer : MonoBehaviour, IDropHandler {
	public bool rightAnswerOne = false; 
	public Answer answerScript;
	public bool rightAnswerTwo = false; 
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

			if (DragHandeler.itemBeingDragged.tag == "inter" && transform.tag == "AnswerTwo") {
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				ExecuteEvents.ExecuteHierarchy<IHasChanged> (gameObject, null, (x, y) => x.HasChanged ());
				rightAnswerOne = true; 
			}

			if (DragHandeler.itemBeingDragged.tag == "True" && transform.tag == "Answer") {
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				ExecuteEvents.ExecuteHierarchy<IHasChanged> (gameObject, null, (x, y) => x.HasChanged ());
				rightAnswerTwo = true; 
			}

		}
	}
	#endregion

	public bool FoundTwoAnswer(bool rightAnswerOne, bool rightAnswerTwo){
		if (rightAnswerOne == true && rightAnswerTwo == true) {
			return true;
		} else {
			return false;
		}
	}
}
