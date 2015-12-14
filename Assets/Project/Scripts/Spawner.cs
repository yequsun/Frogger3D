using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject prefab;
	public float interval;
	public bool reverse;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnNext", 0, interval);
	
	}
	
	// Update is called once per frame
	void SpawnNext() {
		// Instantiate
		GameObject g =(GameObject)Instantiate(prefab,
		                                      transform.position,
		                                      Quaternion.identity);
		if (reverse) {
			g.GetComponent<move>().reverse = true;
			g.transform.rotation = Quaternion.Euler(new Vector3(0,180,0));
		}
	}
}
