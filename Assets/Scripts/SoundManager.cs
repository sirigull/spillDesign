using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip birdSound;
    public AudioClip buttonSound;
    public AudioClip machineSound;

    public AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    //plays birdSound if the Audio Player isn't busy
    public void playBirdSound()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(birdSound);
        }
    }

    public void playMachineSound()
    {
           source.PlayOneShot(buttonSound);
           source.PlayOneShot(machineSound);
    }

    public void stopBirdSound()
    {
            source.Stop();
    }
}