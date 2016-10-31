using UnityEngine;
using System.Collections;

public class TankFire : MonoBehaviour {

	public GameObject shell;
	public float shellSpeed = 20.0f; //子弹速度
	public float shellCD = 0.2f; //子弹间隔
	public float shellCdNow ;	//冷却时间
	public KeyCode keyCode = KeyCode.Space;

	private Transform fire;


	// Use this for initialization
	void Start () {
		fire = transform.Find ("Fire");
		shellCdNow = shellCD;
	}
	
	// Update is called once per frame
	void Update () {
		shellCdNow -= Time.deltaTime;
		if (Input.GetKey (keyCode) && shellCdNow < 1e-5) {
			shellCdNow = shellCD; //重置冷却
			GameObject Shell =  GameObject.Instantiate (shell,fire.position,fire.rotation) as GameObject;
			Shell.GetComponent<Rigidbody> ().velocity = fire.forward * shellSpeed;
		}
	}




}
