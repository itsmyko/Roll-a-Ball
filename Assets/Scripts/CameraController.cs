﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// LateUpdate is run after Update is run, if at all
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
