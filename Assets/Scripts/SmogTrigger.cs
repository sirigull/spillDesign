﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmogTrigger : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject triggerObject;

    public SmogMover smogMover;
 

    public bool activated;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && activated)
        {
            smogMover.MoveSmog();
            soundManager.playMachineSound();
            Destroy(this);
        }
    }
        private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag=="Player")
        {
            activated = true;
        }
        else
        {
            activated = false;
        }


    }

}
