using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallProducer : MonoBehaviour {
    public int size_h = 31;
    public float width = 1;
    public float height = 1;
    public Transform wall;
    public Transform collector;
    public Vector3 scale = new Vector3(0.3f, 0.3f, 0.3f);
    float buttom = 0;
	// Use this for initialization
	void Start () {
        wall.localScale = scale;
        for (int h = 0; h <= size_h; h++)
        {
            float n = h;    //((float)h - 1) / 2;
            for (float x = -n; x <= n; x+=1)
            {
                if (x < 0)
                {
                    for (float y = 0; y <= n+x; y+=1)
                    {
                        instantiate(new Vector3(x * width, -h * height, y * width));
                        instantiate(new Vector3(x * width, -h * height, -y * width));
                    }
                }
                else
                {
                    for (float y = 0; y <= n - x; y += 1)
                    {
                        instantiate(new Vector3(x * width, -h * height, y * width));
                        instantiate(new Vector3(x * width, -h * height, -y * width));
                    }
                }
            }
        }
        buttom = -size_h * width-30;
        float k = size_h + 0.5f;
        for (float x = -size_h*1.5f; x < size_h * 1.5f; x++)
        {
            Transform g = Instantiate(collector);
            g.transform.parent = transform;
            g.transform.position = new Vector3(x * width, buttom, 0);
            g.localScale = new Vector3(0.01f, 50, 80);
            g = Instantiate(collector);
            g.transform.parent = transform;
            g.transform.position = new Vector3(0, buttom, x * width);
            g.localScale = new Vector3(80, 50, 0.01f);
        }
    }
	void instantiate(Vector3 p)
    {
        Transform g = Instantiate(wall);
        g.transform.parent = transform;
        g.transform.position = p;
        g.transform.localScale = scale;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
