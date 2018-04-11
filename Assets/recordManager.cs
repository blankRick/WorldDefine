using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordManager : MonoBehaviour {

    // Use this for initialization
    public bool isRecording;
    void Start()
    {
        isRecording = false;
    }
    public void ToggleRecord()
    {
        isRecording = !isRecording;
    }
}
