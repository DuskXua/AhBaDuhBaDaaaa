using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayerAtDepth : MonoBehaviour
{
    public RespawnSystem respawnSystem;
    public GameObject RespawnPoint;
    public float KillDepth = -100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y <= KillDepth)
        {
            respawnSystem.RespawnPlayer();
        }
    }
}
