using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Scene : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    public void playAudio()
    {
        audioSource.Play();
    }

    private void OnMouseDown()
    {
        audioSource.Play();
    }
}
