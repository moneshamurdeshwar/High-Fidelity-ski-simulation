using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Movement : MonoBehaviour
{
    private Vector3 movementVector;
    private GameObject characterController;
    private int speed = 1;

    void Start()
    {
        characterController = GameObject.FindGameObjectWithTag("Player");
    }

    private void Move()
    {
        characterController.transform.position = movementVector * Time.deltaTime;
    }

    void Update()
    {

        SteamVR_Action_Boolean forward = SteamVR_Actions._default.forward;

        if (forward.GetLastState(SteamVR_Input_Sources.LeftHand))
            transform.position = transform.position + Camera.main.transform.forward * 10 * Time.deltaTime;

        //if (forward.GetLastState(SteamVR_Input_Sources.LeftHand))
        //    //movementVector.x *= speed;
        //    characterController.transform.position = new Vector3(characterController.transform.position.x + 1, characterController.transform.position.y, characterController.transform.position.z);

        //Move();

        //movementVector.x = Input.GetAxis("LeftJoystickX") * -speed;
        //movementVector.z = Input.GetAxis("LeftJoystickY") * speed;

        //movementVector.y = 0;
        //characterController.Move(movementVector * Time.deltaTime);

    }
}
