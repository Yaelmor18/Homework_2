using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody playerRigidbody;
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float playerRotateSpeed;

    [SerializeField] Camera mainCamera;

    Vector3 moveDirection;
    Vector3 rotationDirection;

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rotationDirection = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        mainCamera.transform.Rotate(Input.GetAxis("Mouse Y") * -playerRotateSpeed * Time.deltaTime, 0, 0);
    }
    
    private void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    { 
        // Movement handling
        playerRigidbody.MovePosition(playerRigidbody.position + playerMoveSpeed * Time.deltaTime * transform.TransformDirection(moveDirection));
    }

    private void Rotation()
    {
        // Rotation handling
        Quaternion deltaRotation = Quaternion.Euler(rotationDirection * Time.fixedDeltaTime * playerRotateSpeed);
        playerRigidbody.MoveRotation(playerRigidbody.rotation * deltaRotation);
    }
}
