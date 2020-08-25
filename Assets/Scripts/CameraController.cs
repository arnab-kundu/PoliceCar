using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject rearCamera, leftCamera, frontCamera, rightCamera;
    public int count = 0;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown (KeyCode.C) || Input.GetKeyDown (KeyCode.JoystickButton6)) {
            if (count >= 3) {
                count = 0;
            } else {
                count++;
            }
            switch (count) {
                case 0:
                    rearCamera.SetActive (true);
                    leftCamera.SetActive (false);
                    frontCamera.SetActive (false);
                    rightCamera.SetActive (false);
                    break;
                case 1:
                    leftCamera.SetActive (true);
                    rearCamera.SetActive (false);
                    frontCamera.SetActive (false);
                    rightCamera.SetActive (false);
                    break;
                case 2:
                    frontCamera.SetActive (true);
                    rearCamera.SetActive (false);
                    leftCamera.SetActive (false);
                    rightCamera.SetActive (false);
                    break;
                case 3:
                    rightCamera.SetActive (true);
                    rearCamera.SetActive (false);
                    leftCamera.SetActive (false);
                    frontCamera.SetActive (false);
                    break;
                default:
                    break;
            }
        }

    }
}