using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public float score = 0f;
	public Text scoreUI;
	public bool playerAlive = true;

	private float timeSinceDeath = 0f;
	private float enemyTimeDelta = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerAlive) {
			score += Time.deltaTime;
			scoreUI.text = "Score: " + (int)score;
		} else {
			if (timeSinceDeath < 1) {
				timeSinceDeath += Time.deltaTime;
			} else {
				Application.LoadLevel (Application.loadedLevel);
				playerAlive = true;
			}
		}
		enemyTimeDelta += Time.deltaTime;
		if(enemyTimeDelta > 1.0) {
			enemyTimeDelta = 0f;
			GameObject spawnControllerObject = GameObject.Find ("SpawnController");
			SpawnController spawnControllerScript = spawnControllerObject.GetComponent<SpawnController> ();
			spawnControllerScript.SpawnObject ();
		}
	}
}
