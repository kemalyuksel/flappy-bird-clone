using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{

    public GameObject pipePrefab;
    public float minY;
    public float maxY;
    public float x;
    public float interval;

    void Start()
    {
        InvokeRepeating("Spawn", interval, interval);
    }


    void Update()
    {

    }

    private void Spawn()
    {
        GameObject instance = Instantiate(pipePrefab);
        instance.transform.position = new Vector2(x, Random.Range(minY, maxY));
    }

}
