using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesInfo : MonoBehaviour {

    public GameObject Info; //a game object will be shown on the move of the mouse 
    // Use this for initialization
    public void Start()
    {
        Info.SetActive(false); //at first it will be off

    }

    
    public void OnMouseOver()
    {

        Info.SetActive(true); // if the mouse move over it it will appear 
    }
    public void OnMouseExit()
    {
        Info.SetActive(false); // if the mouse move from it it will disappear 

    }
}
