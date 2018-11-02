using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{


    public PlayerMovement playerMovement;
    public bool grabAbility;
    public bool canGrab;
    public GameObject hinged;

    public enum Gstate { Idle, Running, Jumping, Flying, Action }

    public Gstate currentState;





    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && grabAbility)
        {
            if (canGrab && playerMovement.currentState != PlayerMovement.Gstate.Flying)
            {
                Debug.Log("has pressed G");
                playerMovement.EnterFlying();
                Debug.Log("is flying");

            }
        }
        /*if (currentState == Gstate.Flying)
        {
            hinged.SetActive(true);

        }*/



        else
        {
            playerMovement.BackToIdle();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "mushroom")
            canGrab = true;

    }










    /*  grabbed = true;

      if (grabbed)
      {
      }
  }
  else{
      grabbed = false;

  }
  if(grabbed){
      if(Input.GetKeyDown(KeyCode.G)){
         playerMovement.BackToIdle();

      }
  }*/


    // Use this for initialization
    //  void Start () {



    // Update is called once per frame


}

