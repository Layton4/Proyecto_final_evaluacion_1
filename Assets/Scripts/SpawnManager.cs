using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Obstacleprefab;
    private float xRange = 200;
    private float ylim_sup = 200;
    private float ylim_inf = 0;
    private float zRange = 200;
    private Vector3 SpawnPosition = new Vector3(0, 0, 30);
    public float tiempo_start = 0.5f;
    public float tiempo_repetición = 5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnABomb", 0.5f, 5);
    }
    public Vector3 RandomSpawnPosition() //función para conseguir una localización aleatoria, Vector3, para el obstáculo
    {
        float randoX = Random.Range(-xRange,xRange);
        float randoY = Random.Range(ylim_inf, ylim_sup);
        float randoZ = Random.Range(-zRange, zRange);
        return new Vector3(randoX,randoY,randoZ);
    }

    public void SpawnABomb()
    {
        SpawnPosition = RandomSpawnPosition();
        Instantiate(Obstacleprefab, SpawnPosition, Obstacleprefab.transform.rotation);
    }
}
