﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * speed);
	}
}
