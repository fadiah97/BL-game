using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollowPlayer : MonoBehaviour {

      public Transform target; // the object "transform" the camera will follwo in this case the player 
      public float smothSpeed; // the smoothiness of the camera trastions 
      public Vector3 offSet;// offset between the camera and the player 
      public bool boundry; // boundry that the camera cant go bound it 
      public Vector3 minPos; // min boundry 
      public Vector3 maxPos; // max boundry 







    void FixedUpdate()
     {

         Vector3 WantedPosion = target.position + offSet; // the wanted posiont of the cemer 
         Vector3 smothMovment = Vector3.Lerp(transform.position, WantedPosion, smothSpeed*Time.deltaTime); //the smoth of the camera 

         transform.position = smothMovment;  //addin two vectors  , the postion of the transform equal the smoth of the movment 


        if (boundry) // to determine the camera boundry 
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPos.x, maxPos.x),
               Mathf.Clamp(transform.position.y, minPos.y, maxPos.y),
               Mathf.Clamp(transform.position.z, minPos.z, maxPos.z));



         

     } 




}
