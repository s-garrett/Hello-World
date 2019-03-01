using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicEnabler : MonoBehaviour {
	private static musicEnabler instanceref;
	// Use this for initialization
	void Start () {
		if (instanceref == null){
			instanceref = this;
			DontDestroyOnLoad(this);
		}
		else{
			DestroyImmediate(this);
		}
	}
}
