﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//hello
public class cameraController : MonoBehaviour {
	public GameObject player;

	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset=transform.position-player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position=player.transform.position+offset;
	}
}
