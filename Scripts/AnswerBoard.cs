using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerBoard : MonoBehaviour {

	public bool isPressed;
	public GameObject answerBoardCanvas;


	// Update is called once per frame
	public void Update () {
		if (isPressed) {
			answerBoardCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			answerBoardCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			isPressed = !isPressed;
		}
	}
		
}
