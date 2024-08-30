using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
  // References
  private AudioSource m_AudioSource;
  [SerializeField] private AudioClip dashSound;
  [SerializeField] private AudioClip[] shortJumpSound;
  [SerializeField] private AudioClip[] longJumpSound;
  [SerializeField] private AudioClip[] deathSound;

  private void Awake()
  {
    m_AudioSource = GetComponent<AudioSource>();
  }

  public void PlayDashSound()
  {
    m_AudioSource.clip = dashSound;
    m_AudioSource.Play();
  }

  public void PlayRandomShortJumpSound()
  {
    m_AudioSource.clip = shortJumpSound[Random.Range(0, shortJumpSound.Length - 1)];
    m_AudioSource.Play();
  }

  public void PlayRandomLongJumpSound()
  {
    m_AudioSource.clip = shortJumpSound[Random.Range(0, longJumpSound.Length - 1)];
    m_AudioSource.Play();
  }

  public void PlayRandomDeathSound()
  {
    m_AudioSource.clip = shortJumpSound[Random.Range(0, deathSound.Length - 1)];
    m_AudioSource.Play();
  }
}
