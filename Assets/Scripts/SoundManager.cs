using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip birdSound;
    public AudioClip buttonSound;
    public AudioClip machineSound;
    //public bool keepFadingOut;
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
        if(source.isPlaying)
        StartCoroutine("FadeOut");
    }

  /*public void FadeOutCaller(float speed){
        Debug.Log("coroutine");
        StartCoroutine(FadeOut(speed));
    }*/

   IEnumerator FadeOut(){
        Debug.Log("fadeout");
      
        while(source.volume > 0.01f){
             source.volume -= Time.deltaTime / 15.0F;
             yield return null;

        }
        source.volume = 0;
        StartCoroutine(ResetVolume());
        source.Stop();
    }

    IEnumerator ResetVolume(){
        yield return new WaitForSeconds(1f);
        source.volume = 0.2f;
    }
}