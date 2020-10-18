using UnityEngine.Audio;
using System;
using UnityEngine;

public class MusicManager : MonoBehaviour

{
    public Sound[] soundh;


    void Awake()
    {
        foreach (Sound h in soundh)
        {
            h.source = gameObject.AddComponent<AudioSource>();

            h.source.clip = h.clip;

            h.source.volume = h.volume;
            h.source.pitch = h.pitch;
            h.source.loop = h.loop;

        }
    }
    void Start()
    {
        Play("FindMe");
        Play("theme");
    }


    public void Play(string name)
    {
        Sound h = Array.Find(soundh, sound => sound.name == name);
        h.source.Play();
    }
}
