using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PasswordcCHECK : MonoBehaviour
{


    public InputField passwordField; //the inputfield 
    public Button check;//button that will trigger the check password 
    public GameObject tryAgain;//tryagain object that will appear on the screen 
    public Button close; //the close button 

    private void Start()
    {
        check.onClick.AddListener(passwords); //when the button clicked the password will be checked 
         close.onClick.AddListener(Clearmenu);//when the closed button is presed the cleanmenu will be triggered 
    }

 

    public void passwords()
    {
       // Get Password from Input
        string password = passwordField.text;

        string foundPassword="blue"; // the password to pass to  the level 
        if  ((foundPassword == password)) //the the interedpassword = the password 
        {
            Debug.Log("open");
            SceneManager.LoadScene("Scenes/LevelTwo"); //the second level will be loaded
        }
        else
        {
            tryAgain.SetActive(true); //if not the try again object will be triggered 
        }
    }

    public void Clearmenu()
    {
          passwordField.text = " " ; //clear the inputfield 
        
        tryAgain.SetActive(false); //hide the try again onject 
        return; //return everything to it origenal state 

    }
}


