using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public GameObject ball;		
	
	
	void Start ()
	{
		spawnDelay = Random.Range (2f, 6f);
		spawnTime = Random.Range (2f, 7f);
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	
	void Spawn ()
	{
		// Instantiate a random enemy.
		Instantiate(ball, transform.position, transform.rotation);
		

	}
	
}

