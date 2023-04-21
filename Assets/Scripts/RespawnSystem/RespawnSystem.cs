using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSystem : MonoBehaviour
{
    public Vector3 SpawnPoint;
    public GameObject Player;
    [SerializeField]
    private GameObject SpawnPointObject;

    public bool RespawnPlayerAtDepth;

    // Start is called before the first frame update
    void Start()
    {
        if (SpawnPointObject != null)
            SpawnPoint = SpawnPointObject.transform.position;

        if(Player == null)
        {
            //Player = Instantiate(PlayerPrefab, SpawnPoint, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!Player.activeSelf)
            Player.SetActive(true);
    }

    public void RespawnPlayer()
    {
        Player.SetActive(false);
        Player.transform.position = SpawnPoint;
    }

    public void SetSpawnPoint(Vector3 spawnPoint)
    {
        SpawnPoint = spawnPoint;
    }

    public void SetAsSpawnPoint(GameObject spawnPoint)
    {
        SpawnPoint = spawnPoint.transform.position;
    }
}
