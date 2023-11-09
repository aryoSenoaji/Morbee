using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MapLoader
{
    [SerializeField] private string mapName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoadMap(mapName);
        }
    }
}
