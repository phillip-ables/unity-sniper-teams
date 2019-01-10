﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
    public float speed = 6.0f;

    private CharacterController _charCont;

    private void Start()
    {
        _charCont = FindObjectOfType<CharacterController>();
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charCont.Move(movement);
    }
}
