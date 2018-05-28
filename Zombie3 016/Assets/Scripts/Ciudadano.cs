using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC //namespace gloval 
{
	namespace Ally // namespace del ally (ciudadano)
	{
		public class Ciudadano : MonoBehaviour
		{
			public datosciudadano _citi; // llamando la estructura de los ciudadanos 

			void Start () 
			{
				_citi.name = (nomciu)Random.Range(1, 20); //random para los nombres de los ciudadanos 
				_citi.age = Random.Range(15, 101);// ramdom para las edades de los cuudadanos 
			}
		}
	}
}