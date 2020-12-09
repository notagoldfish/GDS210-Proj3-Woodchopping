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
    RadioMute muted;
    public int songID;

    [SerializeField] bool isPlaying;
    public bool togChange;
    [SerializeField] float timer = 1;

    private void Awake()
    {
        source = this.gameObject.GetComponent<AudioSource>();
        tC = GetComponentInChildren<TunerChanger>();
        rVolume = GetComponentInChildren<RadioVolume>();
        muted = GetComponentInChildren<RadioMute>();
    }

    private void Start()
    {
        isPlaying = true;
        togChange = true;
    }

    void Update()
    {
        songID = tC.SongID;

        if(isPlaying == true && togChange == true)
        {
            source.PlayOneShot(radioSongs[songID]);
            togChange = false;
            isPlaying = false;
        }

        if (isPlaying == false && togChange == true)
        {
            //AudioSource.Stop() is not working properly - Check at later date.
            source.Stop();
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(timer);
        isPlaying = true;
        Debug.Log("Wait for " + timer + " seconds");
    }
}
