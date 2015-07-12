using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class miramenu : MonoBehaviour {

	// Use this for initialization
	public Slider sli;
	public Text tex;
	public float tiempo_cambio=3f;
	float timer;
	void Start () {
		timer = tiempo_cambio;
		sli.maxValue = tiempo_cambio;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//Debug.Log (Vector3.Distance (player.transform.position, transform.position));
		//transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(player.transform.position-transform.position),2f);
		
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, 15f)) {

			timer -= Time.deltaTime;
			sli.value = timer;
			sli.transform.position = hit.transform.position;
			tex.text=hit.collider.gameObject.name;
			if (hit.collider.gameObject.name == "nivel0" && timer <= 0f) {
				//sli.transform.position = hit.transform.position;
				Application.LoadLevel("level0");

			} else if (hit.collider.gameObject.name == "bolivia"&& timer <= 0f) {
				//sli.transform.position = hit.transform.position;
				Application.LoadLevel("level1");
			}
			else if (hit.collider.gameObject.name == "america"&& timer <= 0f) {
				//sli.transform.position = hit.transform.position;
				Application.LoadLevel("level2");
			}
			else if (hit.collider.gameObject.name == "todo"&& timer <= 0f) {
				//sli.transform.position = hit.transform.position;
				Application.LoadLevel("level3");
			}

		} else {
			sli.transform.position=Vector3.zero;
			timer = tiempo_cambio;
			sli.value=timer;
		}
		Debug.DrawRay (transform.position, transform.forward*500 );
	}
}
