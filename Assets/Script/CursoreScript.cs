using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursoreScript : MonoBehaviour
{
    public Texture2D[] cursors;
    void Start()
    {
        DefaultCursore();

    }

    public void DefaultCursore()
    {
        Cursor.SetCursor(cursors[0], Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnButton()
    {
        Cursor.SetCursor(cursors[1], Vector2.zero, CursorMode.ForceSoftware);
    }

    public void ClickedButton()
    {
        Cursor.SetCursor(cursors[2], Vector2.zero, CursorMode.ForceSoftware);
    } 
    public void OnObject()
    {
        Cursor.SetCursor(cursors[3], Vector2.zero, CursorMode.ForceSoftware);
    }
}
