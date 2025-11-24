using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
