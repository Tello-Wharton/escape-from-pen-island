using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen1Script : MonoBehaviour {

    Animator animator;
    float speed = 12f;

    // Use this for initialization
    void Start () {
        animator = gameObject.GetComponent<Animator>();
        
        animator.speed = (speed / (10f * transform.localScale.x));
    }
	
	// Update is called once per frame
	void Update () {

        var player = GameObject.Find("Player");

        var heading = player.transform.position - transform.position;
        var direction = heading / heading.magnitude;
        var cake = Quaternion.LookRotation(direction);

        transform.rotation = (cake);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);


		
	}
}
