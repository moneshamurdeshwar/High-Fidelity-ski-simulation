using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Movement : MonoBehaviour
{
    private int speed = 5;

    void Start()
    {

    }

    void Update()
    {

        SteamVR_Action_Boolean forward = SteamVR_Actions._default.forward;

        if (forward.GetLastState(SteamVR_Input_Sources.LeftHand))
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

    }
}
