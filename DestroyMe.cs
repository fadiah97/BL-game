﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour {

    
    public float AlifeTime; 
    
    

	// Use this for initialization
	void Awake () {

        Destroy(gameObject, AlifeTime);

    }
	
	 
}
