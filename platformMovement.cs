using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour {

    Vector3 positionA;//the deful pos
    Vector3 positionB;//the new position 
     
    Vector3 Nextposition; 
    [SerializeField]
    float speed; // speed of the movment 
    [SerializeField]
    Transform child; //the paltform 
    [SerializeField]
    Transform transformB;//the platrom in the new postion 
     


	// Use this for initialization
	void Start () {
        positionB = transformB.localPosition; //the position b will be the pos of the b platform in its local place
        positionA = child.localPosition;//the pos of a will be th epos of the child platform 
        Nextposition = positionB;
	}
	
	// Update is called once per frame
	void Update () {
        move(); //move function for the paltform 
         
	}

    private void move()
    {
        child.localPosition = Vector3.MoveTowards(child.localPosition, Nextposition, speed * Time.deltaTime);//the cild platfrom move toward ..


        if (Vector3.Distance(child.localPosition, Nextposition) <= 0.1) //change the distincation 
        {
            changeDestination();
        }


    }

    void changeDestination()//logical condtion 
    {
         Nextposition= Nextposition != positionA ? positionA : positionB;
         
    }
}
