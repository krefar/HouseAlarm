using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMover : MonoBehaviour
{
    private int _currentPointIndex = 0;

    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _rotationSpeed = 10f;

    void Update()
    {
        if (transform.position == _points[_currentPointIndex].position)
        {
            _currentPointIndex = (_currentPointIndex + 1) % _points.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPointIndex].position, _speed * Time.deltaTime);

        var direction =  _points[_currentPointIndex].position - transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), _rotationSpeed * Time.deltaTime);
    }
}
