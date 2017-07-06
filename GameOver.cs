using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private float count = 0;
    public GameObject Player;
    bool gameover = false;
    Canvas canvas;
    // Use this for initialization
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update(){
        check();
    }

    void check() {
        if (Player.transform.position.y <= -20){
            Destroy(Player);
            canvas.enabled = true;
            Time.timeScale = 0;
            gameover = true;
            if (Input.GetKeyDown("return"))
            {
                Application.LoadLevel("Home");
            }
        }
    }
}
