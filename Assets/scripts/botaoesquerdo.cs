using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botaoesquerdo : MonoBehaviour
{
    public Camera cam;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(point.x, point.y, transform.position.z);
        }
    }
}
