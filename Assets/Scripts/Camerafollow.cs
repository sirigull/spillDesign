﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour {
	[SerializeField]
	private Transform target;
	[SerializeField]
	public float cameraSpeed;

	[SerializeField]
	public float yMax;
	[SerializeField]
	private float xMax;
	[SerializeField]
	private float yMin;
	[SerializeField]
	private float xMin;


	void FixedUpdate()
	{
		
	}
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Player").transform;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(target != null){
			var newPos = Vector2.Lerp(transform.position, target.position, Time.deltaTime*cameraSpeed);
			var vect3 = new Vector3(newPos.x, newPos.y, - 10f);
			var clampX = Mathf.Clamp(vect3.x, xMin,xMax);
			var clampY = Mathf.Clamp(vect3.y, yMin, yMax);
		
		transform.position = new Vector3(clampX,clampY,-10f);
		}
	}
}
