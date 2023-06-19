using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamege : MonoBehaviour {

    public float Damege; // the amount of damege can be determine from the main interface of the engine 
    public float DamegeRange;// the range the damege can accure in 
    public float bushForce;// the bush force that will bush the player away from the object 
    float NextDamege; // when the next damege can accure 
   



    private void Start()
    {
        NextDamege = 0f; // no space between the damege rounds 
        


    }

 


    public void OnTriggerStay2D(Collider2D Other)
    {

        if (Other.tag == "Player" && NextDamege < Time.time) // if the player collides with the object 
        {
            PlayerHealth thePlayerHeath = Other.gameObject.GetComponent<PlayerHealth>(); // get a refrence to the player health 
            thePlayerHeath.AddDamege(Damege);  // use this function that is in the player health script 
            NextDamege = Time.time + DamegeRange; // the next damege accures 
            BushBack(Other.transform); //function 
           




        }

    }


    


    void BushBack(Transform BushedObject) // the direction where the player will be bushed 
    {
         
        Vector2 BushDirection = new Vector2(1, BushedObject.position.y - transform.position.y).normalized; //the vector of the bush function 
        BushDirection *= bushForce; //the added power of the bush force 
        Rigidbody2D BushedRB = BushedObject.gameObject.GetComponent<Rigidbody2D>();//a refrence to the rigid body "player" that the bush power will have affect on 
        BushedRB.velocity = Vector2.zero; //we dont want to change the velocity of the rigid body 
        BushedRB.AddForce(BushDirection, ForceMode2D.Impulse); // to appy the force on the object 

        
       
            

    }


 







}



