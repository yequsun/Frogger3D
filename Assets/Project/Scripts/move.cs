using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed;
	public bool reverse;
	public float aliveTime;
	float birthTime;

	// Use this for initialization
	void Start () {
		birthTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!reverse) {
			GetComponent<Rigidbody> ().velocity = Vector3.forward * speed;
		} else {
			GetComponent<Rigidbody> ().velocity = Vector3.back * speed;
		}

		if (Time.time - birthTime > aliveTime) {
			Destroy(this.gameObject);
		}
	
	}

	void OnTriggerEnter(Collider col){
		if (this.gameObject.layer == 11) {
			if(col.gameObject.tag == "Player"){
				Invoke("Reload",0.5f);
			}
		}
	}

	void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}
}
