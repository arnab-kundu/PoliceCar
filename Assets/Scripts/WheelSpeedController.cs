using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSpeedController : MonoBehaviour {
    // Start is called before the first frame update
    public double v = 0d;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.JoystickButton4)) {
            if (v <= 0) {
                v = v + 65 * Time.deltaTime;
                gameObject.transform.Rotate (0, 0, (int) v);
            } else {
                if (v < 20)
                    v = v + 15 * Time.deltaTime;
                gameObject.transform.Rotate (0, 0, (int) v);
            }
        } else if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.JoystickButton0)) {
            if (v >= 0) {
                v = v - 65 * Time.deltaTime;
                gameObject.transform.Rotate (0, 0, (int) v);
            } else {
                if (v > -5)
                    v = v - 15 * Time.deltaTime;
                gameObject.transform.Rotate (0, 0, (int) v);
            }
        }
    }
}