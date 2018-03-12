using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour {
    public GameObject esteet;
    public GameObject kolikot;
    Transform pos;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.gameObject.tag.Equals("spawn"))
        {
            Debug.Log(col.gameObject.name);
            Debug.Log("poistettiin este1");
            Destroy(col.transform.parent.gameObject);
            loadEsteet(col.gameObject);
        }
    }

    void loadEsteet(GameObject col)
    {
        int r = Random.Range(1, 8);
        float r2 = Random.Range(-2, 2);

        pos = col.gameObject.transform.parent.parent.GetChild(col.gameObject.transform.parent.parent.childCount - 1).GetChild(0).transform; 

        (Instantiate(Resources.Load("Prefabs/Level001/Este" + r), new Vector2(0.7f, (pos.transform.position.y)+4), Quaternion.identity) as GameObject).transform.parent = esteet.transform;

        Debug.Log("Spawnatun objectin paikka");
        Debug.Log(col.gameObject.transform.parent.parent.GetChild(col.gameObject.transform.parent.parent.childCount - 2).transform.position);
        Debug.Log("--------------------------------------------------------");

        //(Instantiate(Resources.Load("Prefabs/kolikkoryhmä"), new Vector2(r2, (pos.transform.position.y) +4), Quaternion.identity) as GameObject).transform.parent = esteet.transform;
    }
}
