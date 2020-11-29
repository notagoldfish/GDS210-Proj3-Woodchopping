using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class RadioVolume : MonoBehaviour
{
    private CircularDrive cD;
    private RadioAudio rA;

    public float songVolume = 100f;

    // Start is called before the first frame update
    void Start()
    {
        cD = this.gameObject.GetComponent<CircularDrive>();
        rA = GetComponentInParent<RadioAudio>();

        cD.maxAngle = GetComponentInParent<AudioSource>().volume * 100f;
    }

    // Update is called once per frame
    void Update()
    {
        songVolume = cD.outAngle;
        songVolume = songVolume / 100;
    }
}
