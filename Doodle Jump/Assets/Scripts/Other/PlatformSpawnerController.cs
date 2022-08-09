using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnerController : MonoBehaviour
{

    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private float spawnerSpeed;
    [SerializeField] private float limitX;
    [SerializeField] private float interval;


    void Start()
    {
        InvokeRepeating("SetPlatformSpawner", interval, interval);
    }



    void Update()
    {
        SetPlatformSpawnerTransform();
    }



    private void SetPlatformSpawnerTransform()
    {
        transform.position += Vector3.up * spawnerSpeed * Time.deltaTime;
    }



    private void SetPlatformSpawner()
    {
        GameObject newPlatform = Instantiate(platformPrefab);
        newPlatform.transform.position = new Vector2(Random.Range(-limitX, limitX), transform.position.y + (Random.Range(0.5f, 1f)));
    }
}
