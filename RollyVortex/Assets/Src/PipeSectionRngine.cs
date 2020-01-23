using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSectionRngine : MonoBehaviour
{

    public float Speed = -1f;

    void Update()
    {
        transform.Translate(Vector3.forward * Speed);
    }
}
