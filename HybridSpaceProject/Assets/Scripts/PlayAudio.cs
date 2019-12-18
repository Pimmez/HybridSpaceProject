using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
	[SerializeField] private AudioSource audioSource;

	public void ActivateAudio(AudioClip _audioClip)
	{
		audioSource.clip = _audioClip;
		audioSource.Play();
	}
}