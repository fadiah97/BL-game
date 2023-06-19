using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMuchrom : MonoBehaviour
{

    public Sprite Sleep;//the defult sprit 
    public Sprite Awake;// the sprite that will replace the defult sprit
    SpriteRenderer CheckJumpCondition;//sprite render to control the sprites 
    public bool JumpCheck;// a boolean value just to check
    public float bushForce;//how much the jump force will be


    // Use this for initialization
    void Start()
    {

        //get the component from sprite 

        CheckJumpCondition = GetComponent<SpriteRenderer>();
    }

    //chack 
    private void OnTriggerEnter2D(Collider2D Other)
    {

        if (Other.tag == "Player") //if the player pass by then ..
        {
            CheckJumpCondition.sprite = Awake;//replace the sprite and
            JumpCheck = true;

            BushBack(Other.transform); //trigger the bush

        }
    }




    void BushBack(Transform BushedObject) // the direction where the player will be bushed 
    {

        Vector2 BushDirection = new Vector2(1, BushedObject.position.y - transform.position.y).normalized;//the bush direction 
        BushDirection *= bushForce;//multiplay by the froce 
        Rigidbody2D BushedRB = BushedObject.gameObject.GetComponent<Rigidbody2D>();//the player riged body
        BushedRB.velocity = Vector2.zero;//velocity in the y direction 
        BushedRB.AddForce(BushDirection, ForceMode2D.Impulse);//what kind of force we will use 





    }


}