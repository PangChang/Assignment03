using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static float PinSpeed = 20f;
    public Slider ChangePin;
    public Text ShowPinSpeed;

    public static float RotatorSpeed = 50f;
    public Slider ChangeRotator;
    public Text ShowRotatorSpeed;


    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayerName;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
        showPlayerName.text = PlayerName;
        
    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }


    public void AdjustSpeed()
    {
        PinSpeed = ChangePin.value;
        ShowPinSpeed.text = "The speed is: " + PinSpeed.ToString();

        RotatorSpeed = ChangeRotator.value;
        ShowRotatorSpeed.text = "The speed is: " + RotatorSpeed.ToString();

    }

}
