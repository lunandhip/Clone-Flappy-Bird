using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletor : MonoBehaviour
{
    private Rigidbody2D col;
    private void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }

}
