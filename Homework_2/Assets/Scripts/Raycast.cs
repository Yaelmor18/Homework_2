using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [Header("Raycast")]
    [SerializeField] Camera mainCamera;
    [SerializeField] LayerMask raycastLayerMask;

    Vector2 mousePosition;
    Ray ray;
    bool hitDetected = false;
    void Update()
    {
        HandleRaycast();
    }

    void HandleRaycast()
    {
        mousePosition = Input.mousePosition;

        RaycastHit raycastHit;
        ray = mainCamera.ScreenPointToRay(mousePosition);
        if (hitDetected = Physics.Raycast(ray, out raycastHit, maxDistance: 50f, raycastLayerMask))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(raycastHit.collider.gameObject);
            }
        }
    }
    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            ray = mainCamera.ScreenPointToRay(mousePosition);
            Gizmos.DrawRay(ray.origin, ray.direction * 50f);

            Gizmos.DrawSphere(transform.position, 1f);
        }
    }
}
