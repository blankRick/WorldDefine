using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlForce : MonoBehaviour {

    // Use this for initialization
    public GameObject activateText;
    void Start()
    {

    }
    public void increaseForce(float val)
    {
        Debug.Log(val);
        if(val == 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(4, 0, 0);
            activateText.SetActive(true);
        }
        
    }
}
