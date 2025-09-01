using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _growSpeed = 0.5f;

     private void Update()
    {
        transform.localScale += Vector3.one * _growSpeed * Time.deltaTime;
    }
}
