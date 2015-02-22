using UnityEngine;
using System.Collections;

public class BGLooperScript : MonoBehaviour {

	int numBGPanels = 3;

	float pipeMax = 2.63f;
	float pipeMin = -1f;


	void Start() {
	GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monsters");

	foreach(GameObject monster in monsters) {
		Vector3 pos = monster.transform.position;
		pos.y = Random.Range (pipeMin, pipeMax);
		monster.transform.position = pos;

	}
}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += widthOfBGObject * numBGPanels;

		if (collider.tag == "Monster") {
			pos.y = Random.Range (pipeMin, pipeMax);
		}

		collider.transform.position = pos;


	}
}
