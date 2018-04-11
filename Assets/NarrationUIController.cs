using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class NarrationUIController : MonoBehaviour, ITrackableEventHandler
{

    // Use this for initialization
    public GameObject[] zeroPanel;
    private TrackableBehaviour mTrackableBehaviour;
    private bool first;
    void Start()
    {
        first = true;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    // Update is called once per frame
    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
    {
        //Debug.Log("here");
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            //Debug.Log("here1");
            // Play audio when target is found
            if (first)
            {
                first = false;
                zeroPanel[0].SetActive(true);
                zeroPanel[1].SetActive(true);
            }
        }
    }
}
