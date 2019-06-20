using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballUpdate : MonoBehaviour {
    bool changed = false;
	// Use this for initialization
	void Start () {

        Debug.Log("yo");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 p = transform.position;
        Debug.Log(p.y);
        if (!changed && p.y <= -15)
        {
            changed = true;
            transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        }
	}
}
