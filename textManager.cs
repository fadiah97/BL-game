using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class textManager : MonoBehaviour {


    /*the group of elemnts that can be definrd from the inspecter */
    public Text nameText;  
    public Text DialougeText;
    public Animator anim;
    public Image imagespot;
    //we dont want the palyer to move the cahracter when a story begin 
    public bool canMove; 
    public playerControler conturl; //refrence to the player control

    private Queue<string> sentences;//queue of strings 

	 
	void Start () {
        sentences = new Queue<string>();
        conturl = FindObjectOfType<playerControler>();//to get the components fro the other script 
      
    }
	
     public void  startDialouge(Dialouge dialouge)
    {

         canMove = false;
        if (!canMove)
        {
            conturl.enabled = false; //disable the control 
            conturl.MyAnim.SetBool("stop", true);
            conturl.MyAnim.SetBool("Is grounded", true);
        }

        anim.SetBool("Open", true); //start the dialouge box animation 

         

        imagespot.sprite = dialouge.Actor; //to be able to use multiple texts and images 
        nameText.text = dialouge.name;
        sentences.Clear(); //if there is left sentence then clear it befor the next 

        foreach (string sentence in dialouge.sentences) //put the sentences in a queue
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextSentences(); 
    }

    public void DisplayNextSentences() 
    {
        if(sentences.Count == 0) // if there is no more sentences then disable the dialouge box 
        {
            EndDialouge();
            return;

        }

       string Sentence= sentences.Dequeue(); //get the sentence of the queue

        StopAllCoroutines(); //stop the type affect 
        StartCoroutine(TypeSentence(Sentence));




    }

     

    IEnumerator TypeSentence (string sentence) //the type affect 
    {
        DialougeText.text = "";

        foreach(char Letter in sentence.ToCharArray()) //type each charater at a time 
        {
            DialougeText.text += Letter;
            yield return null;

        }

    }
     void EndDialouge()
    {

         canMove = true; 
        if ( canMove) // able the movement 
        {
            conturl.enabled = true;
            conturl.MyAnim.SetBool("stop", false);
        }
            anim.SetBool("Open", false); //close the dialouge box 
         
         
    }

}
