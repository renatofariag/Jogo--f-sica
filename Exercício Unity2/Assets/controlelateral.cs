using System;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class controlelateral : MonoBehaviour
{
    public Vector3 direcao;
    public float velocidade;
    Rigidbody rb;

    public Material Gato;
    public Material Cachorro;
    public GameObject vcvenceu;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {        
        direcao = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Gato>() != null)
        {
            Morre();
        }

    }
    private void Morre()
    {
        Destroy(gameObject);
    }

}
