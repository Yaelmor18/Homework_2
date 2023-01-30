using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public delegate void OpenGateDelegate();
    public static event OpenGateDelegate openGateEvent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (openGateEvent == null) { return; }
        openGateEvent();
    }
}
