using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballGen : MonoBehaviour {
    public Transform ball;
    public float range = 0.1f;
    bool stop = false;
	// Use this for initialization
	void Start () {
        InvokeRepeating("ballGenenrator", 0.01f, 1f);
    }
    void ballGenenrator()
    {
        if (!stop)
        {
            Vector3 initial = new Vector3(Random.Range(-range, range), 10, Random.Range(-range, range));/*
        if (Random.Range(0.0f, 1.0f) >= 0.5f)
            initial.x = 0;
        else
            initial.z = 0;*/
            Transform g = Instantiate(ball);
            g.transform.position = initial;
            g.parent = transform;
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
            stop = !stop;
	}
}
