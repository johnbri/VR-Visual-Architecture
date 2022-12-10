using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragRotate : MonoBehaviour
{  
Camera cam;
public LayerMask mask;
Vector3 mPrevPos = Vector3.zero;
Vector3 mPosDelta = Vector3.zero;

void Start() {
    cam = Camera.main;
}
void Update () {

    // Raycast delen

    Vector3 mousePos = Input.mousePosition;
    mousePos.z = 100f;
    mousePos = cam.ScreenToWorldPoint(mousePos);

    

    if (Input.GetMouseButton(0)) 
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100, mask))
        {
        mPosDelta = Input.mousePosition - mPrevPos;
        hit.transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, cam.transform.right)*0.1f, Space.World);

        }

       
    }
    mPrevPos = Input.mousePosition;
 }   
}