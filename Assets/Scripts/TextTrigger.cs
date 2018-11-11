using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script displays a gameObject when another gameObject is triggered

public class TextTrigger : MonoBehaviour
{

    public GameObject triggerObject;
    public GameObject displayText;


    private void OnTriggerEnter2D()
    {
        Debug.Log("true");
        if (gameObject == triggerObject)
        {
            Debug.Log("displayText");
            displayText.SetActive(true);
            Debug.Log("active");
        }
    }


    private void OnTriggerExit2D()
    {
        Debug.Log("False");
            displayText.SetActive(false);

    }
}