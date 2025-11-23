using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeReference] private float _speed;
    
    void Update()
    {
        transform.Rotate(_speed * Vector3.up * Time.deltaTime);
    }
}
