using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void LateUpdate ()
    {
        this.gameObject.transform.RotateAround (Vector3.zero, Vector3.down, 10f * Time.deltaTime);
    }
}
