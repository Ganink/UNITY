using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    bool active;
    Canvas canvas;

	void Start () {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)){
            //conmutamos si está entre activo o no.
            active = !active;
            canvas.enabled = active;
            /*para detener el juego completamente
            si está pausado entra por el 0 que detiene el juego.
            si no, entra por el 1 y sigue su velocidad normal*/
            Time.timeScale = (active) ? 0 : 1f;
        }
	}
}
 
