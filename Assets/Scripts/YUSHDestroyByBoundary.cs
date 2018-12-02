using UnityEngine;
using System.Collections;

public class YUSHDestroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
