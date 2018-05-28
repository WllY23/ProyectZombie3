using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// estructura que me contiene los elementos del color y de las partes de cuerpo del zombie
public struct Zonbiedates                                                     
{
	public  Color[] col; // vector de los colores del zombie que llame coler 
	public body part; // enum body de las partes del cuerpo que llame part 
	public float Speed; // velocidad flotante que se le da al zombie 
	public int rndrota; // variable entera para la rotacion del zombie
}

//enum que me tiene las partes del cuerpo del zombie
public enum body                                           
{
	Cabesa, piernas, brazos, torso, Cerebro 
}
//enum que tiene idle que es cuando el zombie esta quieto y moving que esta en movimiento
public enum Estado
{
	idle,moving,rotating
}

// enum que me contiene los nombres de los ciudadanos 
public enum nomciu                                           
{
	dan, will, mia, hernan, jose, pipe, leila, altaf, ismael, bills,
	mike, reslo, shen, barbatos, bruslas, yuri, boris, doris, juan, jiren
}
//estuctura que me contiene un entero de edad y el enum para los nombres y edad de los ciudadanos  
public struct datosciudadano                                              
{
	public int age; // edad del ciudadano
	public nomciu name; // enum nombre del ciudadano que llame name
}
// estructura person para el minimo de cubos que se crearan en la escena
public struct Person
{
	public readonly int Min; // min variable tipo entera readonly para el minimo de cubos que se crearan 

	public Person (int rnd1) // constructor person con un intero rnd1 
	{
		Min = rnd1; // le estoy diciendo en esta funcion que la variable readonly min sea igual al rnd1 de la funcion
	}
}
// estructura de los datos del zombie
public struct DatosHero 
{
	public readonly float speed; // variable flotante readonly que determina la velocidad del heroe
	// constructor donde igualo la velocidad del zombie a la del flotante del metodo 
	public DatosHero (float speed2)
	{
		speed = speed2;
	}
}

