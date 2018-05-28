using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;   // llamando el namespace de aliado (ciudadano)
using NPC.Enemy; // llamando el namespace de  enemygo(zombie)

public class Hero : MonoBehaviour
{
	datosciudadano _citi; // llamando la estructura del ciudadano
	Zonbiedates _zonbi; // llamando la estructura del zombie
	void Start () 
	{           
		Camera.main.gameObject.AddComponent<FPSAim>(); // añade el script fpsaim a la main camara
	}
	// metodo de colision del zombie y el ciudadano con el heroe
	void OnCollisionEnter(Collision collision)
	{
		//  si que me dice que si el heroe choca con el zombie me imprima un mensaje
		if (collision.gameObject.tag == "Zombie")
		{
			Debug.Log ("Waaaarrr quiero comer " + collision.gameObject.GetComponent<Zombie>()._zonbi.part); // mensaje que se imprime en caso de collicion con el zombie
		}
		//  si que me dice que si el heroe choca con el ciudadano me imprima un mensaje
		if (collision.gameObject.tag == "Ciudadano")
		{ 
			Debug.Log ("hola soy " + collision.gameObject.GetComponent<Ciudadano>()._citi.name + " y tengo " + collision.gameObject.GetComponent<Ciudadano>()._citi.age + " años"); // mensaje que se imprime en caso de collicion con el ciudadano 
		}
	}
}
