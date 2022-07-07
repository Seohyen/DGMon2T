using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM : MonoBehaviour
{
    [Header("����")]
    [SerializeField] AudioSource soundVolume;

    [Header("����")]
    [SerializeField] AudioSource music;

    [Header("ȿ����")]
    [SerializeField] AudioSource soundEffect;

    public void SetMusicVolume(float volume)
    {
        music.volume = volume;
    }
}
