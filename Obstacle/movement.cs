using UnityEngine;
using System.Collections;

//Nama kelasnya harusnya kapital di awal
public abstract class movement : MonoBehaviour {

	protected Vector3 velocity = Vector3.zero;
	public Vector3 initialSpeed;
	public static GameObject ObstaclePrefab;
	public float maxSpeed;

	void Start () {
		ObstaclePrefab = GameObject.FindGameObjectWithTag ("Obstacle");
	}

	/*
	* Nanti atur-atur lagi initialSpeednya mau gimana modelnya
	* Untuk sementara speednya diatur di inspectornya dulu
	*/
	void FixedUpdate () {
		velocity += initialSpeed * Time.deltaTime;
		velocity = Vector3.ClampMagnitude (initialSpeed, maxSpeed);
		transform.position += velocity * Time.deltaTime;
	}
		
	/*
	 * Di belah kiri kamera harusnya nanti ada collider trigger
	 * Kalo obstaclenya nabrak si trigger harusnya nanti obstacle yg nabrak didestroy
	 * Tapi kok disini kedestroynya telat?
	 */
	void OnTriggerEnter2D(Collider2D collider){
		Destroy (ObstaclePrefab);
	}
}
