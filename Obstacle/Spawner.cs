using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] obstacleDay;
	public GameObject[] obstacleNight;
	//Transisi siang malemnya nanti gimana?
	public GameObject[] obstacle;
	public bool isNight;
	public GameObject spawnedObstacle;
	//Kalo buat ngespawn dua obstacle urang ga tau

	Spawner(){
		this.obstacleDay = new GameObject[10];
		this.obstacleNight = new GameObject[10];
		if (isNight) {
			obstacle = obstacleNight;
		} else {
			obstacle = obstacleDay;
		}
	}

	void Start(){
		this.SpawnObstacle ();
	}

	public void SpawnObstacle(){
		spawnedObstacle = Instantiate (obstacle[Random.Range(0, obstacle.Length)], transform.position, transform.rotation) as GameObject;
		spawnedObstacle.name = "obs";
		//Prefab parentnya nanti dikasih tag "Obstacle"
		spawnedObstacle.transform.parent = GameObject.FindGameObjectWithTag("Obstacle").transform; 
		spawnedObstacle.transform.position = GameObject.FindGameObjectWithTag ("Obstacle").transform.position;
	}
}
