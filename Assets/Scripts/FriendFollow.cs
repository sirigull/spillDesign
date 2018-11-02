using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendFollow : MonoBehaviour
{
    [SerializeField]
    public float speed;

    public Rigidbody2D playerRB;
    private Rigidbody2D selfRB;
    private Animator birdAnimator;

    private Transform target;


    [SerializeField]
    public float stoppingDistance;

    public enum BirdState { Idle, Flying, Carrying }

    public BirdState currentState;




    private Vector2 randomMove = new Vector2(0f, 0f);
    private bool canMove = true;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        selfRB = GetComponent<Rigidbody2D>();
        currentState = BirdState.Idle;
        birdAnimator = GetComponent<Animator>();


    }

    // Update is called once per frame
    public void FixedUpdate()
    {

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {


            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            switch (currentState)
            {
                case BirdState.Idle:

                    selfRB.gravityScale = 0;

                    break;

                case BirdState.Flying:
                    selfRB.gravityScale = 0;
                    break;

                    /*case BirdState.Action:
                        myRigidBody.gravityScale = 1;*/

            }





            /* if (playerRB.velocity.x == 0f && playerRB.velocity.y == 0f){
                Debug.Log("not moving");
                transform.position = Vector2.MoveTowards(transform.position, randomMove, 0.5f * speed * Time.deltaTime);
            }

            if(canMove){
                StartCoroutine(ResetTarget());
                canMove = false;
            }


        }


        IEnumerator ResetTarget(){
            yield return new WaitForSeconds(Random.Range(2, 3));
            float randomX = Random.Range(-4f, -2f);
            float randomY = Random.Range(2f, 4f);
            randomMove = new Vector2(target.position.x + randomX, target.position.y + randomY);
            canMove = true;

        }
        */

        }

    }
            public void EnterFlying() {

                currentState = BirdState.Flying;

                    }
        public void BackToIdle() {

             currentState = BirdState.Idle;
         }
}


