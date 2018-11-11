using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendFollow : MonoBehaviour
{
    [SerializeField]
    public float speed;

    public Rigidbody2D playerRB;
    private Rigidbody2D selfRB;
//    private Animator birdAnimator;
    //not on top of each other
    //private Vector3 offset;
    private Transform target;
    public Transform grabpoint;


    [SerializeField]
    public float stoppingDistance;

    public enum BirdState { Idle, Flying, Carrying }

    public BirdState currentState;
    

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        selfRB = GetComponent<Rigidbody2D>();
        currentState = BirdState.Idle;
        //birdAnimator = GetComponent<Animator>();


    }

    // Update is called once per frame
    public void FixedUpdate()
    {

        {
            switch (currentState)
            {
                case BirdState.Idle:
                    moveBirdNormal();

                    selfRB.gravityScale = 0;

                    break;

                case BirdState.Flying:
                    moveBirdNormal();
                    selfRB.gravityScale = 0;
                    break;


                case BirdState.Carrying:
                    moveBirdcarrying();
                    selfRB.gravityScale = 1;
                    break;
            }

        }

    }
    void moveBirdNormal (){
        stoppingDistance = 7;
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }

    }
    void moveBirdcarrying(){
        Debug.Log("moving towards point");
        stoppingDistance = 0;
        transform.position = Vector2.MoveTowards(transform.position, grabpoint.position, speed * Time.deltaTime);

    }

    //Public Methods
    public void EnterFlying()
    {
        {
            currentState = BirdState.Flying;

        }
    }
    public void BackToIdle()
    {

        currentState = BirdState.Idle;
    }
    public void StartCarrying()
    {
       // offset = transform.position - target.position;
        currentState = BirdState.Carrying;
    }
}