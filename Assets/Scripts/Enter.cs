using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

    public GameObject sign;
    public GameObject mushroom;
    public GameObject treeTrigger;
    public GameObject text;
    public GameObject TriggerMushroom;

    private bool activated;
    public bool grabbed;
    public Transform grabpoint;

    public PlayerMovement playerMovement;
    public Abilities abilities;
    public GameObject infoText;


 



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && activated){
            Destroy(sign);
        }



    }


    private void OnTriggerEnter2D()
    {
        if(gameObject == TriggerMushroom){
            text.SetActive(true);
            activated = true;
            abilities.grabAbility = true;
            Debug.Log("true");

        }
        if(gameObject == treeTrigger){

            infoText.SetActive(true);
        }
    }
  



            private void OnTriggerExit2D(){
        activated = false;

    }
  

}
