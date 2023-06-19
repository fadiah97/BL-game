using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinnerCheck : MonoBehaviour {

    public GameObject WinnerUIGate;//the ui winner menu 
    public GameObject deskStone;//the goal of the level 


    private void OnTriggerEnter2D(Collider2D other)
    {
        //if the player has the stone and reach to the gate then open it 
        if (other.tag == "Player" && (deskStone == null ))
        {
            Debug.Log("THE GATE IS OPEN  ");
            WinnerUIGate.SetActive(true);
            Time.timeScale = 0f;


        }
    }
}
