using UnityEngine;
using System.Collections;

//Movement prefab nisan
public class MovementNisan : movement{

	void Start () {
		ObstaclePrefab = GameObject.FindGameObjectWithTag ("Obstacle");
		initialPos = transform.position;
	}
}