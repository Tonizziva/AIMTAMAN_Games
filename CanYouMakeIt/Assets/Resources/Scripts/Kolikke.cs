using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kolikke : MonoBehaviour {
	Text money;

	void Start() {
		money = GameObject.Find ("Money").GetComponent<Text> ();
		//currentMoney = PlayerPrefs.GetInt ("Money", 0);
		//money.text = currentMoney.ToString();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "dot") {
			LevelEditor.currentMoney = LevelEditor.currentMoney + 1;
			money.text = LevelEditor.currentMoney.ToString ();
			Destroy (gameObject); 
		} else if(col.gameObject.tag == "remove"){
			Destroy (gameObject.transform.parent.gameObject);
		} else
        {
            Destroy(gameObject);
        }
	}
}