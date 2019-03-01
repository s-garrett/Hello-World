using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shroom_interact : MonoBehaviour {
public GameObject cylinder;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				if (hit.collider.CompareTag("shroom")){
					Debug.Log("gaining health");
					Destroy(hit.collider.gameObject);
					//some issue in score display
					cylinder.GetComponent<ScoreDisplayer>().health += 10;
				}
			}  
		}
	}
}
