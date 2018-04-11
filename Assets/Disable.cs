using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour {

    // Use this for initialization
    public GameObject nextobj;
	void Start()
    {
        StartCoroutine(disable());
    }
	
	IEnumerator disable()
    {
        yield return new WaitForSeconds(5);
        if (nextobj != null)
        {
            nextobj.gameObject.SetActive(true);
        }

        this.gameObject.SetActive(false);
    }
}
