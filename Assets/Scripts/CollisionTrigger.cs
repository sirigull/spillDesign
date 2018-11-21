using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

	private Collider2D playerCollider;

	[SerializeField]
	private Collider2D platformCollider; 
	
	[SerializeField]
	private Collider2D platformTrigger;
	// Use this for initialization
	void Start () {

		playerCollider = GameObject.Find("Player").GetComponent<Collider2D>();
		Physics2D.IgnoreCollision(platformTrigger,GetComponent<Collider2D>(), true);
	}
	
void OnTriggerEnter2D(Collider2D other){
	if (other.gameObject.name == "Player"){
		Physics2D.IgnoreCollision(platformCollider, playerCollider,true);
	}

}

void OnTriggerExit2D(Collider2D other){
	if(other.gameObject.name == "Player"){
		Physics2D.IgnoreCollision(platformCollider, playerCollider,false);

	}
}
}
