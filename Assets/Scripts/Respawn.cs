using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {


    [SerializeField]
    private Transform player;



   public Transform respawnPoint;
   
  


   public void Respewn(){
        Debug.Log("respewn");
        player.transform.position = respawnPoint.position;

    }







   /* private const int Y = 50;
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
            transform.position = new Vector3(0, Y, 0);
    }*/
}
