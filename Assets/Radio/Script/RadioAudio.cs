using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class RadioAudio : MonoBehaviour
{
    public AudioClip[] radioSongs;
    AudioSource source;
    TunerChanger tC;
    RadioVolume rVolume;
    public int songID;

    private void Awake()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        tC = GetComponentInChildren<TunerChanger>();
        rVolume = GetComponentInChildren<RadioVolume>();
    }

    private void Start()
    {
        source.PlayOneShot(radioSongs[0]);
        source.volume = 1;
    }

    void Update()
    {
        songID = tC.SongID;
        source.clip = radioSongs[songID];
        source.PlayOneShot(radioSongs[songID]);
        source.volume = rVolume.songVolume;
    }
}
