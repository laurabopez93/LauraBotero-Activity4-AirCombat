﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipalNavyControl : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {

    //Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);
        }

        //Motion Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left);
    }

    //Up
    if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        } 

        //Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        } 

        //Space key for shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Creamos un nuevo gameobject Missile a partir de un prefab (planos de construccion)
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);

            //Buscamos el Pivote del disparo
            GameObject ShootPivot = GameObject.Find("Aircraft/ShootPivot");

            //Hacemos el misil sea hijo de Shoot pivot
            newMissile.transform.SetParent(ShootPivot.transform);

            //Movemos el misil hacia donde esta el shoot pivot, es decir, debajo del ala
            newMissile.transform.localPosition = Vector3.zero;

            //Hacemos quee los misiles ya no sean hijos del avion
            newMissile.transform.SetParent(null);
        } 


    }  //End Update
} 

       