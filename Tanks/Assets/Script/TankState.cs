using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TankState : MonoBehaviour {

	public float Hp = 100;
	public GameObject TankExplosion;
	public float hpIndex = 100;
	public Slider hpSlider;
	// Use this for initialization
	void Start () {
		hpSlider.value = hpIndex / Hp;
	}
	public void Hit(object power){
		
		hpIndex -= (float)power;

		if (hpIndex <= 0) {
			GameObject.Instantiate (TankExplosion, transform.position, transform.rotation);
			Destroy (this.gameObject);
		} else {
			hpSlider.value = hpIndex / Hp;
		}
	}
}
