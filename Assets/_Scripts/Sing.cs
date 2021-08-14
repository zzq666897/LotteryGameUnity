using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sing : MonoBehaviour
{
    [SerializeField] AudioClip audio;
    [SerializeField] AudioSource audioSource;

    [SerializeField] float Volume = 0.5f;

    public void playSong()
    {
       if(audio && audioSource)
        {

            audioSource.PlayOneShot(audio, 0.5f);
        }
        else
        {
            return;
        }

    }

}
