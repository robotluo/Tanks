using UnityEngine;
using System.Collections;

public class FollowTank : MonoBehaviour {

	public Transform player1; 		//玩家1
	public Transform player2; 		//玩家2
	public float cameraMin = 10.0f;	//相机最小 size
	public float cameraMax = 30.0f; //相机最大 size
	public Vector3 offset;  		//差值
	private Camera myCamera; 		//相机
	// Use this for initialization
	void Start () {
		offset = transform.position - (player1.position + player2.position) / 2;
		myCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player1 == null || player2 == null) {
			return;
		} 
		transform.position = (player1.position + player2.position) / 2 + offset;
		float size = Vector3.Distance (player1.position, player2.position);
		size = Mathf.Max (size, cameraMin);   //控制视野不至于过小
		size = Mathf.Min (size, cameraMax);	  //控制视野不至于过大	
		myCamera.orthographicSize = size;
	}
}
