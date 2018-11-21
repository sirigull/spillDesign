using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGlow : MonoBehaviour {

    private Animator myAnimator;
    // Use this for initialization
    void Start () {
        myAnimator = GetComponent<Animator>();
    }
	
	public void birdBigger()
    {
        myAnimator.SetBool("smaller", false);
        myAnimator.SetBool("bigger", true);
    }

    public void birdSmaller()
    {
        myAnimator.SetBool("bigger", false);
        myAnimator.SetBool("smaller", true);
    }
}
