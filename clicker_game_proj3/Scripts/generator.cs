using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {
	public GameObject bee_object;
	public GameObject player;
	public GameObject stump;
	public GameObject shroom;
	public float gameTime = 0;
	// Use this for initialization
	void Start () {
		bee_object.SetActive(false);
		stump.SetActive(false);
		shroom.SetActive(false);
		InvokeRepeating("generate_bee", 0f, 5f);
		InvokeRepeating("generate_stump", 5f, 10f);
		InvokeRepeating("generate_shroom", 3f, 10f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void generate_bee(){
		Debug.Log("generating bee");
		for (int i = 0; i < 7; i++) {
			float x = Random.Range(-25, 25);
			float y = 4;
			float z = Random.Range(-25, 25);
			Vector3 random_area = new Vector3(x, y, z);
			Quaternion rotation= new Quaternion();
			rotation.Set(0,0,0,0);
			GameObject duped = Instantiate(bee_object, random_area, rotation);
			duped.SetActive(true);
			duped.transform.LookAt(player.transform);
		}
	}

	void generate_stump(){
		float x = Random.Range(-25, 25);
			float y = 4;
			float z = Random.Range(-25, 25);
			Vector3 random_area = new Vector3(x, y, z);
			Quaternion rotation= new Quaternion();
			rotation.Set(0,0,0,0);
			GameObject duped = Instantiate(stump, random_area, rotation);
			duped.SetActive(true);
	}

	void generate_shroom(){
		Debug.Log("generating shroom");
		float x = Random.Range(-25, 25);
			float y = 4;
			float z = Random.Range(-25, 25);
			Vector3 random_area = new Vector3(x, y, z);
			Quaternion rotation= new Quaternion();
			rotation.Set(0,0,0,0);
			GameObject duped = Instantiate(shroom, random_area, rotation);
			duped.SetActive(true);
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Enemy"){
			//Debug.Log("player hit");
			this.GetComponent<ScoreDisplayer>().health -= 10;
			Destroy(col.gameObject);
		}
	}
}
