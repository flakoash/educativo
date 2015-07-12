using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlnivel : MonoBehaviour {

	public int puntuacion;
	public Text txpunt;
	public Slider tiempo;
	public float tiempo_nivel=100f;
	public Image corazon1;
	public Image corazon2;
	public Image corazon3;
	public Sprite corazonnegro;
	public int vidas=3;
	public Transform player;
	Vector3 inicio;
	float timer;
	// Use this for initialization
	void Start () {
		tiempo.maxValue = tiempo_nivel;
		timer = tiempo_nivel;
		inicio = player.position;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		tiempo.value = timer;
		txpunt.text ="Puntuacion: "+puntuacion;
		if (timer <= 0) {
			if(vidas==3)
			{
				corazon3.sprite=corazonnegro;
				vidas--;
				//player.position=inicio;
				//puntuacion=0;
			}
			else if(vidas==2)
			{
				corazon2.sprite=corazonnegro;
				vidas--;
				//player.position=inicio;
				//puntuacion=0;
			}
			else if(vidas==1)
			{
				corazon1.sprite=corazonnegro;
				vidas--;
				//player.position=inicio;
				//puntuacion=0;
			}
			else if(vidas==0)
			{
				Debug.Log("perdiste");
				//player.position=inicio;
				//puntuacion=0;
			}
			timer=tiempo_nivel;
		}
	}

}
