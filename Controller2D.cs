using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{

    //velocidad movimiento personaje
    public float Speed = 4f;
    //animacion personaje.
    Animator anim;
    //control de daños.
    private GameObject healthbar;

    void Start(){
        //definimos animacion para los distintos estados del jugador. ya sea idle o en movimiento.
        anim = GetComponent<Animator>();
        //no es recomendable usar .Find si hay muchos objetos
        healthbar = GameObject.Find("Healthbar");
    }

    void Update(){
        Control();
    }

    void Control(){
        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov,
            Speed * Time.deltaTime);

        //control de animacion.
        anim.SetFloat("movX", mov.x);
        anim.SetFloat("movY", mov.y);
    }

    public void EnemyKnockBack(float enemyPosX){
        //enviamos un mensaje y la cantidad de daño recibido
        healthbar.SendMessage("takeDamage", 15);
    }
} 
