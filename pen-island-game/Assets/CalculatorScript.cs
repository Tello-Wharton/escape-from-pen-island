using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorScript : MonoBehaviour, IKillable
{

    Animator animator;
    float speed = 0f;//6f;
    Mesh myMesh;

    // Use this for initialization
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        animator.speed = speed / (10f * transform.localScale.x);
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

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        int i = 0;
        while (i < vertices.Length)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time);
            i++;
        }
        mesh.vertices = vertices;

        myMesh = mesh;

    }

    public void Shot()
    {
        print("SHOT!");
    }

    void OnTriggerEnter(Collider collider)
    {

        print("Called! YAY!");

        if(collider.gameObject.tag == "Bullet")
        {
            print("Kill ME");
            Destroy(gameObject);

        }
    }

}
