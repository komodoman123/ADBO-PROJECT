using UnityEngine;
using System.Collections;

/*
 * Turunan kelas movement buat si nisan
 */
public class MovementNisan : movement{

	void Start () {
		ObstaclePrefab = GameObject.FindGameObjectWithTag ("Obstacle");
	}
}