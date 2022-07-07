using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundSource;

    public AudioSource musicSource;

    public AudioSource effectSource;
    
    public void SetsoundVolume(float volume)
    {
        soundSource.volume = volume;
    }
    
    public void SetmusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SeteffectVolume(float volume)
    {
        effectSource.volume = volume;
    }
}
