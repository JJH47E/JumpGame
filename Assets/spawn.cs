using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class spawn : MonoBehaviour
{

    public Transform spawner;
    public GameObject[] prefabs;
    public bool canSpawn;
    public int score;
    private Text counter;

    void Start() //Todo; check every frame if canSpawn bool is true (sets true every fixed amount of time). If true, spawn and set canSpawn to false.
    {
        Debug.Log("Test begun!");
        StartCoroutine(SpawnDelay(2f));
        counter = GameObject.Find("Score").GetComponent<Text>();
        counter.text = "0";
        counter.color = Color.white;
        Debug.Log("Start Process Finished");
        StartCoroutine(ScoreCounter());
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

    }

    public IEnumerator SpawnDelay(float n)
    {
        while(canSpawn == true)
        {
            int prefab_num = Random.Range(0, prefabs.Length);
            //Instantiate(prefabs[prefab_num], spawner.position, spawner.rotation);
            SpawnAndDestroy(prefabs[prefab_num], 5f);
            Debug.Log(prefabs[prefab_num].name + "Spawned!");
            yield return new WaitForSeconds(n);
        }
    }

    void SpawnAndDestroy(GameObject prefab, float delay)
    {
        GameObject newGO = Instantiate(prefab, spawner.position, spawner.rotation) as GameObject;
        Destroy(newGO, delay);
    }

    public IEnumerator ScoreCounter()
    {
        while(canSpawn == true)
        {
            score += 1;
            Debug.Log("Score is: " + score);
            counter.text = score.ToString();
            PlayerPrefs.SetInt("Score", score);
            yield return new WaitForSeconds(1f);
        }
    }
}
