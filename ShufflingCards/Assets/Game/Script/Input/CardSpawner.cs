using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CardSpawner : MonoBehaviour
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] TMP_InputField inputLevel;
    [SerializeField] TMP_InputField inputGender;
    [SerializeField] Button enterButton;

    public int selectionIndex = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectionIndex++;
            if (selectionIndex > 3) selectionIndex = 0;
            SelectInputField();
        }
    }

    private void SelectInputField()
    {
        switch (selectionIndex)
        {
            case 0:
                inputName.Select();
                break;
            case 1:
                inputLevel.Select();
                break;
            case 2:
                inputGender.Select();
                break;
            case 3:
                enterButton.Select();
                break;
        }
    }

    public void NameSelected() { selectionIndex = 0; }

    public void LevelSelected() { selectionIndex = 1; }

    public void GenderSelected() { selectionIndex = 2; }

    public void SpawnCard() 
    {
        Debug.Log(inputName.text + ", " + inputLevel.text + ", " + inputGender.text);

        inputName.Select();
        inputName.text = "";
        inputLevel.Select();
        inputLevel.text = "";
        inputGender.Select();
        inputGender.text = "";

        selectionIndex = 0;
    }
}
