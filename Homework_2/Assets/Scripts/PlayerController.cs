using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody playerRigidbody;
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float playerRotateSpeed;
    [SerializeField] Animator animator;


    [SerializeField] Camera mainCamera;

    Vector3 moveDirection;
    Vector3 rotationDirection;

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rotationDirection = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        mainCamera.transform.eulerAngles += new Vector3(Mathf.Clamp(Input.GetAxis("Mouse Y") * -playerRotateSpeed * Time.deltaTime, -90f, 90f), 0, 0);
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
        if(moveDirection != Vector3.zero)
        animator.SetBool("IsWallking", true);
        else
        animator.SetBool("IsWallking", false);

    }

    private void Rotation()
    {
        // Rotation handling
        Quaternion deltaRotation = Quaternion.Euler(rotationDirection * Time.fixedDeltaTime * playerRotateSpeed);
        playerRigidbody.MoveRotation(playerRigidbody.rotation * deltaRotation);
    }
}
