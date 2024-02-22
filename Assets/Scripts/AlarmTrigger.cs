using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    private float _soundIncreaseRate = 0.003f;

    private void Awake()
    {
        _sound.volume = 0.1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        _sound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(StopSound());
    }

    private IEnumerator StopSound()
    {
        var wait = new WaitForEndOfFrame();

        while (_sound.volume > 0)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, 0, _soundIncreaseRate);

            yield return wait;
        }

        _sound.Stop();
    }

    private void OnTriggerStay(Collider other)
    {
        _sound.volume = Mathf.MoveTowards(_sound.volume, 1.0f, _soundIncreaseRate);
    }
}
