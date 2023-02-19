using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    private float timer = 0;

    [SerializeField]
    private float mainCharacterGravity;

    [SerializeField]
    private float mainCharacterJumpHeight;

    [SerializeField]
    private float terrainSlideLeftSpeed;

    [SerializeField]
    private float terrainSpawnRate;

    [SerializeField]
    private float terrainSpawnHeightOffset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    public float GetTimer()
    {
        return timer;
    }

    public float GetMainCharacterGravity()
    {
        return mainCharacterGravity;
    }

    public float GetMainCharacterJumpHeight() { 
        return mainCharacterJumpHeight;
    }

    public float GetTerrainSlideLeftSpeed()
    {
        return terrainSlideLeftSpeed;
    }

    public float GetTerrainSpawnRate()
    {
        return terrainSpawnRate;
    }

    public float GetTerrainSpawnHeightOffset()
    {
        return terrainSpawnHeightOffset;
    }
}
