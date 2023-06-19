using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text countDown; //set a timer from the ui element 
    [SerializeField]
    GameObject gameoverMenu; //the game over menu 
    float currentTime = 0f; //current time that will change second by second 
    float startingTime = 360f;//the starting time in seconds 

    private void Start()
    {
        currentTime = startingTime; // at the start the current time will be same as the starting time
    }


    private void Update()
    {
        currentTime -= 1 * Time.deltaTime; //the time will decreas second by second 
        countDown.text = currentTime.ToString("0"); // only the integer number will appears 

        if(currentTime <= 60)
        {
            countDown.color = Color.red; // change color if the time is less than 60 
        }
        if(currentTime <=0)
        {
            gameoverMenu.SetActive(true); // when the time is out game is over 
            currentTime = 0;
        }

    }
}