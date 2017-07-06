using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {
    public GameObject Coints, player;
    public TextMesh points;
    int point = 0, count = 0;

    void Start (){
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        point = count;
        if (collision.gameObject.tag == "Player")
        {
            ckPoint();
        }
        point = ckPoint();
    }

    int ckPoint()
    {
        point = count;
        Destroy(Coints);
        point = point + 1;
        points.text = "" + point.ToString("####");
        return point;
    }

    private void Update()
    {
        point = point + point;
    }
}
 
