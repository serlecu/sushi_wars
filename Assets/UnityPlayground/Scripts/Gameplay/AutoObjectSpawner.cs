﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Auto Object Spawner")]
[RequireComponent(typeof(BoxCollider2D))]
public class AutoObjectSpawner : MonoBehaviour
{
	[Header("Object creation")]

	// The object to spawn
	// WARNING: take if from the Project panel, NOT the Scene/Hierarchy!
	public GameObject prefabToSpawn;

	[Header("Other options")]

	// Configure the spawning pattern
	public float spawnInterval = 1;

	//private BoxCollider2D boxCollider2D;

	void Start ()
	{
		//boxCollider2D = GetComponent<BoxCollider2D>();

		StartCoroutine(SpawnObject());
	}
	
	// This will spawn an object, and then wait some time, then spawn another...
	IEnumerator SpawnObject ()
	{
		while(true)
		{
			// Create some random numbers
			//float randomX = Random.Range (-boxCollider2D.size.x, boxCollider2D.size.x) *.5f;
			//float randomY = Random.Range (-boxCollider2D.size.y, boxCollider2D.size.y) *.5f;

			// Generate the new object
			GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
			newObject.transform.position = new Vector2(this.transform.position.x,this.transform.position.y);
			newObject.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);

			//APARECEN EN UN RANGO ALEATORIO
			//newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
		
			//GameObject newObject = Instantiate(prefabToSpawn, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			//newObject.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);

			// Wait for some time before spawning another object
			yield return new WaitForSeconds(spawnInterval);
		}
	}
}
