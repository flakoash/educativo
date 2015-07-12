using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puertacontroller : MonoBehaviour {

	public Canvas pregunta;
	public BoxCollider colli;
	public Slider iz;
	public Slider der;
	public Slider arri;
	public Slider abaj;
	public Transform player;
	miracontroller mira;
	public GameObject mi;
	bool correcto=false;
	public string pregu;
	public string resp1;
	public string resp2;
	public string resp3;
	public string resp4;
	public int correc;
	public Canvas info;
	public Text pr;
	public Text txarriba;
	public Text txizquierda;
	public Text txderecha;
	public Text txabajo;
	public GameObject canvaspuntos;
	controlnivel control;
	Slider infosli;
	Button sig;
	int intentos=4;
	bool xo=true;
	// Use this for initialization
	void Start () {
		pregunta.enabled = false;
		mira = mi.GetComponent<miracontroller> ();
		info.enabled = false;
		infosli = info.GetComponentInChildren<Slider> ();
		sig = info.GetComponentInChildren<Button> ();
		sig.GetComponent<SphereCollider> ().enabled=false;
		pr.text = pregu;
		txarriba.text = resp1;
		txabajo.text = resp2;
		txderecha.text = resp3;
		txizquierda.text = resp4;
		control = canvaspuntos.GetComponent<controlnivel> ();
	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (Vector3.Distance (player.position, transform.position));
		if (Vector3.Distance (player.position, transform.position) < 6f) {
			//Debug.Log("asdsa");
			if (!pregunta.enabled&&!correcto) {
				pregunta.enabled = true;
				mira.abaj=abaj;
				mira.arri=arri;
				mira.der=der;
				mira.iz=iz;
				mira.info=infosli;
				mira.pregunta = true;

			}
			if(!correcto)player.position=new Vector3(transform.position.x-transform.forward.normalized.x*4,player.position.y,transform.position.z-transform.forward.normalized.z*4);
			if(!xo)pregunta.enabled = false;
			if (iz.value <= 0&&xo)
			{
				verifica (4);
				//xo=true;
			}
			if (der.value <= 0&&xo)
				verifica (3);
			if (arri.value <= 0&&xo)
				verifica (1);
			if (abaj.value <= 0&&xo)
				verifica (2);
			if (infosli.value <= 0)
				pasar ();
		} else {
			if(pregunta.enabled)
			{
				pregunta.enabled = false;
				mira.pregunta = false;
			}
		}
	}
	public void muestra_pregunta()
	{
		pregunta.enabled = true;
	}
	public void verifica(int op)
	{
		if (correc == op) {

			pregunta.enabled = false;
			info.enabled = true;
			abaj.GetComponent<BoxCollider> ().enabled = false;
			sig.GetComponent<SphereCollider> ().enabled = true;
			if(intentos==4){
				control.puntuacion+=500;
				//Debug.Log("asd");
				xo=false;
			}
			else if(intentos==3)
			{
				control.puntuacion+=200;
				//Debug.Log("asd");
				xo=false;
			}
			else if(intentos==2)
			{
				control.puntuacion+=100;
				//Debug.Log("asd");
				xo=false;
			}
			else if(intentos<=1)
			{
				control.puntuacion+=0;
				//Debug.Log("asd");
				xo=false;
			}
		} else
			intentos--;
	}
	public void pasar()
	{
		correcto = true;
		colli.enabled = false;
		info.enabled = false;
		sig.GetComponent<SphereCollider> ().enabled = false;
	}
}
