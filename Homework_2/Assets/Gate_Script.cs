using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Script : MonoBehaviour
{
    [SerializeField] Animator animator;

    private void OpenGate()
    {
        animator.enabled = true;
    }
}
