using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] Door _door;

    private void OnTriggerEnter(Collider other)
    {
        _door.Toggle();
    }

    private void OnTriggerExit(Collider other)
    {
        _door.Toggle();
    }
}
