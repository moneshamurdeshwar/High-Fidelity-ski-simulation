using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Movement : MonoBehaviour
{
    private int speed = 15;
    private Rigidbody rb;
    private Vector3 movement;
    private bool move;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {

        SteamVR_Action_Boolean forward = SteamVR_Actions._default.forward;
        move = forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand);
        movement = Camera.main.transform.forward;

        if (forward.GetLastState(SteamVR_Input_Sources.LeftHand) || forward.GetLastState(SteamVR_Input_Sources.RightHand))
            //    //transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
            //rb.MovePosition(transform.position + Camera.main.transform.forward * speed * Time.deltaTime);
            rb.AddForce(Camera.main.transform.forward * speed);

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
