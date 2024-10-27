using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    public AudioSource music;
    public Slider musicVolumeSlider;
    

    // Update is called once per frame
    void Update()
    {
        music.volume = musicVolumeSlider.value;
    }
}
