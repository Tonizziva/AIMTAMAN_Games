using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor : MonoBehaviour {
	public GameObject este0;
	public GameObject este1;
	public GameObject este2;
	public GameObject este3;
	public GameObject este4;
	public GameObject este5;
	public GameObject esteet;
	public GameObject kolikot;

	// Use this for initialization
	void Start () {
		for (int i=0;i<60;i++) {
			int r = Random.Range (1, 8);
			float r2 = Random.Range (-2, 2);

			(Instantiate(Resources.Load("Prefabs/Este"+r),	new Vector2(0.7f, (i+1)*4), Quaternion.identity)
				as GameObject).transform.parent = esteet.transform;

			(Instantiate(Resources.Load("Prefabs/kolikkoryhmä"),	new Vector2(r2, (i+2)*4), Quaternion.identity)
				as GameObject).transform.parent = esteet.transform;
		}
	}
}
