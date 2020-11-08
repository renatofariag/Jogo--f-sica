using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class camerafollower : MonoBehaviour{

    public Transform target;

    public float smoothSpeed = 0.125f; // quanto maior mais rápido
    public Vector3 offset;
    void LateUpdate ()
    {
        transform.position = target.position + offset;
    }
}
