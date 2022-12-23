using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public Rigidbody2D flappyrigidbody;
    public float strength = 1;
    public LogisticScript logic;
    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogisticScript>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        {
            flappyrigidbody.velocity = Vector2.up * strength;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        Debug.Log("collision true");
        logic.gameOver();
        alive = false;
    }

}
