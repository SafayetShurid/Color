using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    private bool isDraggable = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraggable)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
    }

    private void OnMouseDown()
    {
        isDraggable = true;
    }

    private void OnMouseUp()
    {
        isDraggable = false;
    }
}
