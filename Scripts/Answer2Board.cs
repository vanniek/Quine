using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer2Board : MonoBehaviour {

	public bool isPressed;
	public GameObject answer2BoardCanvas;


	// Update is called once per frame
	public void Update () {
		if (isPressed) {
			answer2BoardCanvas.SetActive (true);
			Time.timeScale = 0f;
		} else {
			answer2BoardCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			isPressed = !isPressed;
		}
	}

}
