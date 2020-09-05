using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    //public AudioSource musicSource;
    //public AudioClip music;



    // Start is called before the first frame update
    void Awake()
    {
        // musicSource.PlayOneShot(music);
       // musicSource.PlayScheduled(AudioSettings.dspTime + music.length);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
}
