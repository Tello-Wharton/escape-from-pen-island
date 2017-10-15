using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints; // The parent of the spawn points
	public GameObject landingAreaPrefab;

	private bool reSpawn = false;
	private Transform[] spawnPoints;
	private bool lastRespawnToggle = false;

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();

    }
	
	// Update is called once per frame
	void Update () {
		if (lastRespawnToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastRespawnToggle = reSpawn;
		}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

    }

    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 20;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }

    private void Respawn() {
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

	void OnFindClearArea () {
		Invoke ("DropFlare", 3f);
	}

	void DropFlare () {
		Instantiate (landingAreaPrefab, transform.position, transform.rotation);
	}

}
