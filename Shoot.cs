using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject canon, sShoot, shoot, enemy;
    public float velShoot = 0;
    private Collision2D collision;

    void Start () {
        collision = new Collision2D();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Disparo(collision);
        }
        OnCollisionEnter2D(collision);
	}

    public void Disparo(Collision2D collision)
    {
        GameObject shoot2;
        shoot2 = GameObject.Instantiate(shoot, sShoot.transform.position, canon.transform.rotation);
        shoot2.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, velShoot, 0), ForceMode.VelocityChange);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag =="Enemy")
        {
            Destroy(gameObject);
        }
    }
}
