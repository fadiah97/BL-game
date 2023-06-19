using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ActiveTextTaline : MonoBehaviour {
    public TextAsset Text;
     
    public int Startline;
    public int Endline;

    

    public TextBoxmanager textBox;
    public bool destoryWhenActivated;


	// Use this for initialization
	void Start () {
        textBox = FindObjectOfType<TextBoxmanager>();

        
    }
	
	

    private void OnTriggerEnter2D(Collider2D Other)
    {
            

        if (Other.tag == "Player")
        {
            textBox.ReloadScript(Text);
            textBox.CurrentLine = Startline;
            textBox.EndAtline = Endline;
            textBox.OnEnableTextbox();

            if (destoryWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }
}
