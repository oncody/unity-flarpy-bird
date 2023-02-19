using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TerrainSpawnerScript : MonoBehaviour
{
    [SerializeField]
    private MainScript mainScript;

    [SerializeField]
    private GameObject terrain;

    private float spawnIteration = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timer = mainScript.GetTimer();
        float spawnRate = mainScript.GetTerrainSpawnRate();
        float adjustedTimer = timer / spawnIteration;
        Debug.Log($"Timer: {timer}, Spawn Rate: {spawnRate}, Adjusted Timer: {adjustedTimer}, Iteration: {spawnIteration}");

        if (adjustedTimer >= spawnRate)
        {
            Debug.Log($"INSIDEEEEE");
            spawnIteration++;
            GameObject newTerrain = Instantiate(terrain, transform.position, transform.rotation);
            newTerrain.GetComponent<TerrainScript>().InitializeMainScript(mainScript);
        }
    }
}
