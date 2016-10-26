using UnityEngine;
using System.Collections;

public class NisanSpawner : Spawner {

	NisanSpawner(){
		this.obstacleDay = new GameObject[10];
		this.obstacleNight = new GameObject[10];
	}
	void Start () {
		this.setObstacle ();
	}
}
