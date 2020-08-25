using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start () {
        audioSource = GetComponent<AudioSource> ();
        AudioListener.pause = true;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.P) || Input.GetKey (KeyCode.JoystickButton5)) {
            //audioSource.PlayOneShot (audioSource.clip, 1.0f);
            AudioListener.pause = !AudioListener.pause;
        }
    }

    void someCode () {
        Camera staticCamera = GameObject.Find ("RearCamera").GetComponent<Camera> ();
        Destroy (staticCamera.GetComponent<AudioListener> ());
    }
}