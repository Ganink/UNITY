using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    //control de vida maxima.
    float hp, maxhp = 100f;

    //control de la barra de daño.
    public Image health;

    void Start () {
        hp = maxhp;
	}
	
	//funcion para reducir la vida en caso de colision con enemigo.
    public void takeDamage(float amount){
        //con el metodo Math.clamp asignamos que nuestro hp nunca pueda ser menor a 
        //0 ni mayor que maxhp
        hp = Mathf.Clamp(hp - amount, 0f, maxhp);
        //controlamos escalado de la barra de vida.
        health.transform.localScale = new Vector2(hp / maxhp, 1);
    }
}
 
