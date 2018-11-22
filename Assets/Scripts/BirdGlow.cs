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
        myAnimator.speed = 1.0f;
        myAnimator.SetBool("smaller", false);
        myAnimator.SetBool("bigger", true);
    }

    public void birdSmaller(float speed)
    {
        myAnimator.speed = speed;
        myAnimator.SetBool("bigger", false);
        myAnimator.SetBool("smaller", true);
    }

    public void release()
    {
        myAnimator.SetBool("release", true);
    }
}
