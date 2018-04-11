using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateMarker : MonoBehaviour {

    // Use this for initialization
    public Transform t1;
    public Transform t2;
    public Transform t3;

    public void translate(float val)
    {
        if (val == 1)
        {
            transform.position = t3.position;
        }
        else
        {
            transform.position = t1.position + val * (t2.position - t1.position);
        }
    }
}
