using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringController : MonoBehaviour {

    public int MAX_ROTATION = 20;
    public int ROTATION = 0;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        //Debug.Log (gameObject.transform.rotation.y);

        if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.RightArrow)) {
            if (ROTATION == 0) {
                //Debug.Log ("Wheel Stright");
            } else if (ROTATION < 0) {
                gameObject.transform.Rotate (0, 1, 0);
                ROTATION++;
            } else if (ROTATION > 0) {
                gameObject.transform.Rotate (0, -1, 0);
                ROTATION--;
            }
        } else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.JoystickButton2)) {
            //Debug.Log ("Left");
            if (ROTATION > -MAX_ROTATION) {
                gameObject.transform.Rotate (0, -1, 0);
                ROTATION--;
            }
        } else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.Joystick1Button1)) {
            //Debug.Log ("Right");
            if (ROTATION < MAX_ROTATION) {
                gameObject.transform.Rotate (0, 1, 0);
                ROTATION++;
            }
        } else {
            if (ROTATION == 0) {
                //Debug.Log ("Wheel Stright");
            } else if (ROTATION < 0) {
                gameObject.transform.Rotate (0, 1, 0);
                ROTATION++;
                //Debug.Log ("Wheel Left");
            } else if (ROTATION > 0) {
                gameObject.transform.Rotate (0, -1, 0);
                ROTATION--;
                //Debug.Log ("Wheel Right");
            }
        }
    }
}