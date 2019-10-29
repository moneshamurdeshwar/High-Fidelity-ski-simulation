using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ViveGrab : MonoBehaviour
{

    private Hand hand;

    // Use this for initialization
    void Start()
    {
        hand = gameObject.GetComponent<Hand>();
    }

    public Vector2 getTrackPadPos()
    {
        SteamVR_Action_Vector2 trackpadPos = SteamVR_Actions._default.touchpos;

        Debug.Log(trackpadPos.GetAxis(hand.handType));
        return trackpadPos.GetAxis(hand.handType);
    }

}