using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RespawnSystem))]
public class RespawnPlayerAtDepth : MonoBehaviour
{
    private RespawnSystem respawnSystem;
    public float KillDepth = -100f;

    private void Start()
    {
        respawnSystem = GetComponent<RespawnSystem>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (respawnSystem.Player.transform.position.y <= KillDepth)
        {
            respawnSystem.RespawnPlayer();
        }
    }
}
