using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamps : MonoBehaviour {



    //public varibles
    public Sprite off;//the defult sprit 
    public Sprite on;// the sprite that will replace the defult sprit 
    SpriteRenderer PassCondition;//sprite render to control the sprites 
    public GameObject Affects;// the kind of affect that will be triggered when the player pass by it 

    // Use this for initialization
    void Start () {
        PassCondition = GetComponent<SpriteRenderer>();

    }

    private void OnTriggerEnter2D(Collider2D Other) // to check if the player passes this point 
    {

        if (Other.tag == "Player")
        {
            PassCondition.sprite = on;
            Instantiate(Affects, transform.position, transform.rotation); // instantiat the affect at the position
        }


    }
}