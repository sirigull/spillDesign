using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D myRigidBody;
    private Animator myAnimator;

    public GameObject mushroom;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;
    [SerializeField]
    private Transform[] groundPoints;
    [SerializeField]
    private float groundRadius;
    [SerializeField]
    private LayerMask whatIsGround;

    private bool isGrounded;
    private bool jump;
    private bool attack;
    
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private bool airControl;

    private bool secondJumpAvail = false;

    //State Machine
    public enum Gstate {Idle, Running, Jumping, Flying, Action}

    public Gstate currentState;

    


    // Use this for initialization
    void Start () {
        facingRight = true;
        
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        currentState = Gstate.Idle;
    }
    void Update(){
        HandleInput();
        
    }
    // Update is called once per frame
    void FixedUpdate () {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        isGrounded = IsGrounded();

        Flip(horizontal);
        HandleAttacks();

        switch(currentState){
            case Gstate.Idle:
                HandleMovement(horizontal);
                myRigidBody.gravityScale = 1;

                break;
            case Gstate.Running:
                HandleMovement(horizontal);
                myRigidBody.gravityScale = 1;
                 break;
            case Gstate.Action:
                myRigidBody.gravityScale = 1;

                break;
            case Gstate.Flying:
                HandleFlying(horizontal, vertical);
                myRigidBody.gravityScale = 0;
                break;
        }

        ResetValues();
    
    }
    private void HandleMovement(float horizontal){
    /*    if(!this.myAnimator.GetCurrentStateAnimatorStateInfo(0).isTag("Attack")){

        }*/

        if (isGrounded && jump){
            isGrounded = false;
            myRigidBody.AddForce(new Vector2(0, jumpForce));
            secondJumpAvail = true; 
        }
        else {
            if(isGrounded && jump){
                isGrounded = false;
                if(secondJumpAvail){
                    myRigidBody.AddForce(new Vector2(0, jumpForce));
                    secondJumpAvail = false;

                }

            }
        }

        if(isGrounded || airControl){
        myRigidBody.velocity = new Vector2(horizontal * movementSpeed,myRigidBody.velocity.y); //x = -1, y = 0
        }
        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
        
        
        
    }


 

    public void EnterFlying()
    {

            currentState = Gstate.Flying;


    }
    public void BackToIdle(){

        currentState = Gstate.Idle;

    }



    private void HandleFlying(float horizontal, float vertical){

        myRigidBody.velocity = new Vector2(horizontal * movementSpeed,vertical * movementSpeed); //x = -1, y = 0

    
         myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
        
    }

    private void HandleAttacks(){
        if(attack){
            myAnimator.SetTrigger("attack");
        }
    }
    private void HandleInput(){
        if (Input.GetKeyDown(KeyCode.Space)){
            jump = true;
        }


        if (Input.GetKeyDown(KeyCode.LeftShift)){
            attack = true;
        }
        
    }

    private void Flip(float horizontal){
    

        if (horizontal>0 &&!facingRight || horizontal<0 && facingRight){
            facingRight=!facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;

            transform.localScale = theScale;

        }
    }
    private bool IsGrounded(){
        if (myRigidBody.velocity.y <= 0){
            foreach(Transform point in groundPoints){
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position,groundRadius,whatIsGround);
            for (int i = 0; i< colliders.Length; i++){
                if(colliders[i].gameObject != gameObject){
                    return true;
                }
            }
        }
            
        }
        return false;
    }

    private void ResetValues(){
            jump = false;
            attack = false;
    }
}

