using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pencil : MonoBehaviour
{

    public bool isDraggable;
    public RectTransform rect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraggable)
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 0;
            rect.position = Camera.main.ScreenToWorldPoint(pos);
        } 
    }

    public void PrintPencil(string t)
    {
        Debug.Log(t);
    }

    public void OnMouseDown()
    {
        PrintPencil("On Mouse Down");
        isDraggable = true;
    }

    public void OnMouseUp()
    {
        PrintPencil("On Mouse Up");
        isDraggable = false;
    }

    public void OnMouseEnter()
    {
        PrintPencil("On Mouse Enter");
        Debug.Log("OK");
    }

    public void OnMouseUpAsButton()
    {
        Debug.Log("It works?");
    }

}
