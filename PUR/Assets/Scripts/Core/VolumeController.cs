using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    // References
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider soundSlider;
    [SerializeField] private AudioSource musicSource;

    private float musicVolumeValue = 1f;
    private float soundVolumeValue = 1f;

    void Start()
    {
        musicSource.volume = musicSlider.value;
        musicSlider.onValueChanged.AddListener(setVolumenMusic);
    }
    private void Awake()
    {
        musicSlider.value = musicVolumeValue;
        soundSlider.value = soundVolumeValue;
    }

    public void ResetVolumeConfigurationToDefault()
    {
        musicVolumeValue = 1f;
        soundVolumeValue = 1f;
    }

    public void SetMusicVolumeValue()
    {
        musicVolumeValue = musicSlider.value;
    }

    public void SetSoundVolumeValue()
    {
        soundVolumeValue = soundSlider.value;
    }

    public void setVolumenMusic(float volumen)
    {
        musicSource.volume = volumen;
    }
}
