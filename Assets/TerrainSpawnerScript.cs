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
        SpawnTerrain();
    }

    // Update is called once per frame
    void Update()
    {
        float timer = mainScript.GetTimer();
        float spawnRate = mainScript.GetTerrainSpawnRate();
        float adjustedTimer = timer / spawnIteration;

        if (adjustedTimer >= spawnRate)
        {
            spawnIteration++;
            SpawnTerrain();
        }
    }

    private void SpawnTerrain()
    {
        float highestPoint = transform.position.y + mainScript.GetTerrainSpawnHeightOffset();
        float lowestPoint = transform.position.y - mainScript.GetTerrainSpawnHeightOffset();

        GameObject newTerrain = Instantiate(terrain, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        newTerrain.GetComponent<TerrainScript>().InitializeMainScript(mainScript);
    }
}
