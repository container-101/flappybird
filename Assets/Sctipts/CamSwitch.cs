using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

    public Camera myCamera;
    public Camera otherCamera;
    public AudioListener myAudioListender;
    public AudioListener otherAudioListender;

    public void Switch()
    {
        myCamera.enabled = !myCamera.enabled;
        otherCamera.enabled = !otherCamera.enabled;
        myAudioListender.enabled = !myAudioListender.enabled;
        otherAudioListender.enabled = !myAudioListender.enabled;
    }
}
