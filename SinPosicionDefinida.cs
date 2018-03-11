using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SinPosicionDefinida : MonoBehaviour
{
//    private LinkedList<Random> xRandomList, yRandomList;
    public bool adentroDelRio;
    // Use this for initialization
    public void Start()
    {
        cambioDePosicionAletoria();
        rotacionAleatoria();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void cambioDePosicionAletoria()
    {
        float px, pz;
        do
        {
            px = UnityEngine.Random.Range(50.0f, 450.0f);
            pz = UnityEngine.Random.Range(50.0f, 450.0f);
        }
        while (!(dentroDelRio(px, pz) == adentroDelRio));
            this.transform.Translate(px, 13, pz, Space.World);
    }

    bool dentroDelRio(float x, float z)
    {
        if (x < 364 && x > 270 && z > 122 && z < 274)
        {
            return true;
        }
        else if (x < 216 && x > 159 && z > 123 && z < 162)
        {
            return true;
        }
        else if (x < 184 && x > 104 && z > 130 && z < 227)
        {
            return true;
        }
        else if (x < 371 && x > 216 && z > 114 && z < 285)
        {
            return true;
        }
        else if (x<=238 && x >= 0)
        {
            double valorzmax, valorzmin;
            valorzmax = -0.84 * x + 500;
            valorzmin = -0.88 * x + 420;
            if(z <= valorzmax && z >= valorzmin)
            {
                return true;
            }
        }
        return false;
    }
    void rotacionAleatoria()
    {
        float rot = UnityEngine.Random.Range(0f, 180f);
        this.transform.Rotate(0, 0, rot);
    }

}
