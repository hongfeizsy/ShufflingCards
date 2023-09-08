using UnityEngine;
using TMPro;

public class InputFiledToString : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] TextMeshProUGUI textDisplay;

    public void StoreString() {
        textDisplay.text = inputField.text;
    }
}
