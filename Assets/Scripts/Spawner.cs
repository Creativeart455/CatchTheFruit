using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] fruits;
    public GameObject bomb;

    public float xbounds, ybound;
    void Start()
    {
        StartCoroutine(spawnRandomGameObject());
    }

    IEnumerator spawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomFruit = Random.Range(0, fruits.Length);

        if(Random.value <= .6f)
        {
            Instantiate(fruits[randomFruit],new Vector2(Random.Range(-xbounds,xbounds),ybound),Quaternion.identity);
        }
        else
        {
            Instantiate(bomb, new Vector2(Random.Range(-xbounds, xbounds), ybound), Quaternion.identity);
        }
        StartCoroutine(spawnRandomGameObject());
    }

 
}
