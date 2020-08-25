using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveCar : MonoBehaviour {

	// Use this for initialization
	public float SPEED = 0.02f;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.JoystickButton4)) {
			gameObject.transform.Translate (-SPEED, 0, 0);
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.JoystickButton2)) {
				gameObject.transform.Rotate (0, -1, 0);
			} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.JoystickButton1)) {
				gameObject.transform.Rotate (0, 1, 0);
			}
		} else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.JoystickButton0)) {
			gameObject.transform.Translate (SPEED, 0, 0);
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.JoystickButton2)) {
				gameObject.transform.Rotate (0, 1, 0);
			} else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.JoystickButton1)) {
				gameObject.transform.Rotate (0, -1, 0);
			}
		}

	}
}