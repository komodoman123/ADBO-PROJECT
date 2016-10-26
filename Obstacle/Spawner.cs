using UnityEngine;
using System.Collections;

public abstract class Spawner : MonoBehaviour {

	public GameObject[] obstacleDay;
	public GameObject[] obstacleNight;
	protected GameObject[] obstacle;
	public bool isNight;
	protected GameObject spawnedObstacle;
	float spawnTimer;
	//Masih nyari cara supaya ga ada nisan + burung sekaligus
	//Ato mau bisa ada nisan + burung sekaligus aja biar gelo?

	/*Spawner(){
		this.obstacleDay = new GameObject[10];
		this.obstacleNight = new GameObject[10];
	}*/

	void Start(){
		this.spawnTimer = Random.Range(0.5f,1f);
	}

	protected void SpawnObstacle(){
		spawnedObstacle = Instantiate (obstacle [0], transform.position, transform.rotation) as GameObject;
		spawnedObstacle.name = "obs";
		spawnedObstacle.transform.position = this.transform.position;
	}

	protected void FixedUpdate(){
		spawnTimer -= Time.deltaTime;
		if (spawnTimer <= 0) {
			this.SpawnObstacle ();
			spawnTimer = Random.Range(0.5f, 1f);
		}
	}
	protected void setObstacle(){
		if (isNight) {
			obstacle = obstacleNight;
		} else {
			obstacle = obstacleDay;
		}
	}
}
