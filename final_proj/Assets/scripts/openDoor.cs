using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
	public GameObject door_notice;
	void OnTriggerStay(Collider player){
		door_notice.SetActive(true);
		if (Input.GetKeyDown(KeyCode.F)){
			//Debug.Log("pressed F at Door");
			this.gameObject.transform.Translate(0,-90,0);
			door_notice.SetActive(false);
			StartCoroutine(DelayEnumerator(5f));
		}
	}

	void OnTriggerExit(Collider object_hit){
		//Debug.Log("leaving door trigger");
		if (object_hit.tag == "Player"){
			door_notice.SetActive(false);
		}
	}

	IEnumerator DelayEnumerator(float newDelayTime){
		yield return new WaitForSeconds(newDelayTime);
		this.gameObject.transform.Translate(0,90,0);
	}

}
