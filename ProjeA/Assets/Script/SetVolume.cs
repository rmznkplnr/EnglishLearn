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
        // Slider'�n ba�lang�� de�erini audioSource'un �u anki volume de�eri ile ayarla
        volumeSlider.value = audioSource.volume;
    }

    public void SettVolume()
    {
        // Slider'dan gelen de�eri audioSource'a ata
        audioSource.volume = volumeSlider.value;
    }
}
