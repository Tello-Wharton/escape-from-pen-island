using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {

	public void loadScene ()
	{ SceneManager.LoadScene("Game", LoadSceneMode.Additive);
	}
}
