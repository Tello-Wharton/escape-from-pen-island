using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class biscuit : MonoBehaviour {

    public void loadScene()
    {
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }
}
