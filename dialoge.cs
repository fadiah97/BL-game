using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoge : MonoBehaviour {


    public TextAsset TextFile;
    public string[] textLines;


	// Use this for initialization
	void Start () {
        if(TextFile != null )
        {
            textLines = (TextFile.text.Split('\n'));
        }
		
	}
	
	 
}
