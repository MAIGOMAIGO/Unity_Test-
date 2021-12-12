using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void BackGroundMusic(AudioClip sound){
        audioSource.clip = sound;
        audioSource.Play();
    }


    public void SoundEffect(AudioClip sound){
        audioSource.PlayOneShot(sound);
    }
}
