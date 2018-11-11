using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public PlayerMovement playerMovement;
    //public Abilities abilities;
    //public Enter enter;

    public bool grabAbility;
    //public bool canGrab;
    //public GameObject hinged;

    [SerializeField]
    public float birdTimer;

    public enum Gstate { Idle, Running, Jumping, Flying, Action }

    public Gstate currentState;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.G) && grabAbility)
        {
            if (playerMovement.currentState != PlayerMovement.Gstate.Flying) //canGrab && 
            {
                playerMovement.EnterFlying();
                Invoke("BirdTimer", birdTimer);

            }
            else
            {
                playerMovement.BackToIdle();

            }
        }

       
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
        //if (other.gameObject.name == "bird")
            //canGrab = true;

    //}

    void BirdTimer()
    {
        playerMovement.BackToIdle();
    }
}