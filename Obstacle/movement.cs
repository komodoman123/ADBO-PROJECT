using UnityEngine;
using System.Collections;

//Nama kelasnya harusnya kapital di awal
public abstract class movement : MonoBehaviour {

	protected Vector3 velocity = Vector3.zero;
	protected Vector3 initialPos;
	public Vector3 speed;
	public static GameObject ObstaclePrefab;
	public Spawner spawner;
	public float maxSpeed;

	void Start () {
		//ObstaclePrefab = GameObject.FindGameObjectWithTag ("Obstacle");
		//initialPos = transform.position;
	}


	void FixedUpdate () {
		/*
		 * Nanti atur-atur lagi speednya mau gimana
		 * Pokoknya Time.deltaTime jangan dihapus nanti obstaclenya ngebut
		 */
		velocity += speed * Time.deltaTime;
		velocity = Vector3.ClampMagnitude (speed, maxSpeed);
		transform.position += velocity * Time.deltaTime;
	}
		
	//Di belah kiri kamera harusnya nanti ada collider trigger
	//Kalo obstaclenya nabrak si trigger harusnya nanti obstacle yg nabrak didestroy
	//Nanti muncul lagi obstacle baru
	void OnTriggerEnter2D(Collider2D collider){
		spawner.SpawnObstacle ();
		transform.position = initialPos;
		Destroy (ObstaclePrefab.transform.GetChild(0).gameObject);
	}
}
