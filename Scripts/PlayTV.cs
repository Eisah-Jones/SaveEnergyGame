﻿using UnityEngine;
using System.Collections;

public class PlayTV : MonoBehaviour {

	// Use this for initialization
	void Start () {
		((MovieTexture)GetComponent<Renderer> ().material.mainTexture).loop = true;
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
}
