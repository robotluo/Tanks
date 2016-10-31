using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {

	public GameObject shellExplosion;
	public float minShellPower = 10.0f;
	public float maxShellPower = 20.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		GameObject.Instantiate (shellExplosion, transform.position, transform.rotation);
		Debug.Log ("Hp" );
		if (other.tag == "Player") {
			Debug.Log ("Hphehehe");
			object power = Random.Range (minShellPower, maxShellPower) as object;
			other.SendMessage ("Hit" , power);
		}

		Destroy (this.gameObject);
	}

}
