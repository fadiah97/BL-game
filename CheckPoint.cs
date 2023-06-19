using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {


    public Sprite darkCheckPoint;  // to determine the sprite "defoalt " one 
    public Sprite lightCheckPoint; // the sprite thet will take the place of the other defoult sprite 
    SpriteRenderer CheckPointSpriteRender;//to be able to changr the sprite 
    public bool CheckPointReach; // a bool value 


    // Use this for initialization
    void Start () {

        CheckPointSpriteRender = GetComponent<SpriteRenderer>();  // to get the sprite compnent from the engine 



	}

    void OnTriggerEnter2D(Collider2D Other) // on trigger function that will check when the tag object pass thi point 
    {
        if (Other.tag == "Player")  // if the tag player enters the collidor 
        {

            CheckPointSpriteRender.sprite = lightCheckPoint; // the sprite will change 
            CheckPointReach = true; // the check poit reached 

        }
    }
}
