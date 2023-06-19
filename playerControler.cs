using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{

    //movment variables
    public float MaxSpeed; //how much speed the character can move accessable from unity 
    Rigidbody2D MyRB; //refrvenced to the rigidbody to the charecter 
    public Animator MyAnim; //refrenced to the animator 
    bool FacingRight = true; //flip the character 
    public float jumpSpeed = 5f;

    //fall detect 
    public Vector3 Respone; // from wher the player will respone 
    //public bool canMove;


    //jumping variables
    //what is ground,that the player can jump on 
    public LayerMask WhatisGround;
    //location of the circle ,where to check the ground 
    public Transform groundChack;
    //to make desicoun if player was on the ground a check machnesim
    public float groundRaduis = 0.2f;
    bool grounded = false; // the character is on the ground
    public float jumpForce = 700f;
    //double jump
    bool doubleJump = false;


    //palyer health script 
    PlayerHealth health;
    //damege taken 
    public float damege;
    //if a conversation started the player stop moving 
    public textManager check;

      
    // Use this for initialization
    void Start()
    {

        MyRB = GetComponent<Rigidbody2D>();
        MyAnim = GetComponent<Animator>();


        Respone = transform.position;  // initial respone point When the game statrts 
        health = GetComponent<PlayerHealth>(); // to get a refrence to the player health script 
        check = FindObjectOfType<textManager>();



    }



    // Update is called once per frame
    void FixedUpdate()
    {
         

         
        // check to see if player is on the ground or not will return T/F
        grounded = Physics2D.OverlapCircle(groundChack.position, groundRaduis, WhatisGround);
        //referenced to the animator 
        MyAnim.SetBool("Is grounded", grounded);

        if (grounded)
            doubleJump = false;

        //refrenced to verical speed
        MyAnim.SetFloat("vspeed", MyRB.velocity.y);




        //jump with out animation 



        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            MyRB.velocity = new Vector2(MyRB.velocity.x, jumpSpeed);


        }


        //if (!grounded) // cant turn while jump 
            //return;

        //get the axis input 
        float move = Input.GetAxis("Horizontal");//how much we moving 





        //set the animator 
        MyAnim.SetFloat("speed", Mathf.Abs(move)); //we dont care about the nigative direction we care about the movement

        MyRB.velocity = new Vector2(move * MaxSpeed, MyRB.velocity.y);//to move the character ,vector cus 2D (x,y)


        if (move > 0 && !FacingRight)
        {
            flip();
        }

        else if (move < 0 && FacingRight)
        {
            flip();
        }





    }


    void flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scale = transform.localScale; // the local scale in unity x,y,z
        Scale.x *= -1; // to multipy the x scale with nigative to flip the image so it face the other side 
        transform.localScale = Scale; //tacke the upove and return it to the scale 

    }

    void Update()
    {

        // jump / fall animation 
        if ((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {
            MyAnim.SetBool("Is grounded", false);
            MyRB.AddForce(new Vector2(0, jumpForce)); //we the y axis force not x 


            if (!doubleJump && !grounded) // double jumping 
            {

                doubleJump = true;
                MyRB.AddForce(new Vector2(0, jumpForce));
            }



        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "fallDetector") // if other objects enters the tag fall setector 
        {

            //damege
            health.AddDamege(damege);
            //what will happer if the player fall into the trigger by the tag name 
            transform.position = Respone;

        }

        if (other.tag == "CheckPoint")
        {
            Respone = other.transform.position; // the respone point will be set to the reached check point 

        }

    }

    
}