using UnityEngine;
using System.Collections;

public class Drown : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			print ("text");
		}
	}

	void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
