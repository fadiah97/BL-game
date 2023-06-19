using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

 public void LoadLevel(int SceneIndex)
    {

        StartCoroutine(LoadAsync(SceneIndex));
    }

    IEnumerator LoadAsync(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        while(!operation.isDone)
        {
            Debug.Log(operation.progress); //the current prograss

            yield return null; 

        }
    }
}
