using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PencilScript : MonoBehaviour {

    Animator animator;
    float speed = 6f;
    int lives;

    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.speed = speed / (10f * transform.localScale.x);

        lives = 10;
    }

    // Update is called once per frame
    void Update()
    {

        var player = GameObject.Find("Player");

        var heading = player.transform.position - transform.position;
        var direction = heading / heading.magnitude;
        var cake = Quaternion.LookRotation(direction);

        transform.rotation = (cake);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);



    }


    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Bullet")
        {
            if (lives < 0)
            {
                Destroy(gameObject);

            }
            else
            {
                lives -= 1;
            }

        }


        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
        }
    }

}
