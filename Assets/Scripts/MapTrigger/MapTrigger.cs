using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapTrigger : MapLoader
{
    [SerializeField] public string mapName;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SceneManager.LoadScene(mapName);
        }
    }
}
