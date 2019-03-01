using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using slotUpdater;

public class pack : MonoBehaviour {
	public string[] backpack = new string[5];
	public List<inventorySlot> slots = new List<inventorySlot>();

	private bool Add(string item){
		for (int i = 0; i < 5; i++){
			//Debug.Log(backpack[i]);
			if(backpack[i] == ""){
				backpack[i] = item;
				slots[i].itemName = item;
				return true;
			}
		}
		return false;
	}
	public void updateSlot(){
		//Debug.Log("updating slot");
		for (int i = 0; i < slots.Count; i++){
			slots[i].updateSlots();
		}

	}
	//true/false to determine whether room to add item.
	public void AddItem(string name){
		bool hasAdded = Add(name);
		if (hasAdded){
			updateSlot();
		}
	}
}
