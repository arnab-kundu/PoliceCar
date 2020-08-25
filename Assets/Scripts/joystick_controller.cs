using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 //Joystick
        if (Input.GetKey (KeyCode.Joystick1Button0)) {
            Debug.Log ("Joystick A");
        } else if (Input.GetKey (KeyCode.Joystick1Button1)) {
            Debug.Log ("Joystick B");
        } else if (Input.GetKey (KeyCode.JoystickButton2)) {
            Debug.Log ("Joystick X");
        } else if (Input.GetKey (KeyCode.JoystickButton3)) {
            Debug.Log ("Joystick Y");
        } else if (Input.GetKey (KeyCode.JoystickButton4)) {
            Debug.Log ("Joystick LB");
        } else if (Input.GetKey (KeyCode.JoystickButton5)) {
            Debug.Log ("Joystick RB");
        } else if (Input.GetKey (KeyCode.JoystickButton6)) {
            Debug.Log ("Joystick SELECT");
        } else if (Input.GetKey (KeyCode.JoystickButton7)) {
            Debug.Log ("Joystick START");
        } else if (Input.GetKey (KeyCode.JoystickButton8)) {
            Debug.Log ("Joystick Left");
        } else if (Input.GetKey (KeyCode.JoystickButton9)) {
            Debug.Log ("Joystick Right");
        } else if (Input.GetKey (KeyCode.JoystickButton10)) {
            Debug.Log ("Joystick JoystickButton10");
        } else if (Input.GetKey (KeyCode.JoystickButton11)) {
            Debug.Log ("Joystick JoystickButton11");
        } else if (Input.GetKey (KeyCode.JoystickButton12)) {
            Debug.Log ("Joystick JoystickButton12");
        } else if (Input.GetKey (KeyCode.JoystickButton13)) {
            Debug.Log ("Joystick JoystickButton13");
        } else if (Input.GetKey (KeyCode.JoystickButton14)) {
            Debug.Log ("Joystick JoystickButton14");
        } else if (Input.GetKey (KeyCode.JoystickButton15)) {
            Debug.Log ("Joystick JoystickButton15");
        } else if (Input.GetKey (KeyCode.JoystickButton16)) {
            Debug.Log ("Joystick JoystickButton16");
        } else if (Input.GetKey (KeyCode.JoystickButton17)) {
            Debug.Log ("Joystick JoystickButton17");
        } else if (Input.GetKey (KeyCode.JoystickButton18)) {
            Debug.Log ("Joystick JoystickButton18");
        } else if (Input.GetKey (KeyCode.JoystickButton19)) {
            Debug.Log ("Joystick JoystickButton19");
        }

        
        /*   if (Input.GetAxis ("HorizontalDPAD") > 0) {
              Debug.Log ("MoveRight ()");
          } else if (Input.GetAxis ("HorizontalDPAD") < 0) {
              Debug.Log ("MoveLeft ()");
          } */
    }
}
