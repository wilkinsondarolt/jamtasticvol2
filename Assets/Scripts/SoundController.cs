﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
    public AudioSource efxSource;
    public AudioSource musicSource;
    public static SoundController instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingle(AudioClip clip)
    {
        efxSource.clip = clip;
        efxSource.Play();
    }

    public void PlayLoop(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void EnableSounds()
    {
        efxSource.mute = false;
        musicSource.mute = false;
    }

    public void DisableSounds()
    {
        efxSource.Stop();
        efxSource.mute = false;

        musicSource.Stop();
        musicSource.mute = false;
    }
}
