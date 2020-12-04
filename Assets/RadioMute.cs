using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class RadioMute : MonoBehaviour
{
    private CircularDrive cD;
    private RadioVolume rV;
    private GameObject radio;

    [SerializeField] bool isMuted;

    private void Awake()
    {
        cD = this.gameObject.GetComponent<CircularDrive>();
        rV = GetComponentInParent<RadioVolume>();
        radio = GameObject.Find("Radio");
    }

    // Start is called before the first frame update
    void Start()
    {
        isMuted = false;
        cD.maxAngle = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMuted == true)
        {
            radio.GetComponent<AudioSource>().volume = 0;
        }
        else
        {
            radio.GetComponent<AudioSource>().volume = rV.songVolume;
        }
    }

    public void Muted()
    {
        isMuted = true;
    }

    public void UnMuted()
    {
        isMuted = false;
    }
}
