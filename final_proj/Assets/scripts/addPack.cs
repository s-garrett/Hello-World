using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPack : MonoBehaviour {
	public GameObject player_bag;
	public GameObject pick_up_message;
	bool key_pressed = false;
	//public GameObject pick_up_message
	//Checks for player near object to pick up item. 
	private void OnTriggerStay(Collider object_hit){
		string item = object_hit.gameObject.name;
		if (object_hit.tag == "item"){
			//REVEAL GUI FOR PICKING THINGS UP HERE
			pick_up_message.SetActive(true);
			if (Input.GetKeyUp(key: KeyCode.F) && !key_pressed){
			key_pressed = true;
			//ADD OBJECT TO PACK
			player_bag.GetComponent<pack>().AddItem(item);
			//DESTROY OBJECT ON GROUND
			object_hit.gameObject.SetActive(false);
			pick_up_message.SetActive(false);
			key_pressed = false;
		}
		}
	}
	private void OnTriggerExit(Collider object_hit){
		if (object_hit.tag == "item"){
			pick_up_message.SetActive(false);
		}
	}
}