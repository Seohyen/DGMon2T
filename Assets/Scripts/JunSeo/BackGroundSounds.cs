using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundSounds : MonoBehaviour
{
    [SerializeField] Slider BGMvolume;
    [SerializeField] AudioSource audio;

    private float BGvol;

    private void Start()
    {
        BGvol = PlayerPrefs.GetFloat("BGvol", 1f);
        BGMvolume.value = BGvol;
        audio.volume = BGMvolume.value;
    }

    private void Update()
    {
        SoundSlider();
    }

    public void SoundSlider()
    {
        audio.volume = BGMvolume.value;
        BGvol = BGMvolume.value;
        PlayerPrefs.SetFloat("BGvol", BGvol);
    }

    
}
