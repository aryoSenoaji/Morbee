using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PieceScript : MonoBehaviour
{
    private Vector3 randomPosition;
    public bool InTruePosition;
    public bool Selected;
    public bool AllPieceInCurrentPosition;
    // Start is called before the first frame update
    void Start()
    {
        randomPosition = transform.position;
        transform.position= new Vector3(Random.Range(2f,8f), Random.Range(4.2f,-3f));
    }

    // Update is called once per frame
    void Update()
    {
        if(AllPieceInCurrentPosition == false)
        {
            if (Vector3.Distance(transform.position, randomPosition)< 0.5f)
            {
                if (!Selected)
                {
                    if(InTruePosition == false)
                    {
                        transform.position = randomPosition;
                        InTruePosition = true;
                        GetComponent<SortingGroup>().sortingOrder = 0;
                    }
                }
            }  
        }
        if(InTruePosition == true)
        {
            SceneManager.LoadScene("MapMain");
        }
    }
}
