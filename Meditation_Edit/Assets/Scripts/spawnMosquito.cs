using UnityEngine;
using System.Collections;

public class spawnMosquito : MonoBehaviour
{
    public GameObject prefab; 
    public float minSpawnTime = 3.0f;
    public float maxSpawnTime = 5.0f;
    public float distFromCamera = 10.0f;

    private float timer = 0.0f;
    private float nextTime;

    void Start()
    {
        nextTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > nextTime)
        {
            Vector3 pos = new Vector3(Random.value, Random.value, distFromCamera);
            pos = Camera.main.ViewportToWorldPoint(pos);

            Instantiate(prefab, pos, Quaternion.identity);

            Debug.Log("Object created");

            timer = 0.0f;
            nextTime = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}
