using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeckUp : MonoBehaviour {

    inventory inventory; //invetory that will hold the object 
    public GameObject itemButton; // the object that will appear in the inventory when the stone is collected 
    // Use this for initialization
    void Start()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>(); //to find the object with the tag player and get the inventory component 



    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")  // if the player collide with this object 
        {
            for (int i = 0; i < inventory.slot.Length; i++) // the length with the slots avalible
            {
                if (inventory.isFull[i] == false) //if the inventory is not full you can pick up the object 
                {


                    //item can be picked up 
                    inventory.isFull[i] = true;  
                    Instantiate(itemButton, inventory.slot[i].transform, false);// the place of the object in the inventory 
                    Destroy(gameObject); // then destroy the object 
                    break;
                }




            }

        }

    }
}
