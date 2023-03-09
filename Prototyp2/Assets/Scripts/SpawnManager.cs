using UnityEngine;

public class SpawnManager:MonoBehaviour {

	// creates an animal prefab in the GameManager inspector ready to add the elements
	// then drag and drop animals into each element
	[SerializeField] private GameObject[] animalPrefab;
	private float spawnRangeX = 20.0f;
	private float spawnRangeZ = 13.0f;
	private float spawnStartDelay = 2.0f;
	private float spawnInterval = 1.5f;

	// Start is called before the first frame update
	void Start() {

		InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update() {
	}

	private void SpawnRandomAnimal() {

		// makes animalIndex random between 0 and the lenth of the animalPrefab array[]
		int animalIndex = Random.Range(0, animalPrefab.Length);
		Vector3 spawnPos = new(Random.Range(spawnRangeX, -spawnRangeX), 0, spawnRangeZ);
		// spawns in the animals
		Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);

	}

}


