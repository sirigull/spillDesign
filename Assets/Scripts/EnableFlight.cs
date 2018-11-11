using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableFlight : MonoBehaviour
{
    public GameObject flightTrigger;

    //private PlayerMovement playerMovement;
    private Abilities abilities;


    void Start()
    {
        abilities = GameObject.FindGameObjectWithTag("Player").GetComponent<Abilities>();
    }

    private void OnTriggerEnter2D()
    {

        if (gameObject == flightTrigger)
        {
            abilities.grabAbility = true;
        }
    }
}