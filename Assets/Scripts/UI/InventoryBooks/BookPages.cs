using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookPages : MonoBehaviour
{
    [SerializeField]
    private BookItems spicesPrefab;

    [SerializeField]
    private RectTransform spicesPanel;

    [SerializeField]
    private BookItemDescription itemDescription;

    List<BookItems> listOfUISpices = new List<BookItems>();

    public Sprite image;
    public int quantity;
    public string description;

    private void Awake()
    {
        Hide();
        //itemDescription.ResetDescription();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        //itemDescription.ResetDescription();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}

// script lama dari tutor sunny valley
//public void InitializeBookUI(int booksize)
//{
//    for (int i = 0; i < booksize; i++)
//    {
//        BookItems uiSpices = Instantiate(spicesPrefab, Vector3.zero, Quaternion.identity);
//        uiSpices.transform.SetParent(spicesPanel);
//        listOfUISpices.Add(uiSpices);
//    }
//}