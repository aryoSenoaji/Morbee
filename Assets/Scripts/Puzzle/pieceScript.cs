using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PieceScript : MonoBehaviour
{
    private Vector3 CorrectPosition;
    public bool InTruePosition;
    public bool Selected;
    //public bool AllPieceInCurrentPosition;
    // Start is called before the first frame update
    void Start()
    {
        CorrectPosition = transform.position;
        transform.position= new Vector3(Random.Range(2f,8f), Random.Range(4.2f,-3f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, CorrectPosition)< 0.5f)
        {
            if (!Selected)
            {
                if(InTruePosition == false)
                {
                    transform.position = CorrectPosition;
                    InTruePosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragAndDrop>().TotalPiece++;
                }
            }
        }  
        
    }
}
