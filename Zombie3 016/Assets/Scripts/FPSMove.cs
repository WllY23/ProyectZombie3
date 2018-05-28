using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : FPSAim
{
	DatosHero _Hero; //llamando la estructura datoshero 

    void Start ()
    {
		// instanciando la estructura del heroe
		float s = Random.Range (1.99f, 3.55f); //velocidad con un valor aleatorio de 1.9 a 3.55 flotante
		_Hero = new DatosHero (s);
    }
		
	void Update ()
    {
	    //  esta es un condicional que idica que si preciono W el objeto avanzara hacia adelante
        if (Input.GetKey(KeyCode.W))
        {
			// la posicion de objeto avanzara acia adelante con la velocidad indicada en la variable speed
			transform.position += transform.forward * _Hero.speed * Time.deltaTime;
        }
        //  esta es un condicional que idica que si preciono S el objeto avanzara hacia atras
        if (Input.GetKey(KeyCode.S))
        {
			// la posicion de objeto avanzara acia atras con la velocidad indicada en la variable speed
			transform.position -= transform.forward * _Hero.speed * Time.deltaTime; 
        }
        //  esta es un condicional que idica que si preciono A el objeto avanzara hacia la derecha
        if (Input.GetKey(KeyCode.A))
        {
			// la posicion de objeto avanzara acia la derecha con la velocidad indicada en la variable speed
			transform.position -= transform.right * _Hero.speed * Time.deltaTime; 
        }
        //  esta es un condicional que idica que si preciono D el objeto avanzara hacia adelante
        if (Input.GetKey(KeyCode.D))
        {
			// la posicion de objeto avanzara acia la izaquierda con la velocidad indicada en la variable speed
			transform.position += transform.right * _Hero.speed * Time.deltaTime;
        }

		// gira es un metodo que se hereda de la clase FPSAim que me indica que cuando la pocision
		//del mouse en x y y este indicada siga la trayectoria con la que avanza y señala el mouse
		gira ();
	}
}
