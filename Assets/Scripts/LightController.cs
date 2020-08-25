using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {

    public GameObject leftIndicator, rightIndicator, headLights, rearLights, onDutyLights, onDutyRedLight,
    onDutyBlueLight, backGearLight;
    double timeOffsetForIndicator, timeOffsetForOnDutyLights;
    int indicatorTimeSpanFactor = 300;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        //Debug.Log (Time.time * 1000);
        if ((Input.GetKey (KeyCode.LeftArrow) && Input.GetKey (KeyCode.RightArrow)) ||
            (Input.GetKey (KeyCode.JoystickButton2) && Input.GetKey (KeyCode.JoystickButton1))) {
            if (Time.time * 1000 > timeOffsetForIndicator) {
                leftIndicator.SetActive (!leftIndicator.activeSelf);
                rightIndicator.SetActive (!rightIndicator.activeSelf);
                timeOffsetForIndicator = Time.time * 1000 + indicatorTimeSpanFactor;
            }
        } else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.JoystickButton2)) {
            if (Time.time * 1000 > timeOffsetForIndicator) {
                leftIndicator.SetActive (!leftIndicator.activeSelf);
                timeOffsetForIndicator = Time.time * 1000 + indicatorTimeSpanFactor;
            }
        } else if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.Joystick1Button1)) {
            if (Time.time * 1000 > timeOffsetForIndicator) {
                rightIndicator.SetActive (!rightIndicator.activeSelf);
                timeOffsetForIndicator = Time.time * 1000 + indicatorTimeSpanFactor;
            }
        } else if (!onDutyLights.activeSelf) {
            leftIndicator.SetActive (false);
            rightIndicator.SetActive (false);
            timeOffsetForIndicator = 0;
        }
        if (Input.GetKeyDown (KeyCode.L) || Input.GetKeyDown (KeyCode.JoystickButton5)) {
            headLights.SetActive (!headLights.activeSelf);
            rearLights.SetActive (headLights.activeSelf);
        }
        if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.JoystickButton0)) {
            backGearLight.SetActive (true);
            backGearLight.SetActive (true);
        } else {
            backGearLight.SetActive (false);
            backGearLight.SetActive (false);
        }

        if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.P) || Input.GetKeyDown (KeyCode.JoystickButton5)) {
            onDutyLights.SetActive (!onDutyLights.activeSelf);

            //leftIndicator.SetActive (true);
        }

        //Sequence 1
        if (true) {
            if (Time.time * 1000 > timeOffsetForOnDutyLights) {
                timeOffsetForOnDutyLights = Time.time * 1000 + 300;

                onDutyBlueLight.SetActive (onDutyRedLight.activeSelf);
                onDutyRedLight.SetActive (!onDutyRedLight.activeSelf);

                // Indicator blinking on OnDutyMode
                if (onDutyLights.activeSelf) {
                    leftIndicator.SetActive (rightIndicator.activeSelf);
                    rightIndicator.SetActive (!rightIndicator.activeSelf);
                }
            }

        }
    }
}