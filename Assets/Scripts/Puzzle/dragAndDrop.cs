using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour
{
    //public Sprite[] Niveles; //level
    public GameObject SelectedPiece;
    int orderInLayer = 1;
    public int TotalPiece = 0; //bagian yang saling mengunci
    public int TotalPieceForWin;
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 36; i++)
        //{
        //    GameObject.Find("Pieces("+ i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Niveles[PlayerPrefs.GetInt("Nivel")];
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<PieceScript>().InTruePosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PieceScript>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = orderInLayer;
                    orderInLayer++;
                }
            }
        }
            
        if(Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PieceScript>().Selected = false;
                SelectedPiece = null;
            }
        }

        if(SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }

        if(TotalPiece == TotalPieceForWin)
        {
            SceneManager.LoadScene("MapMain");
        }
    }
}
