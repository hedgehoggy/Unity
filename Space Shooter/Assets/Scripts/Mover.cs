﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody> ().velocity = Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
