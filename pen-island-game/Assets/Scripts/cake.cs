using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cake : MonoBehaviour {

	public void loadScene()
	{ SceneManager.LoadScene("Game", LoadSceneMode.Additive);
	}
}
