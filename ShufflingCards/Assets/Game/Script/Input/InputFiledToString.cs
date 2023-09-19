using UnityEngine;
using TMPro;

public class InputFiledToString : MonoBehaviour
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField inputLevel;
    [SerializeField] TextMeshProUGUI textDisplay;

    public int selectionIndex = 0;

    public void StoreString() {
        textDisplay.text = inputName.text + ": " + inputLevel.text;

        inputName.Select();
        inputName.text = "";
        inputLevel.Select();
        inputLevel.text = "";
        
        selectionIndex = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
        {
            selectionIndex--;
            if (selectionIndex < 0) selectionIndex = 1;
            SelectInputField();
        }

        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectionIndex++;
            if (selectionIndex > 1) selectionIndex = 0;
            SelectInputField();
        }
    }

    private void SelectInputField()
    {
        switch (selectionIndex)
        {
            case 0: inputName.Select();
                break;
            case 1: inputLevel.Select();
                break;
        }
    }

    public void NameSelected() { selectionIndex = 0; }

    public void LevelSelected() { selectionIndex = 1; }
}
