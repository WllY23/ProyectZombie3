using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC //namespace global NPC
{
	namespace Enemy // namespace de la clase del zombie llamado enemy
	{
		public class Zombie : MonoBehaviour
		{
			public Zonbiedates _zonbi; // llamando la estructura Zombiedates 

			int rnd; //entero que llame rnd para el random del caso

			Estado estado; // enum estado

			public int rndrota; // variable entera para el rabdom de la rotacion

			int moving; //idle es el estado en movimiento del zombie 

			// esta es una coorutina que cada 5 segundos me realizar un random en el estado y la direccion del zombie
			IEnumerator MovimientoZombie ()
			{
				yield return new WaitForSeconds(3); // estoy diciendo que me espere 5 segundos para llamar el ramdom de los estados
				estado = (Estado) Random.Range(0,3); // llamando los estados 
				rnd = Random.Range(0, 4);// realizado el ramdom de los estados se llama este que es el ramdom de los movimientos 
				rndrota = Random.Range (0, 2); // random para la rotacion
				StartCoroutine (MovimientoZombie ()); // iniciando la corrutina Movimiento zombie
			}
			void Start()
			{
				_zonbi.part = (body)Random.Range (0, 5); // ramdon de de las partes del cuerpo
				StartCoroutine (MovimientoZombie ());// llamando e iniciando la corrutina Movimiento zombie
				_zonbi.Speed = Random.Range(1.7f, 2.3f);// random de la velocidad de la rotacion y movimiento del zombie 
			}
				
		     void Update () 
			{
				//switch que me controla los estados idle y moving del zombie 
				switch (estado) 
				{
					case Estado.idle:
						//Estado.idle: zombie quieto
						break;
				case Estado.rotating: // estado rotacion el zombie rotal con un movimiento al azr
					Rotating (); // llamando el metodo de rotacion
						break;
					case  Estado.moving:
						// zombie en movimiento
						 Moving (); //llamando el metodo del movimiento
						break;
				}
			}

			public void Rotating() // metodo de rotacion para que el zombie rote
			{
				switch (rndrota) 
				{
				case 0:
					transform.Rotate (0, 1 * _zonbi.Speed, 0); // accediendo al transfor de la rotacion del zombie y moviendolo en y y multiplicandolo por la velocidad que escogera aleatoria mente
					break;
				case 1:
					transform.Rotate (0, -1 * _zonbi.Speed, 0); // accediendo al transfor de la rotacion del zombie y moviendolo en -y y multiplicandolo por la velocidad que escogera aleatoria mente
					break;
				};
			}
				
			public void Moving()// metodo para el movimiento del zombie 
			{

				switch (rnd) // caso para escoger al azar el movimiento del zombie
				{
				case 0:
					transform.position += transform.forward * _zonbi.Speed * Time.deltaTime; //avanzar hacia adelante 
					break;
				case 1:
					transform.position -= transform.forward * _zonbi.Speed * Time.deltaTime;	//avanzar hacia atras
					break;
				case 2:
					transform.position += transform.right * _zonbi.Speed * Time.deltaTime; // avanzar hacia la izquierda
					break;
				case 3:
					transform.position -= transform.right * _zonbi.Speed * Time.deltaTime; // avanzar hacia la derecha
					break;
				}
			}
		}
	}
}