using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class triggerConversation : MonoBehaviour {

     
    public Dialouge dialouge;
    

 
    //triggr the conversation 
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            
            FindObjectOfType<textManager>().startDialouge(dialouge);//will satart the dialoge
            Destroy(gameObject);//the dialouge will work for one time only 

        }
        
    }
    


}
