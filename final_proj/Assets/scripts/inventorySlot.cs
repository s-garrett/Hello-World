using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace slotUpdater {
	public class inventorySlot : MonoBehaviour {
		public string itemName;
		public GameObject icon;

		public void updateSlots(){
			if(itemName != ""){
				icon.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + itemName);
				Debug.Log("setting icon to active??");
				icon.SetActive(true);
			}
			else{
				icon.SetActive(false);
			}
		}
	}
}
