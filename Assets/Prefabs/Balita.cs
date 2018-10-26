using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balita : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0, Time.deltaTime * 10.0f, 0);
	}
}
