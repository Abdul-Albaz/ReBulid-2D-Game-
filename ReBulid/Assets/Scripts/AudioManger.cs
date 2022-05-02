using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManger : MonoBehaviour
{
    public Sound[] sounds;
    void Awake()
    {
        foreach(Sound s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
           s.source.pitch = s.pitch;
           s.source.volume = s.volume;
           s.source.loop = s.loop;
           s.source.playOnAwake = s.awake;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
       Sound s= Array.Find(sounds, Sound => Sound.name == name);
       s.source.Play();
    }

    public void stop(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        s.source.Pause();
    }
}
