using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var player = GameObject.Find("Player");

        var heading = player.transform.position - transform.position;

        var direction = heading / heading.magnitude;

        transform.Translate(direction * Time.deltaTime * 4);

		
	}
}
