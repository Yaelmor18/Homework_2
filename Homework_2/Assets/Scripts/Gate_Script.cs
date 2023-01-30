using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Script : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void Start()
    {
    }
    private void OpenGate()
    {
        animator.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        EventManager.openGateEvent += OpenGate;
    }
}
