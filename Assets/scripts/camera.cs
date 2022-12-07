using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
    public float MaximoX;
    public float MinimoX;
    public float MaximoY;
    public float MinimoY;
    public float timeLerp;

    private void FixedUpdate()
    {
        Vector3 newPosition = player.position + new Vector3(0, 0, -11);
        newPosition.y = 0.1f;
        newPosition = Vector3.Lerp(transform.position, newPosition, timeLerp);
        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, MinimoX, MaximoX), transform.position.y, transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.y, MinimoY, MaximoY), transform.position.x, transform.position.z);
    }
}
       

