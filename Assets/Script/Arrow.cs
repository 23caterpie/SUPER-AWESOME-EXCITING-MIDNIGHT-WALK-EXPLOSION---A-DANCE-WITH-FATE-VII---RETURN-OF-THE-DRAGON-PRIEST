using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(new Vector2(-0.05f, 0.0f));
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log ("Arrow Collide!");
		if ((other.gameObject.tag == "Death Plane")) {
			Destroy (this.gameObject);
			Debug.Log ("Arrow Should Die!");
		}
	}
}
