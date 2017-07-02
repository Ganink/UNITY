using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject Fecha, Lista;
    int indice = 0;

	void Start () {
        Dibujar();
	}
	
	void Update () {
        bool up = Input.GetKeyDown("up");
        bool down = Input.GetKeyDown("down");

        if (up) indice--;
        if (down) indice++;

        if (indice > Lista.transform.childCount - 1) indice = 0;
        else if (indice < 0) indice = Lista.transform.childCount - 1;

        if (up || down) Dibujar();

        if (Input.GetKeyDown("return")) Accion();
	}

    void Dibujar() {
        Transform opcion = Lista.transform.GetChild(indice);
        Fecha.transform.position = opcion.position;
    }

    void Accion() {
        Transform opcion = Lista.transform.GetChild(indice);
        //seleccionamos scene a partir de su nombre.
        if(opcion.gameObject.name == "SALIR"){
            print("Cerrando el juego... Gracias por jugarlo.");
            Application.Quit();
        }
        else{
            SceneManager.LoadScene(opcion.gameObject.name);
        }
    }
}
