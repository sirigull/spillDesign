using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

    public GameObject fog;
    public GameObject bird;
    public GameObject treeTrigger;
    public GameObject text;
    public GameObject TriggerMushroom;
    public GameObject jumpTrigger;
    public GameObject jumpText;
    public GameObject airButton;
    public GameObject airText;


    private bool activated;
    public bool grabbed;
    public Transform grabpoint;

    public PlayerMovement playerMovement;
    public Abilities abilities;
    public GameObject infoText;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && activated){
            Destroy(fog);
        }
    }


    private void OnTriggerEnter2D()
    {
        Debug.Log("true");
        if (gameObject == jumpTrigger)
        {
            Debug.Log("jumpText");
            jumpText.SetActive(true);
            Debug.Log("active");
        }
        if (gameObject == TriggerMushroom){
            text.SetActive(true);
           
            abilities.grabAbility = true;
            Debug.Log("true");

        }
        if(gameObject == treeTrigger){

            infoText.SetActive(true);
        }
        if(gameObject == airButton){
            activated = true;
            Debug.Log("activated");
            airText.SetActive(true);
            Debug.Log("airbutton");

        }
    }
        private void OnTriggerExit2D(){
        Debug.Log("False");
        activated = false;
        jumpText.SetActive(false);

    }
}