using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ladder : MonoBehaviour {
	public GameObject accessBag;
	public GameObject end_notice;
	bool rope= false;
	int wood = 0; 
	bool check;
	void OnTriggerStay(Collider player){
		string[] myBag = accessBag.GetComponent<pack>().backpack;
		
		if (player.tag == "Player"){
			if (check == true){
				//REVEAL GUI TO PRESS F TO BUILD
				end_notice.SetActive(true);
			}
			else{
				for (int i = 0; i < 5; i++){
				Debug.Log("myBag: " + myBag[i]);
				if (myBag[i] == "rope"){
					rope = true;
				}
				if (myBag[i] == "wood"){
					wood += 1;
				}
				if (myBag[i] == "wood (1)"){
					wood += 1;
				}
				if (myBag[i] == "wood (2)"){
					wood += 1;
				}
			}
			if (rope == true && wood == 3){
				check = true;
			}	
			}
		}
		if (Input.GetKeyDown(KeyCode.F)){
			if (!check){
				//Debug.Log("returned false to backpack");
				return;
			}
			else{
				//Debug.Log("loading scene");
				SceneManager.LoadScene(0);
			}
		}
	}
	void OnTriggerExit(Collider player){
		if (player.tag == "Player"){
			//Debug.Log("On trigger exit setting false");
			end_notice.SetActive(false);
		}
	}
}
