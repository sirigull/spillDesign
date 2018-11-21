using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmogMover : MonoBehaviour {

    public Abilities abilities;
    public Transform[] movePoints;
    public BirdGlow birdGlow;

    public int currentPointPosition;
    public SickBird sickBird;

    //public float movementHeight;
    //public float movementWidth;

  void Update () {

      /* if (Input.GetKeyDown(KeyCode.E) && smogTrigger.activated)
        {
            //Destroy(overlay);
            //  overlay.transform.Translate(new Vector3(movementWidth, movementHeight, 0));
            Debug.Log("smogTriggerActivated");
            overlay.transform.position = movePoints[currentPointPosition].position;
            currentPointPosition++;
            abilities.grabAbility = true;
            Debug.Log("grabability true");
        }*/

    }

    public void MoveSmog()
    {
        Debug.Log("smogTriggerActivated");
        transform.position = movePoints[currentPointPosition].position;
        currentPointPosition++;
        abilities.grabAbility = true;
        sickBird.bigGlow2.SetActive(true);
        sickBird.smallGlow1.SetActive(false);
        Debug.Log("grabability true");
        birdGlow.birdBigger();
    }
}
