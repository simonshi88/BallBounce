using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereOperation : MonoBehaviour
{
    public float Force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddForce(Vector3.up * Force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Color color = GetRandomColor();

        this.GetComponent<Renderer>().material.color = color;

    }


    public Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
