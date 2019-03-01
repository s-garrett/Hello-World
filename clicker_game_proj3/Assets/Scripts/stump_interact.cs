using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stump_interact : MonoBehaviour {
	public GameObject cylinder;
	float accumalated = 0f;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		accumalated += Time.deltaTime;
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if (hit.collider.CompareTag("stump")){
					Debug.Log("gaining time");
					Destroy(hit.collider.gameObject);
					cylinder.GetComponent<ScoreDisplayer>().timeAccumulated -= 10;
				}
			}  
		}
		if (accumalated > 5){
			Destroy(this.gameObject);
			accumalated = 0;
		}
	}
}
