using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject EnemyPrefab;
    //tiempo que tarda en regenerar enemigo.
    public float GeneratorTimer = 1.75f;

	void Start () {
        /*creamos invocacion para que repita el metodo createEnemy cada x tiempo
        0f es el tiempo de retardo que tiene la primera vez que crea el enemigo
        y GeneratorTimer el tiempo establecido por nosotros para que repita esa accion.
        */
        InvokeRepeating("createEnemy", 0f, GeneratorTimer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void createEnemy(){
        /*Pasamos 3 parametros, para que sepa de que tiene que crear la instancia,
         posicion actual del Enemygenerator, y Quaternion para saber su rotacion*/

        Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }
}
