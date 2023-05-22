using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = 7.5f;
        Vector3 rayOrigin = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        Vector3 rayDirection = Vector3.forward;
        Ray ray = new Ray(rayOrigin, rayDirection);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            Debug.Log(rayOrigin);
            if (Physics.Raycast(rayOrigin, rayDirection, out RaycastHit hit))
            {
                if (hit.transform.CompareTag("Sphere"))
                {
                    hit.transform.gameObject.transform.position = rayOrigin;
                }
            }
        }
    }
}
