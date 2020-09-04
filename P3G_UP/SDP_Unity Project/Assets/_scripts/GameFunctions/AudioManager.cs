using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip music;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.PlayOneShot(music);
        musicSource.PlayScheduled(AudioSettings.dspTime + music.length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
