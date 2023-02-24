using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 20f;
    public static float PinSpeed;
    public Rigidbody2D rb;


    void Start()
    {

    }


    private void Update()
    {
        speed = DataManager.PinSpeed;
        if (!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed  * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if (col.tag == "Pin"){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
