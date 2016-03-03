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
		if ((other.gameObject.tag == "Player")) {
			//KILL
		}
	}
}
