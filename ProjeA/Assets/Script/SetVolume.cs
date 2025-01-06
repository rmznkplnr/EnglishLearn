using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource audioSource;

    void Start()
    {
        // Slider'ýn baþlangýç deðerini audioSource'un þu anki volume deðeri ile ayarla
        volumeSlider.value = audioSource.volume;
    }

    public void SettVolume()
    {
        // Slider'dan gelen deðeri audioSource'a ata
        audioSource.volume = volumeSlider.value;
    }
}
