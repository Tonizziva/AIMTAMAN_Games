using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour {
    public GameObject esteet;
    public GameObject kolikot;
    public Transform pos;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        Debug.Log(col.gameObject.transform.parent.parent.childCount);
        Debug.Log(col.gameObject.transform.parent.parent.GetChild(col.gameObject.transform.parent.parent.childCount - 2).transform.position);
        pos = col.gameObject.transform.parent.parent.GetChild(col.gameObject.transform.parent.parent.childCount - 2).transform;
        if (col.gameObject.transform.parent.tag.Equals("spawn"))
        {
            Debug.Log("poistettiin este1");
            loadEsteet();
        }
    Destroy(col.gameObject);
        
    }

    void loadEsteet()
    {
        for (int i = 0; i < 1; i++)
        {
            int r = Random.Range(1, 8);
            float r2 = Random.Range(-2, 2);

            (Instantiate(Resources.Load("Prefabs/Level001/Este" + r), new Vector2(0.7f, (pos.transform.position.y) + 3), Quaternion.identity)
                as GameObject).transform.parent = esteet.transform;

            (Instantiate(Resources.Load("Prefabs/kolikkoryhmä"), new Vector2(r2, (pos.transform.position.y) + 4), Quaternion.identity)
                as GameObject).transform.parent = esteet.transform;
        }
    }
}
