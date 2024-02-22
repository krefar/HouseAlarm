using System.Collections;
using System.Collections.Generic;
using UnityEditor.Toolbars;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _opened;

    private void Awake()
    {
        _opened = false;
    }

    [ContextMenu("Toggle door")]
    public void Toggle()
    {
        _opened = !_opened;

        if (_opened)
        {
            transform.Rotate(0, 90, 0);
        }
        else
        {
            transform.Rotate(0, -90, 0);
        }
    }
}
