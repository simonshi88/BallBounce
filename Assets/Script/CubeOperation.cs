using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOperation : MonoBehaviour
{

    public GameObject Sphere;

    public Transform BirthPoint;

    public Material Blue;
    public Material Green;

    public List<GameObject> Walls;

    List<GameObject> Spheres;

    // Start is called before the first frame update
    void Start()
    {
        Spheres = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Spheres.Count > 10)
            ChangeMaterial(Walls, Blue);

        if (Spheres.Count > 30)
            ChangeMaterial(Walls, Green);

    }

    private void OnTriggerEnter(Collider other)
    {
        Color color = GetRandomColor();
        GetComponent<Renderer>().material.color = color;

        GameObject newSphere = Instantiate(Sphere, BirthPoint.position, Quaternion.identity);

        Spheres.Add(newSphere);
    }


    public Color GetRandomColor()
    {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.25f);
    }


    void ChangeMaterial(List<GameObject> walls, Material material)
    {
        foreach (var wall in walls)
        {
            wall.GetComponent<MeshRenderer>().material = new Material(material);
        }
    }

}
