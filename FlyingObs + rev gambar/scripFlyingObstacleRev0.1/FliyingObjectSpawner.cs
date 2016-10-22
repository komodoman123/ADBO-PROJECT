using UnityEngine;
using System.Collections;

public class FlyingObjectSpawner : MonoBehaviour {

    public GameObject flyingDay;
    public GameObject flyingNight;
    public GameObject spawnedObject;
    public GameObject objectTaken;
    public bool nightMaps;
    //Kalo buat ngespawn dua obstacle urang ga tau

    FlyingObjectSpawner()
    {
        this.flyingDay = new GameObject();
        this.flyingNight = new GameObject();
        if (nightMaps == true) { 
            objectTaken = flyingNight;
        }
        else {
            objectTaken = flyingDay;
        }
    }

    void Start()
    {
        this.SpawnObject();
    }

    public void SpawnObject()
    {
        spawnedObject = Instantiate(objectTaken, transform.position, transform.rotation) as GameObject;
        spawnedObject.name = "flyingObs";
        spawnedObject.transform.parent = GameObject.FindGameObjectWithTag("Obstacle").transform;
        spawnedObject.transform.position = GameObject.FindGameObjectWithTag("Obstacle").transform.position;
    }
}