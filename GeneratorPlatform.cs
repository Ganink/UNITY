using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPlatform : MonoBehaviour {

    public GameObject PlatformPrefab;

    //tiempo que tarda en regenerar plataforma.
    public float GeneratorTimer = 5f;
	private float platX = 0f;
	private float platY = 0f;
    private float sPlatx = 0.5f;

	void Start () {
		Repeat ();
	}

    void createPlatform(){
        /*Pasamos 3 parametros, para que sepa de que tiene que crear la instancia,
         posicion actual del PlatformGenerator, y Quaternion para saber su rotacion*/
		platX = Random.Range (2, 4);
		platY = Random.Range (-1, 2);
		transform.position = new Vector3 (transform.position.x + platX, transform.position.y + platY, 0);
        //escalar plataforma
        transform.localScale = new Vector3(Random.Range(sPlatx, 3), Random.Range(1, 2), 0);
        //creacion
        Instantiate(PlatformPrefab, transform.position, Quaternion.identity);
    }

	void Repeat(){
		/*creamos invocacion para que repita el metodo createPlatform cada x tiempo
        2f es el tiempo de retardo que tiene la primera vez que crea la primera 
        plataforma y GeneratorTimer el tiempo establecido por nosotros para
        que repita esa accion.*/
		InvokeRepeating("createPlatform", 0.5f, GeneratorTimer);
	}
}
