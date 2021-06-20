using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    // delays next car to spawn by .3s
    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;
    public Transform[] spawnPoints;

    // this loop spawns cars infinitely, using the spawnDealy to have them come in intervals rather than all at once
    private void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    // this spawns a car at a random spawn point,
    // using the spawn points position and rotation to place and properly move the car
    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        ObjectPooler.Instance.SpawnFromPool("Car", spawnPoint.position, spawnPoint.rotation);
    }
}
