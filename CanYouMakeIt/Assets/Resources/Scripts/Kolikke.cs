using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kolikke : MonoBehaviour {
	public Text money;
	public static int currentMoney = 0;

	void Start() {
		money.text = currentMoney.ToString();
	}

	void OnTriggerEnter2D (Collider2D col) {
		currentMoney = currentMoney + 1;
		money.text = currentMoney.ToString();
		Destroy (gameObject); 
	}
}