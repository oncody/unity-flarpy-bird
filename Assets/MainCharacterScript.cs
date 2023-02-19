using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterScript : MonoBehaviour
{
    [SerializeField]
    private MainScript mainScript;

    [SerializeField]
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.gravityScale = mainScript.GetMainCharacterGravity();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * (mainScript.GetMainCharacterJumpHeight() + mainScript.GetMainCharacterGravity());
        }
    }
}
