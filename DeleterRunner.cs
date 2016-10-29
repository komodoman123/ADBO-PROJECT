using UnityEngine;
using System.Collections;

public class DeleterRunner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy (((BoxCollider2D)collider).gameObject);
	}
}
