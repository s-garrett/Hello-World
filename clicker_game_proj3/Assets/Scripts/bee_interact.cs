using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bee_interact : MonoBehaviour { 
	// Use this for initialization
	public float speed;
	public GameObject cylinder; //Cylinder holds world scripts.
	
	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if (hit.collider.CompareTag("Enemy")){
					Debug.Log("enemy hit");
					Destroy(hit.collider.gameObject);
					//some issue in score display
					cylinder.GetComponent<ScoreDisplayer>().score += 10;
				}
			}  
		}
		this.transform.position = Vector3.MoveTowards(transform.position, cylinder.transform.position, Time.deltaTime * speed);
	}
}
