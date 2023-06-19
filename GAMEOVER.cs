using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //using the scane mangger to control the scane loded
public class GAMEOVER : MonoBehaviour {


    public GameObject gameOverUI; //the game over Iu menu 
    public GameObject RestartGameButton, QuitGame, menu; // the buttons 


    public void Quitgame()
    {
        Debug.Log("guitting game....");
        Application.Quit();  // will qite the application 
    }

    public void RestartGame()
    {

        Debug.Log("game over...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reload the current scene 
    }


    public void menuButton()
    {
         
        Debug.Log("loding menu ");
        SceneManager.LoadScene("Scenes/menu");//will load the main menu scane
    }
}
