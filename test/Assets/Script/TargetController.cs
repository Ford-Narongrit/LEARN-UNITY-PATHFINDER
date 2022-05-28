using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Camera mainCamera;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                gameObject.transform.position = hit.point;
            }
        }
    }
}
