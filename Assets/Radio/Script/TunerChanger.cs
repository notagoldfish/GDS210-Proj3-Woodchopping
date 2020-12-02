using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class TunerChanger : MonoBehaviour
{
    private RadioAudio rA;
    private CircularDrive cD;
    
    public int SongID = 0;

    // Start is called before the first frame update
    void Start()
    {
        rA = GetComponentInParent<RadioAudio>();
        cD = this.gameObject.GetComponent<CircularDrive>();

        cD.maxAngle = rA.radioSongs.Length * 10 - 10;
    }

    // Update is called once per frame
    void Update()
    {
        SongID = (int)cD.outAngle;
        SongID = SongID / 10;
    }
}
