using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseBird : MonoBehaviour {

    public BirdGlow birdGlow;
    public GameObject triggerObject;
    public GameObject endscreen;
    public bool activated;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && activated)
        {
            birdGlow.release();
            Invoke("EndScreen", 10f);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player")
        {
            activated = true;
        }
        else
        {
            activated = false;
        }



    }

    void EndScreen(){
        endscreen.SetActive(true);
    }
}
