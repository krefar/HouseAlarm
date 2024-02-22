using System.Collections;
using System.Collections.Generic;
using UnityEditor.Toolbars;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private float _openSpeed;

    private bool _opened;

    private void Awake()
    {
        _opened = false;
    }

    private void Update()
    {
        if (_opened)
        {
            if (transform.rotation.y != 90)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), _openSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (transform.rotation.y != 0)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), _openSpeed * Time.deltaTime);
            }
        }

    }

    [ContextMenu("Toggle door")]
    public void Toggle()
    {
        _opened = !_opened;
    }
}
