using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kolikke : MonoBehaviour {
	Text money;
	public static int currentMoney = 0;

	void Start() {
		money = GameObject.Find ("Money").GetComponent<Text> ();
		//currentMoney = PlayerPrefs.GetInt ("Money", 0);
		//money.text = currentMoney.ToString();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "dot") {
			currentMoney = currentMoney + 1;
			money.text = currentMoney.ToString ();
			Destroy (gameObject); 
		} else if(col.gameObject.tag == "remove"){
			Destroy (gameObject.transform.parent.gameObject);
		} else
        {
            Destroy(gameObject);
        }
	}
}