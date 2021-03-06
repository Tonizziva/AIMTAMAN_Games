﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditor : MonoBehaviour {
	public GameObject esteet;
	public GameObject kolikot;
    Text money;
    public static int currentMoney = 0;

    // Use this for initialization
    void Start () {
        money = GameObject.Find("Money").GetComponent<Text>();
        currentMoney = PlayerPrefs.GetInt("Money", 0);
        money.text = currentMoney.ToString();
           

        loadEsteet();
	}

    void loadEsteet()
    {
        
        //Debug.Log(esteet.transform.childCount);

        for (int i = 0; i < 5; i++)
        {
            Transform pos = (esteet.transform.GetChild(esteet.transform.childCount - 2).GetChild(0).transform);
            Debug.Log(esteet.transform.GetChild(esteet.transform.childCount - 2).GetChild(0).name);
            int r = Random.Range(1, 8);
            float r2 = Random.Range(-2, 2);

            (Instantiate(Resources.Load("Prefabs/Level001/Este" + r), new Vector2(0.7f, (pos.transform.position.y)+4), Quaternion.identity) as GameObject).transform.parent = esteet.transform;

            (Instantiate(Resources.Load("Prefabs/kolikkoryhmä"), new Vector2(r2, (pos.transform.position.y) + 6), Quaternion.identity) as GameObject).transform.parent = esteet.transform;
        }
    }
}
