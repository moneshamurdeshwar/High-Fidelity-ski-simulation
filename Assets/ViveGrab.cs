using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // I was looking at this tutorial (https://circuitstream.com/blog/required-vive-code/) to figure out how to get the touchpad input, but it seems outdated.
    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller

    {

        get

        {

            return SteamVR_Controller.Input((int)trackedObj.index);

        }

    }

    void Awake()

    {

        trackedObj = GetComponent();

    }
}
