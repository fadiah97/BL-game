using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WnnerGate : MonoBehaviour
{

    
    public GameObject RestartButton; 
    public GameObject NextLevelButton;
    


    public void REstartLevel()
    {
        Debug.Log("restarting level one ");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reload the current scene 
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        Debug.Log("TO LEVEL TWO WE GO ..!! ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/LevelTwo");//to the second level 
    }

    public void NextThreeLevel()
    {
        Debug.Log("TO LEVEL three WE GO ..!! ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/LevelThree");//to the third level 
    }

    public void GoodBye()
    {
        Debug.Log("endGame!! ");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/FinalGoodbye");//to the third level 
    }
}
