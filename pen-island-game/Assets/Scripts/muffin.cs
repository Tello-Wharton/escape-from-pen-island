using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muffin : MonoBehaviour {

	public void loadScene()
	{ SceneManager.LoadScene("Start Screen", LoadSceneMode.Single);
	}
}
