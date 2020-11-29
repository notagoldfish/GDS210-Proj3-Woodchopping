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
    InteractableHoverEvents iHE;
    public int songID;

    private void Awake()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        tC = GetComponentInChildren<TunerChanger>();
        rVolume = GetComponentInChildren<RadioVolume>();
        iHE = GetComponentInChildren<InteractableHoverEvents>();
    }

    private void Start()
    {
        source.PlayOneShot(radioSongs[0]);
        source.volume = 1f;
    }

    void Update()
    {
        songID = tC.SongID;
        source.clip = radioSongs[songID];
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.Stop();
            source.PlayOneShot(radioSongs[songID]);
            Debug.Log(radioSongs[songID]);
        }

        source.volume = rVolume.songVolume;
    }

    public void Mute()
    {
        if(source.volume != 0)
        {
            source.volume = rVolume.songVolume;
        }
        else
        {
            source.volume = 0;
        }
    }
}
