using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    private MainScript mainScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * mainScript.GetTerrainSlideLeftSpeed() * Time.deltaTime;
    }

    public void InitializeMainScript(MainScript mainScript)
    {
        this.mainScript = mainScript;
    }
}
