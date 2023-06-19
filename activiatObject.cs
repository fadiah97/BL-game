using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activiatObject : MonoBehaviour {

    public GameObject dialougeBox;
    public bool activeObject;

	
	// Update is called once per frame
	void Update () {
        if (activeObject == true)
        {
            dialougeBox.SetActive(true);
        }
        else
            dialougeBox.SetActive(false);
		
	}
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            activeObject = true;
        }
        else
            activeObject = false; 
    }
}
