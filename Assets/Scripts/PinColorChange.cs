using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinColorChange : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Text ColorText;
    public GameObject Pin;

    // Start is called before the first frame update
    void Start()
    {
        Pin.GetComponent<SpriteRenderer>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                Pin.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                Pin.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                Pin.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                Pin.GetComponent<SpriteRenderer>().color = Color.black;
                break;
        }
    }
}