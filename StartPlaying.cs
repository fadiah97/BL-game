using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartPlaying : MonoBehaviour {

    public GameObject BLOCK;
    public GameObject button;
	// Update is called once per frame
	void Update () {

        Time.timeScale = 0f;
    }
 


    public void PlayGame()
    {
        BLOCK.SetActive(false);//strat the game 
        Time.timeScale = 1f;

    }
}
