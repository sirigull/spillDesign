using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SickBird : MonoBehaviour {

    public SoundManager soundManager;
    public PlayerMovement playerMovement;
    public BirdGlow birdGlow;

    public Abilities abilities;
    public GameObject smallGlow1;
    public GameObject bigGlow2;

    private void Update()
    {

    }

    private void Start()
    {
        abilities = GameObject.FindGameObjectWithTag("Player").GetComponent<Abilities>();
        abilities.grabAbility = true;
        bigGlow2.SetActive(true);
        //smallGlow1.SetActive(false);
        Debug.Log("grabability true");
        //birdGlow.birdBigger();
    }


    private void OnTriggerEnter2D(Collider2D other)
        {
           
       if(other.tag =="Player")
            
        {
            Debug.Log("collide smog true");
            abilities.grabAbility = false;
            //smallGlow1.SetActive(true);
            //bigGlow2.SetActive(false);
            birdGlow.birdSmaller(1);
            playerMovement.BackToIdle();

            Debug.Log("Grbbillt false");
            soundManager.stopBirdSound();
        }

      /* else
        {
            abilities.grabAbility = true;
            Debug.Log("grabbilly true");
            }*/
    }

    /*private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            abilities.grabAbility = true;
        }

    }*/
}