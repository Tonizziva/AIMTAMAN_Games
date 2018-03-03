using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tulos : MonoBehaviour {
	public Text text;
    public Text hscore;
    int tulos;

	// Use this for initialization
	void Start () { 
		tulos = Counter.tulos;
        if (PlayerPrefs.GetInt("Highscore", 0)  <= tulos)
        {
            PlayerPrefs.SetInt("Highscore", tulos);
        }
        text.text = tulos.ToString();
        hscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
