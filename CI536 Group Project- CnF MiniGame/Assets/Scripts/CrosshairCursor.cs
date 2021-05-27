using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairCursor : MonoBehaviour
{
    public Sprite defult;
    public Sprite Shoot;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseCursorPos;

        if (Input.GetMouseButton(0))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Shoot;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = defult;
        }

        if (Input.GetMouseButtonDown(0))
        {
         CoagulantManager.instance.RemoveCoagulant();
        }
    }
}