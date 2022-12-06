using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botaoesquerdo : MonoBehaviour
{
    public Camera cam;
    public bool BEsquerdoInteragir;
    public LayerMask InteracaoLayer;
    public float radius;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(point.x, point.y, transform.position.z);
        }
    }
    private void FixedUpdate()
    {
        Interact();
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, InteracaoLayer);

        if (hit != null)
        {
            BEsquerdoInteragir = true;
        }
        else
        {
            BEsquerdoInteragir = false;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
