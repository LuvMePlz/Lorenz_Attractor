using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lorenz : MonoBehaviour
{
    Debug.Log("123");
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double x = 0;
        double y = 0;
        double z = 0;
        double a = 10;
        double b = 28;
        double c = 8 / 3;
        //double t = 0.01;
        int iterations = 100;

        for (int i = 0; i < iterations; i++)
        {
            double xt = x + (a * (y - x));
            double yt = y + (x * (b - z) - y);
            double zt = z + (x * y - c * z);
            x = xt;
            y = yt;
            z = zt;

            var vect = new Vector3((float)x, (float)y, (float)z);
            transform.position = vect;
        }
    }
}
