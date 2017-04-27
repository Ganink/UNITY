using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {
    /// <summary>
    /// IA BASIC
    /// En este Script haremos que nuestro enemigo se acerque a nuestra posicion
    /// </summary>
    // Use this for initialization

    public GameObject enemy;
    public float Speed = 0f, Distance = 0f;
    public Transform player;

	void Start () {
		
	}
	
	void Update () {
        RO();
    }

    private void RO()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < Distance)
        {
            //cuando la distancia entre el personaje y el enemigo es inferior a la distancia
            //que hemos establecido, el enemigo mirara a la posicion de nuestro personaje

            Vector3 direccion = player.position - transform.position;
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);
            transform.Rotate(0, 0, -90);
            Debug.Log("Te estoy vigilando.");
        }
        else
            Debug.Log("¿Donde estás?.");
    }
}
