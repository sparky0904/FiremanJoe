using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friendly : MonoBehaviour
{
    private Rigidbody rb;

    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;

        StartCoroutine(Launch());
    }

    // Update is called once per frame
    private void Update()
    {
    }

    // Launch the friendly
    private IEnumerator Launch()
    {
        yield return new WaitForSeconds(1);

        rb.isKinematic = false;
    }
}