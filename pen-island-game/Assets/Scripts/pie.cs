using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pie : MonoBehaviour {

	public void loadScene()
	{ SceneManager.LoadScene("Tips", LoadSceneMode.Single);
	}
}