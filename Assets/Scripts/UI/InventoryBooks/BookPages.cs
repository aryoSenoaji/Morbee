using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPages : MonoBehaviour
{
    [SerializeField]
    private BookItems spicesPrefab;

    [SerializeField]
    private RectTransform spicesPanel;

    List<BookItems> listOfUISpices = new List<BookItems>();

    public void InitializeBookUI(int booksize)
    {
        for (int i = 0; i < booksize; i++) {
            BookItems uiSpices = Instantiate(spicesPrefab, Vector3.zero, Quaternion.identity);
            uiSpices.transform.SetParent(spicesPanel);
            listOfUISpices.Add(uiSpices);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
