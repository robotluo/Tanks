using UnityEngine;
using System.Collections;

public class ShellExplosion : MonoBehaviour {

	public float delay = 1.5f;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
