using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElements : MonoBehaviour {



    public Dialouge dialouge;


    public void TriggerDialouge()
    {
        FindObjectOfType<textManager>().startDialouge(dialouge);

        
 
            
    }

}
