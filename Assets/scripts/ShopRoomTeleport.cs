using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopRoomTeleport : MonoBehaviour
{
	private Transform destination;

	public bool teleport2;
	public float distance = 0.2f;

	void Start()
	{
		if (teleport2 == true)
		{
			destination = GameObject.FindGameObjectWithTag("teleport1").GetComponent<Transform>();
		}

		else

		{
			destination = GameObject.FindGameObjectWithTag("teleport2").GetComponent<Transform>();
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (Vector2.Distance(transform.position, other.transform.position) > distance)
		{
			other.transform.position = new Vector2 (destination.position.x, destination.position.y);
		}
	}
}