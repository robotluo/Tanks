using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour {

	public float moveSpeed = 10.0f; //移动速度
	public float rotaSpeed = 5;	//旋转速度
	public string number = "1"; //tank 编号
	private Rigidbody myRigidbody;
	// Use this for initialization
	void Start () {
		myRigidbody = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float v = Input.GetAxis ("Vertical"+ number);
		myRigidbody.velocity = transform.forward * v * moveSpeed;
		float h = Input.GetAxis ("Horizontal"+ number);
		myRigidbody.angularVelocity = transform.up * h * rotaSpeed;

	}
}
