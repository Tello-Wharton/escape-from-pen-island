using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HexastickScript : MonoBehaviour {

	void onTriggerEnter (Collider collider) {
		if (collider.gameObject.tag == "Player")
			SceneManager.LoadScene ("End Screen", LoadSceneMode.Single);
			
	}
	
}
