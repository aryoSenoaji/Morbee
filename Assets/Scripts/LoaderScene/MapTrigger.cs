using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapTrigger : MonoBehaviour
{
    public string mapName;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            //playerStorage.initialValue = playerPosition;
            if (SceneManager.GetActiveScene().name == "MapMain") 
            {
                ItemDatabase.instance.SavePlayerPosition(playerPosition);
            }
            SceneManager.LoadScene(mapName);
        }
    }
}
