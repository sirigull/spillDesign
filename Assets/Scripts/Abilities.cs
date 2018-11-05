﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{


    public PlayerMovement playerMovement;
    public Abilities abilities;
    public Enter enter;

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
                playerMovement.EnterFlying();
                Debug.Log("has pressed G");
              


            }
            else
            {
                Debug.Log("pressed G again");
                playerMovement.BackToIdle();

            }




        }

        if (currentState == Gstate.Flying)
        {
            hinged.SetActive(true);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "mushroom")
            canGrab = true;

    }










}

