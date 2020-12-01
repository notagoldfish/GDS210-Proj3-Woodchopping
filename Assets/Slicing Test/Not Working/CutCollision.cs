using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCollision : MonoBehaviour
{
    //private void OnTriggerEnter(Collision collision)
    //{
    //    CubeCut.Cut(collision.transform, transform.position);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    CubeCut.Cut(other.transform, transform.position);
    //}
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Woodchops"))
        {
            CubeCut.Cut(other.transform, transform.position);
        }
    }
}
