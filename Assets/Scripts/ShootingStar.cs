using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public float spdX = 0.01f;
    public float spdY = 0.01f;
    public float reduction = 0.01f;
    public bool canMove = true;

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            transform.Translate(spdX, spdY, 0);

            float newSize = transform.localScale.x - reduction;
            transform.localScale = new Vector3(newSize, newSize, newSize);

            if(transform.localScale.x <= 0)
            {
                canMove = false;
            }   
        }
    }
}
