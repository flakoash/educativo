using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cambiamenu : MonoBehaviour {

	public Slider slider;
	miracontroller mira;
	public GameObject mi;
	public Transform player;
	// Use this for initialization
	void Start () {
		mira = mi.GetComponent<miracontroller> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < 6f) {
			mira.info=slider;
			mira.pregunta=true;
			Debug.Log(slider.value);
			if(slider.value<=0f)
			{
				Application.LoadLevel("menu");
			}
		}
	}
}
