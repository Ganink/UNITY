using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timercount : MonoBehaviour {

    //public GameObject player;
    //PlayerRespawn Respawn;
    public TextMesh timerText;
    public double timer;

	void Start (){
        //Respawn = new PlayerRespawn();
    }

    void Update () {
        if (timer > 0)
            TimerCountDown();
        else {
            //Destroy(player);
            Debug.Log("Has perdido");
        }
    }

    void TimerCountDown(){
        timer = timer - 0.01;
        timerText.text = "" + timer.ToString("#.##");
    }
}
 
