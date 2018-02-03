using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update ()
	{
		transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 6), transform.position.z);
	}

}

