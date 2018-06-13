using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

	private BoxCollider2D boxCollider2D;

	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3; 
	public Sprite sprite4;
	List<Sprite> sprites = new List<Sprite>(){};


	void Start ()
	{
		boxCollider2D = GetComponent<BoxCollider2D>();

		sprites.Add (sprite1);
		sprites.Add (sprite2);
		sprites.Add (sprite3);
		sprites.Add (sprite4);

		StartCoroutine(SpawnObject());


	}
	
	// This will spawn an object, and then wait some time, then spawn another...
	IEnumerator SpawnObject ()
	{
		while(true)
		{
			// Create some random numbers
			float randomX = Random.Range (-boxCollider2D.size.x, boxCollider2D.size.x) *.5f;
			float randomY = Random.Range (-boxCollider2D.size.y, boxCollider2D.size.y) *.5f;
			int randomS = Random.Range (0, 3);
			// Generate the new object
			//GameObject newObject = Instantiate<GameObject>(prefabToSpawn);
			GameObject newObject = Instantiate(prefabToSpawn, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			//Seleccionar el sprite
			newObject.GetComponent<SpriteRenderer>().sprite = sprites[randomS];
			//Hacer el parentesco con "Canvas"
			newObject.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
			//Aparecen dentro del collider
			newObject.transform.position = new Vector2(randomX + this.transform.position.x, randomY + this.transform.position.y);
			//Aparecen en el sitio
			//newObject.transform.position = new Vector2(this.transform.position.x,this.transform.position.y);
			//



			// Wait for some time before spawning another object
			yield return new WaitForSeconds(spawnInterval);
		}
	}
}
