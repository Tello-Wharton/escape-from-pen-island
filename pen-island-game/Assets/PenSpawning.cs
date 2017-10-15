﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenSpawning : MonoBehaviour {

    float count;


    public GameObject penPrefab;

    // Use this for initialization
    void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {

        count += Time.deltaTime;

        if (count > 1){

            count = 0;

            var range = 100f;
            Vector3 offset = new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));

            var pen = (GameObject)Instantiate(
            penPrefab,
            transform.position + offset,
            transform.rotation);
        }
		
	}
}
