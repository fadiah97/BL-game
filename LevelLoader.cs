using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelLoader : MonoBehaviour {


    public GameObject LoadingScreen;  //the loading ui object 
    public Slider slider; //ui slider 
    public void LoadLevel(int SceneIndex) 
    {

        StartCoroutine(LoadAsync(SceneIndex)); //load the scene in asyncrenation 
    }

    IEnumerator LoadAsync(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex); //will show information about the prograss
        LoadingScreen.SetActive(true); //will show the loading screen 
        while (!operation.isDone) //while the operation is not done 
        {

            float prograss = Mathf.Clamp01(operation.progress / .9f); //the loding between 0-0.9
            Debug.Log(prograss); //the current prograss
            slider.value = prograss; //set the slider value to the prograss value 
         
            yield return null;

        }
    }
}
