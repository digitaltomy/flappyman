using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    public GameObject coin;
    public GameObject redcoin;
    public GameObject greencoin;
    public float spawnRate = 3;
    private float timer = 0;
    public float spawnSpace = 10;

    private float selectcoin = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) 
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnCoin();
            timer = 0;
        }
    }

    void spawnCoin()
    {
        float highest = transform.position.y + spawnSpace;
        float lowest = transform.position.y - spawnSpace;
        selectcoin = Random.Range(1, 99);
        if ( 1 <= selectcoin & selectcoin < 20)
        {
            Debug.Log("NoCoin Num:" + selectcoin);
        }
        else
        {

            if (20 <= selectcoin & selectcoin < 50)
            {
                Debug.Log("NormalCoin Num:" + selectcoin);
                Instantiate(coin, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
            }
            else
            {
                if (50 <= selectcoin & selectcoin < 85)
                {
                    Debug.Log("GreenCoin Num:" + selectcoin);
                    Instantiate(greencoin, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
                }
                else
                {
                    if (85 <= selectcoin & selectcoin < 99)
                    {
                        Debug.Log("RedCoin Num:" + selectcoin);
                        Instantiate(redcoin, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
