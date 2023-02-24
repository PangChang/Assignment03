using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50f;
    public static float RotatorSpeed;

    private void Update()
    {
        speed = DataManager.RotatorSpeed;
        transform.Rotate(0f, 0f, RotatorSpeed + speed * Time.deltaTime);
    }
}
