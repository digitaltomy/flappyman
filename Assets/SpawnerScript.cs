using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject chainsaws;
    public float spawnRate = 2;
    private float timer = 0;
    public float spawnSpace = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnChainsaw();
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
            spawnChainsaw();
            timer = 0;
        }
    }

    void spawnChainsaw()
    {
        float highest = transform.position.y + spawnSpace;
        float lowest = transform.position.y - spawnSpace;

        Instantiate(chainsaws, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);

    }
}
