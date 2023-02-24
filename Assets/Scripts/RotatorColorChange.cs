using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatorColorChange : MonoBehaviour
{
    public Dropdown RotatorColorDropdown;
    public Text RotatorColorText;
    public GameObject Rotator;

    // Start is called before the first frame update
    void Start()
    {
        Rotator.GetComponent<SpriteRenderer>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseRotatorColor()
    {
        switch (RotatorColorDropdown.value)
        {
            case 1:
                RotatorColorText.text = RotatorColorDropdown.options[1].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 2:
                RotatorColorText.text = RotatorColorDropdown.options[2].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case 3:
                RotatorColorText.text = RotatorColorDropdown.options[3].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            default:
                RotatorColorText.text = RotatorColorDropdown.options[0].text;
                Rotator.GetComponent<SpriteRenderer>().color = Color.black;
                break;
        }
    }
}
