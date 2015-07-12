using UnityEngine;
using System.Collections;

public class doorfixed : MonoBehaviour {

	public GameObject thedoor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col) {
		//GameObject thedoor = gameObject.FindWithTag("SF_Door");
		thedoor.GetComponent<Animation>().Play("open");
	}
	
	void OnTriggerExit (Collider col) {
		//GameObject thedoor = gameObject.FindWithTag("SF_Door");
		thedoor.GetComponent<Animation>().Play("close");
	}
}
