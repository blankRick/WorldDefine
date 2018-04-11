using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeControl : MonoBehaviour {

    // Use this for initialization
    public void increaseSize(float val)
    {
        Debug.Log(val);
        GetComponent<Transform>().localScale = new Vector3(2.1f*val, GetComponent<Transform>().localScale.y, 1);

    }
}
