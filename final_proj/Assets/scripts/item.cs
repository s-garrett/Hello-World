using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
	public static string itemName;
	public Sprite icon = Resources.Load<Sprite>("Sprites/" + itemName);
}
