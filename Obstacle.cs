using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    public GameObject[] ob;
    public Transform pos;
	// Use this for initialization
	void Start () {
        ObstacleMaker();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
       // GameObject cs = GameObject.Find("Quad");
       // if (pos.position.x - cs.transform.position.x > 25)
      //  {
      //      Destroy(cs);          ini buat nge destroy obstacle yang udh lewat dari kamera
      //  }                         cuman gk kebaca jadinya gw jadiin commend
	}

    //method buat ngespawn si obstacle
    // ps: di unity bisa masukin ke dalem arraynya
    // Quad adalah BoxCollider jadi nnt spawn dari quad dan bisa buat 2 Quad, 1 yang buat flyingQuad, 1 lagi yang ground Quad
    void ObstacleMaker()
    {
        GameObject obs = (GameObject)Instantiate(ob[Random.Range(0, ob.Length)], transform.position, Quaternion.identity);
        obs.name = "Quad";
        obs.AddComponent<BoxCollider2D>();
        obs.GetComponent<BoxCollider2D>().isTrigger = true;
        float mark = Random.Range(1, 5);
        Invoke("ObstacleMaker", mark);
    }
}
