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
  [SerializeField] private AudioSource soundSource;

  private float musicVolumeValue = 0.75f;
  private float soundVolumeValue = 1f;

  void Start()
  {
    musicSource.volume = musicSlider.value;
    soundSource.volume = soundSlider.value;
    musicSlider.onValueChanged.AddListener(SetMusicVolume);
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

  public void SetMusicVolume(float volumen)
  {
    musicSource.volume = volumen;
  }

  public void SetSoundVolume(float volumen)
  {
    soundSource.volume = volumen;
  }
}
