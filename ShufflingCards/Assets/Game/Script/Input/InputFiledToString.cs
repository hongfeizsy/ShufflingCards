using UnityEngine;
using TMPro;

public class InputFiledToString : MonoBehaviour
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField inputLevel;
    [SerializeField] TextMeshProUGUI textDisplay;

    public int inputSelected = 0;

    public void StoreString() {
        textDisplay.text = inputName.text + ": " + inputLevel.text;
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            inputSelected--;
            if (inputSelected < 0) inputSelected = 1;
            SelectInputField();
        }

        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            inputSelected++;
            if (inputSelected > 1) inputSelected = 0;
            SelectInputField();
        }
    }

    private void SelectInputField()
    {
        switch (inputSelected)
        {
            case 0: inputName.Select();
                break;
            case 1: inputLevel.Select();
                break;
        }
    }
}
