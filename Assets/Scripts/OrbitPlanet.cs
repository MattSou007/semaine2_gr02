using UnityEngine;

public class OrbitPlanet : MonoBehaviour
{
    public float spdRot = 0.01f;
    public GameObject planetTarget;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(planetTarget.transform.position, Vector3.forward, spdRot);
    }
}
