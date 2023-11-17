using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class pieceScript : MonoBehaviour
{
    private Vector3 randomPosition;
    public bool InrandomPosition;
    public bool Selected;
    // Start is called before the first frame update
    void Start()
    {
        randomPosition = transform.position;
        transform.position= new Vector3(Random.Range(2f,8f), Random.Range(4.2f,-3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, randomPosition)< 0.5f)
        {
            if (!Selected)
            {
                if(InrandomPosition == false)
                {
                    transform.position = randomPosition;
                    InrandomPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }
        }
    }
}
