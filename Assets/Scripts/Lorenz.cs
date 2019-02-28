using System;
using UnityEngine;

public class Lorenz : MonoBehaviour
{
    float x = 0.1f;
    float y = 0;
    float z = 0;
    float a = 10;
    float b = 28;
    float c = 8 / 3;
    float t = 0.01f;
    int iterations = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TATATA");
    }

    // Update is called once per frame
    void Update()
    {
        float xt = x + t * (a * (y - x));
        float yt = y + t * (x * (b - z) - y);
        float zt = z + t * (x * y - c * z);
        x = xt;
        y = yt;
        z = zt;
        Debug.Log(x.ToString() + " ; " + y.ToString() + " ; " + z.ToString());
        var vect = new Vector3(x, y, z);
        transform.position = vect;
        //for (int i = 0; i < iterations; i++)
        //{
        //}
    }
}
