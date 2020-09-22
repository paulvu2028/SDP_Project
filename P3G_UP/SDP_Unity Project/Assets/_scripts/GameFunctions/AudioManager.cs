using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    public AudioMixer audioMixer;

    // Start is called before the first frame update
    void Awake()
    {
        
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.outputAudioMixerGroup = s.mixerGroup;
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Theme");

        float music = PlayerPrefs.GetFloat("gameMusic", 0f);
        float sound = PlayerPrefs.GetFloat("gameSound", 0f);

        SetMusic(music);
        SetSound(sound);
    }


    // Update is called once per frame
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    public void Stop(String name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }

    public void SetMusic (float volume)
    {
        audioMixer.SetFloat("gameMusic", volume);
        PlayerPrefs.SetFloat("gameMusic", volume);
        PlayerPrefs.Save();
    }

    public void SetSound(float volume)
    {
        audioMixer.SetFloat("gameSound", volume);
        PlayerPrefs.SetFloat("gameSound", volume);
        PlayerPrefs.Save();

    }
}
