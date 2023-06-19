using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour {

    Rigidbody2D platform; //rigid body that will be affected by the gravity 
    public float fallDelay; //how much time before the platform falls 
      
    private void Start()
    {
        platform = GetComponent<Rigidbody2D>(); //define the reigidbody components

    }

    //colliding condition checking 
    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.collider.CompareTag("Player"))//if what called player collide with this object then ..
        {
             
            StartCoroutine(fall()); //start the routine
            
        }
 
    }

    IEnumerator fall()//will control the function 
    {
        yield return new WaitForSeconds(fallDelay); //wait for ..
        platform.isKinematic = false;//the gravity will affect the object 
        GetComponent<Collider2D>().isTrigger = true; //set the trigger to passable
        yield return 0;
    }

 
}
