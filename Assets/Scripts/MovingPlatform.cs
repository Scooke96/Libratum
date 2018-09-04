using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public Transform[] Points;

	public int 
	destinationPoint;

	public float
	speed = 3,
	step,
	distance;

	// Use this for initialization
	void Start () 
	{
		distance = Vector3.Distance (transform.position, Points[destinationPoint].position);
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		step = speed * Time.deltaTime;

		distance = Vector3.Distance (transform.position, Points [destinationPoint].position);

		if (distance <= 0.1f) 
		{
			destinationPoint = destinationPoint >= Points.Length - 1 ? 0 : destinationPoint + 1;
		}

		transform.position = Vector3.MoveTowards (transform.position, Points [destinationPoint].position, step);
	}
}
