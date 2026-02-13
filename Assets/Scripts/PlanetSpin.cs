using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    public float spdRot = 0.01f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spdRot);
    }
}
