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
    public float tiempo_start = 0.5f;
    public float tiempo_repetición = 5f;
    private Vector3 SpawnPosition = new Vector3(0, 0, 30);

    void Start()
    {
        InvokeRepeating("SpawnAObject", tiempo_start, tiempo_repetición);
    }
    public Vector3 RandomSpawnPosition() //función para conseguir una localización aleatoria, Vector3, para el obstáculo
    {
        float randoX = Random.Range(-xRange,xRange);
        float randoY = Random.Range(ylim_inf, ylim_sup);
        float randoZ = Random.Range(-zRange, zRange);
        return new Vector3(randoX,randoY,randoZ);
    }
    public void SpawnAObject()
    {
        SpawnPosition = RandomSpawnPosition();
        Instantiate(Obstacleprefab, SpawnPosition, Obstacleprefab.transform.rotation);
    }
}
