using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dial : MonoBehaviour
{
    [SerializeReference] private float _speed;
    
    private void Update()
    {
        transform.Rotate(_speed * Vector3.up * Time.deltaTime);
    }
}
