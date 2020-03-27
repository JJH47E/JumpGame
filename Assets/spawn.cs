using UnityEngine;

using System.Collections;

public class spawn : MonoBehaviour
{

    public Transform spawner;
    public GameObject[] prefabs;
    public bool canSpawn;

    void Start() //Todo; check every frame if canSpawn bool is true (sets true every fixed amount of time). If true, spawn and set canSpawn to false.
    {
        Debug.Log("Test begun!");
        StartCoroutine(SpawnDelay(3f));
        Debug.Log("Start Process Finished");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    void SpawnObstacle()
    {
        int prefab_num = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[prefab_num], spawner.position, spawner.rotation);
        Debug.Log(prefabs[prefab_num].name + "Spawned!");
    }

    public IEnumerator SpawnDelay(float n)
    {
        while(canSpawn == true)
        {
            int prefab_num = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[prefab_num], spawner.position, spawner.rotation);
            Debug.Log(prefabs[prefab_num].name + "Spawned!");
            yield return new WaitForSeconds(n);
        }
    }
}
