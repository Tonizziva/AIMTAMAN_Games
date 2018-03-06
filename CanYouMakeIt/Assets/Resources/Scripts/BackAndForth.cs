using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour {
	public float max;
	public float min;
    // Use this for initialization
    void Start () {
       
        min=transform.position.x-1.5f;
        max=transform.position.x+4.5f;
   
    }
   
    // Update is called once per frame
    void Update () {
        transform.position =new Vector3(Mathf.PingPong(Time.time*7,max-min)+min, transform.position.y, transform.position.z);
    }
}
