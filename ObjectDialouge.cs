using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

 
    [System.Serializable]//to let this class show on the editor 
    public class Dialouge
    {
          //the elements that can be change each conversation 
         public Sprite Actor;//the actor icon 
          public string name;//name
         [TextArea(4,10)] //wide of the text 
         public string[] sentences;
          

    }

