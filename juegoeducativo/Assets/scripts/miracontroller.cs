using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class miracontroller : MonoBehaviour {

	public float tiempo_cambio=3f;
	public Slider iz;
	public Slider der;
	public Slider arri;
	public Slider abaj;
	public Slider info;
	public GameObject player;
	float timer=0f;
	public bool pregunta=false;
	// Use this for initialization
	void Start () {
		timer = tiempo_cambio;
		iz.maxValue = tiempo_cambio;
		der.maxValue = tiempo_cambio;
		iz.value=tiempo_cambio;
		der.value=tiempo_cambio;
		arri.maxValue = tiempo_cambio;
		abaj.maxValue = tiempo_cambio;
		arri.value=tiempo_cambio;
		abaj.value=tiempo_cambio;
		info.maxValue = tiempo_cambio;
		info.value = tiempo_cambio;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//Debug.Log (Vector3.Distance (player.transform.position, transform.position));
		//transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(player.transform.position-transform.position),2f);
		//Debug.Log ("asdasd");
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, 100f)&&pregunta)
		{
			//Debug.Log (hit.collider.gameObject.name);
			if(hit.collider.gameObject.name == "izquierda"||hit.collider.gameObject.name == "derecha"||hit.collider.gameObject.name == "arriba"||hit.collider.gameObject.name == "abajo"||hit.collider.gameObject.name == "siguiente")
			{
				timer-=Time.deltaTime;
				//Debug.Log(timer);
				if (hit.collider.gameObject.name == "izquierda"&&iz.value!=0)iz.value=timer;
				if (hit.collider.gameObject.name == "derecha"&&der.value!=0)der.value=timer;
				if (hit.collider.gameObject.name == "arriba"&&arri.value!=0)arri.value=timer;
				if (hit.collider.gameObject.name == "abajo"&&abaj.value!=0)abaj.value=timer;
				if (hit.collider.gameObject.name == "siguiente"&&info.value!=0)info.value=timer;
				if (hit.collider.gameObject.name == "izquierda"&& timer<0)
				{
					timer = tiempo_cambio;
					//player.position=Vector3.Lerp(player.position,new Vector3(player.position.x-rango,player.position.y,player.position.z),100000f);
					iz.value=0f;
				}
				
				if (hit.collider.gameObject.name == "derecha" &&  timer<0)
				{
					timer = tiempo_cambio;
					//player.position=Vector3.Lerp(player.position,new Vector3(player.position.x+rango,player.position.y,player.position.z),100000f);
					der.value=0f;
				}
				if (hit.collider.gameObject.name == "arriba"&& timer<0)
				{
					timer = tiempo_cambio;
					//player.position=Vector3.Lerp(player.position,new Vector3(player.position.x-rango,player.position.y,player.position.z),100000f);
					arri.value=0f;
				}
				
				if (hit.collider.gameObject.name == "abajo" &&  timer<0)
				{
					timer = tiempo_cambio;
					//player.position=Vector3.Lerp(player.position,new Vector3(player.position.x+rango,player.position.y,player.position.z),100000f);
					abaj.value=0f;
				}
				if (hit.collider.gameObject.name == "siguiente" &&  timer<0)
				{
					//timer = tiempo_cambio;
					//player.position=Vector3.Lerp(player.position,new Vector3(player.position.x+rango,player.position.y,player.position.z),100000f);
					info.value=0f;
				}

			}
			else {
				timer = tiempo_cambio;
				iz.value=tiempo_cambio;
				der.value=tiempo_cambio;
				arri.value=tiempo_cambio;
				abaj.value=tiempo_cambio;
			}

		}
		
		Debug.DrawRay (transform.position, transform.forward );
		//Debug.Log ("visto" + Vector3.Distance (player.transform.position, transform.position));
		
	}
}
