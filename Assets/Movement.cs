﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Movement : MonoBehaviour
{
    private int speed = 5;
    private Rigidbody rb;
    private Vector3 movement;
    private bool move;

    public bool usingTracker = false;

    private Transform tracker;
    private Transform sitSki; 

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        tracker = transform.Find("Tracker");
        sitSki = transform.Find("SitSki");

        if (!sitSki)
            Debug.Log("CAN'T FIND SITSKI");
    }

    void Update()
    {

        if(!usingTracker)
        {
            SteamVR_Action_Boolean forward = SteamVR_Actions._default.forward;
            move = forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand);
            movement = Camera.main.transform.forward;

            sitSki.rotation = Quaternion.FromToRotation(sitSki.rotation.eulerAngles, Camera.main.transform.forward);
            //Vector3 rotation = sitSki.eulerAngles;
            //rotation.z += 180;
            //sitSki.rotation = Quaternion.Euler(rotation);

            if (forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand))
                //    //transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
                //rb.MovePosition(transform.position + Camera.main.transform.forward * speed * Time.deltaTime);
                rb.AddForce(Camera.main.transform.forward * speed);
        }

        else
        {
            Debug.Log(tracker.eulerAngles.x);
        }
        
    }

    //private void FixedUpdate()
    //{
    //    if(move)
    //        moveCharacter(movement);
    //}

    //void moveCharacter(Vector3 direction)
    //{
    //    rb.velocity = direction * speed;
    //}
}
