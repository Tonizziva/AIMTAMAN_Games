﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Osuma : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D col) {
        if(col.gameObject.tag == "dot")
        {
            Debug.Log("Osui2");
            Paina1.start = false;
			Paina1.pause = true;
            if (Paina1.vibration == true)
            {
                Handheld.Vibrate();
            }
        }

    }
}
