using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextBoxmanager : MonoBehaviour {

    public GameObject TextBox; // the ui object thet will display the dialouge
    public Text text; // the text it self 

    
    public TextAsset TextFile; //the testasset , group of lines 
    public string[] textLines; // an arrye for displayring the lines 
    public int CurrentLine; // the current line 
    public int EndAtline; // the line we will end at 

    public playerControler player; //player movment . we want to disable it when conversation statrs 
    public bool isActive;
    //public bool StopPlayer;
    


    // Use this for initialization
    void Start()
    {
        if (isActive)
        {
            OnEnableTextbox();
        }
        else
            OnDisableTextbox();


        player = FindObjectOfType<playerControler>();  // arefrence to the player control script  

        if (TextFile != null) // if the script is not empty then do 
        {
            textLines = (TextFile.text.Split('\n')); // split the lines 
        }

        if(EndAtline == 0) // if the end is 0 , then reload the lines 
        {
            EndAtline = textLines.Length - 1;
        }
    }

    private void Update()
    {

      

        if (!isActive) // if the text box is not active then dont update the text 
        {
            return;
        }
        text.text = textLines[CurrentLine]; // display the current line 
        if (Input.GetKeyDown(KeyCode.Return)) //when presing return change lines 
        {

            CurrentLine += 1; 
        }
        if(CurrentLine > EndAtline) //if we reched the last line close the dialouge box .
        {
            OnDisableTextbox();
        }
    }

    public void OnEnableTextbox()
    {
        TextBox.SetActive(true);
        //if (StopPlayer)
       // {
          //  player.canMove = false;
       // }
        isActive = true;
    }


    public void OnDisableTextbox()
    {
        TextBox.SetActive(false);
        //player.canMove = true; // if the textbox is disable the player will move 
    }


    public void ReloadScript(TextAsset text)
    {
        if(text != null)
        {
            textLines = new string[1];

            textLines = (text.text.Split('\n'));
        }
        isActive =  false;

    }

    public void NextLine()
    {
        

            CurrentLine += 1;
        if (CurrentLine > EndAtline) //if we reched the last line close the dialouge box .
        {
            OnDisableTextbox();
        }
    }
   
}

