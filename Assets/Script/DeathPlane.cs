using UnityEngine;
using System.Collections;

public class DeathPlane : MonoBehaviour {

	public GameObject effect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Enemy") {
			GameObject go = (GameObject) Instantiate (effect, this.transform.position, Quaternion.identity);
			go.transform.position = other.transform.position;
			Destroy (other.gameObject);
		}
	}
}
