using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerStore : MonoBehaviour {

  //when the player collect the stone it will disappear from the level 
     
           private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
