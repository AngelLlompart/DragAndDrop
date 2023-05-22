using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPointToRay : MonoBehaviour
{

    [SerializeField] private GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mouseScreenPos);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);

        if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
            {
                Instantiate(cubePrefab, hit.point, Quaternion.identity);
            }   
        }
        
    }
}
