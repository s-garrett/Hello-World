using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	public GameObject accessor;
	void Start() {
	}
	void Update () {
		//MAKE PLAYER SPIN TO LOOK AT THE MOUSE CURSOR
		Plane groundPlane = new Plane(Vector3.up, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z));
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distance;
		if (groundPlane.Raycast(ray, out distance)){
			Vector3 point = ray.GetPoint(distance);
			transform.LookAt(point);
		}
	}
}
