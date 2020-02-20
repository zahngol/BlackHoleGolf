using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.GetComponent<Ball>().Equals(null))
        {
            Destroy(other.gameObject);
        }
    }
}
