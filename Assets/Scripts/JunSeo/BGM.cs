using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM : MonoBehaviour
{
    [Header("음량")]
    [SerializeField] AudioSource soundVolume;

    [Header("음악")]
    [SerializeField] AudioSource music;

    [Header("효과음")]
    [SerializeField] AudioSource soundEffect;

    public void SetMusicVolume(float volume)
    {
        music.volume = volume;
    }
}
