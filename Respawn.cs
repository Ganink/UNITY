using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject player ,Checkpoint;
    public Transform groundCheck;
    public LayerMask whatIsCheckPoint;
    public LayerMask whatIsEnemy;
    private bool Resp;
    public float finyGround = -5f;
    public float groundCheckpointRadius = 10;
    public float CheckEnemyRadius = 1;

    // Use this for initialization
    void Start ()
    {
        //Guardamos la posición inicial del juego. esta posicion será donde empieza nuestro jugador.
        PlayerPrefs.SetFloat("X", player.transform.position.x);
        PlayerPrefs.SetFloat("Y", player.transform.position.y);
        Debug.Log("Posicion guardada");
    }
	
	// Update is called once per frame
	void Update ()
    {
        //RESPAWN A LA POSICIÓN DEL CHECKPOINT.
        if (player.transform.position.x > Checkpoint.transform.position.x)
        {
            //Guardamos la posición del CheckPoint. esta posicion será donde empieza nuestro jugador sin necesidad de volver desde el principio.
            PlayerPrefs.SetFloat("X", Checkpoint.transform.position.x);
            PlayerPrefs.SetFloat("Y", Checkpoint.transform.position.y);
            Debug.Log("CheckPoint");
        }
    }

    void FixedUpdate()
    {
        Resp = Physics2D.OverlapCircle(groundCheck.position, groundCheckpointRadius, whatIsCheckPoint);
        Carga();
    }

    void Carga()
    {
    
        //RESPAWN A LA POSICION PRINCIPAL.
        if (player.transform.position.y <= finyGround)
        {
            Vector2 NuevaPosicion;
            NuevaPosicion.x = PlayerPrefs.GetFloat("X");
            NuevaPosicion.y = PlayerPrefs.GetFloat("Y") + 1;
            player.transform.position = NuevaPosicion;

            Debug.Log("Posicion cargada ");
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Mueres al tocar enemigo.
        if (coll.gameObject.tag == "Enemy")
        {
            Vector2 NuevaPosicion;
            NuevaPosicion.x = PlayerPrefs.GetFloat("X");
            NuevaPosicion.y = PlayerPrefs.GetFloat("Y") + 1;
            player.transform.position = NuevaPosicion;

            Debug.Log("Has Muerto.");
        }
    }
}
