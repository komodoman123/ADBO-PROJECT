using UnityEngine;
using System.Collections;

public class FlyingMovementBehavior : MonoBehaviour {

    protected Vector2 speed = Vector2.zero;//var 1 sama 3 di simpen dlu aja gw sepertinya ada ide buat yang 1 ini
    protected Vector2 initialize;
    public Vector2 initializeSpeed;
    public static GameObject ObstaclePrefab;
    public FlyingObjectSpawner spawner;

    // gw msh bingung ini buat apa
    void Start()
    {
        
    }

    //methodnya digunain buat update si obstacle, setiap dia ngasih true di spawner nnt dia bakal spawn new obstacle
    //intinya ma buat nge construct new obstacle setiap kali di spawner itu true spawn objectnya
    void FixedUpdate()
    {
        //perlu beresin ground ama background biar bisa fix buat random obstacle position
    }

    
    void OnTriggerEnter2D(Collider2D collider)
    {
        spawner.SpawnObject();
        transform.position = initialize;
        Destroy(ObstaclePrefab.transform.GetChild(0).gameObject);
    }
}