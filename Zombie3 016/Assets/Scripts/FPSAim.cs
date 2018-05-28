using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour 
{
    // variables definidas para la rotacion en x y y del mouse
    float MouseX;
    float MouseY;
    // este es un booleano que al ser verdadero me invierte las rotaciones del mouse
    public bool invertemouse;
    
    void Start () 
	{
	}
	void Update ()
    {
		// aumentando la rotacion del mouse en x
        
		//condicion que invirte la posicion 
        if (invertemouse)
        {
			// aumentando la posicion del mouse en y
            MouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
			// disminuyendo la rotacion  del mouse en y
            MouseY -= Input.GetAxis("Mouse Y");
        }
		gira ();
        //MouseY += Input.GetAxis("Mouse Y");
		//rotacion de la camara utilizando eulerangeles(rotacion como angulos euler en grados) se lee en lugar de quaternions
		//rotacion de la camara en y y x con el mouse en euler angeles
	}
	// gira es que metodo que me indica que cuando la pocision del mouse en x y y este indicada siga la trayectoria con la que avanza y señala.
	public void gira()
	{
		MouseX += Input.GetAxis("Mouse X");
		transform.eulerAngles = new Vector3(MouseY, MouseX, 0);
	}
}

