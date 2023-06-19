using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PAUSE : MonoBehaviour {

    public GameObject pauseMenu; //the ui pause menu 
    public GameObject pauseButton;//the poase button 




    public void PauseGame()
    {
        pauseMenu.SetActive(true); //if presed the button then set the menu active and diable the button
        pauseButton.SetActive(false);
        Time.timeScale = 0f;

    }


    public void ResumeGame()
    {
        pauseMenu.SetActive(false);//opposit to the one before se the menu off and set the button on  
        pauseButton.SetActive(true);
        Time.timeScale = 1f;

    }

    public void QuitGame()
    {
        Debug.Log("guitting game....");
        Application.Quit(); //will quit the application 
    }

    public void menuButton()
    {

        Debug.Log("loding menu ");
        SceneManager.LoadScene("Scenes/menu");//will load the main menu scane
    }
}
