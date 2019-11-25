using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

/*
 * Is something wrong?
 * 
 * - Physics: make sure camera rig's mass is 0.3 and drag is 1.0
 * - Tracker: set device index to 5
 */

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

        Quaternion newRotation = Quaternion.FromToRotation(sitSki.rotation.eulerAngles, Camera.main.transform.forward);
        Vector3 oldRotation = sitSki.rotation.eulerAngles;
        oldRotation.y = Camera.main.transform.rotation.y;
        //sitSki.rotation = Quaternion.Euler(oldRotation);

        if (!usingTracker)
        {
            SteamVR_Action_Boolean forward = SteamVR_Actions._default.forward;
           // move = forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand);
           // movement = Camera.main.transform.forward;

            //sitSki.rotation = Quaternion.FromToRotation(sitSki.rotation.eulerAngles, Camera.main.transform.forward);
            //Vector3 rotation = sitSki.eulerAngles;
            //rotation.z += 180;
            //sitSki.rotation = Quaternion.Euler(rotation);

            if (forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand))
                //    //transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
                //rb.MovePosition(transform.position + Camera.main.transform.forward * speed * Time.deltaTime);
                rb.AddForce(Camera.main.transform.forward * speed);
        }

        //Use X-axis for movement: 90 degrees is all the way forward, 270 degrees is all the way back.
        //Put the tracker on the person with "BEN!" facing the ceiling to orient properly.
        else
        {
            Debug.Log(tracker.eulerAngles.x);

            float angle = tracker.eulerAngles.x;

            if (angle > 260)
                angle = 0;
            else if (angle > 45)
                angle = 45;

            //Debug.Log(angle);

            float force = 0 + (angle - 0) * (1 - 0) / (45 - 0);
            force *= speed;

            rb.AddForce(Camera.main.transform.forward * force);
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
