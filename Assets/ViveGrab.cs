using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ViveGrab : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        Debug.Log(getTrackPadPos());

    }

    public Vector2 getTrackPadPos()
    {
        SteamVR_Action_Vector2 trackpadPos = SteamVR_Actions._default.touchpos;

        return trackpadPos.GetAxis(SteamVR_Input_Sources.LeftHand);
    }

}