﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfrotation : MonoBehaviour {

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0,rotationSpeed,0);
		
	}
}
