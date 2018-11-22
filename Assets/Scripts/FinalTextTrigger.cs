using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTextTrigger : MonoBehaviour
{

    public GameObject canvas;


    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
        }


    }

    private void OnTriggerExit2D(Collider other)
    {
        if (other.tag == ("Player"));
        canvas.SetActive(false);
    }
}
