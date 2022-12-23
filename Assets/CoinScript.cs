using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public LogisticScript logic;
    public int scores = 1;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogisticScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {    
      if (collision.gameObject.layer == 3){
        
      logic.addScore(scores);
      Debug.Log("obtained");
      Destroy(gameObject);
        
      }

    }
}
