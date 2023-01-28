using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent_Script : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] GameObject GunPivot;
    // Start is called before the first frame update
    private void Update()
    {
       GunPivot.transform.LookAt(playerTransform);
    }
}
