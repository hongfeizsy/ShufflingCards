using UnityEngine;
using TMPro;

public class InputFiledToString : MonoBehaviour
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField inputLevel;
    [SerializeField] TextMeshProUGUI textDisplay;

    public void StoreString() {
        textDisplay.text = inputName.text + ": " + inputLevel.text;
    }
}
