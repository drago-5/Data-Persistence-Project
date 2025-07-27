using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetInputFieldText : MonoBehaviour
{

    public TMP_InputField nameInputField;

    private void Start()
    {
        nameInputField.onEndEdit.AddListener(SubmitName);
    }

    private void SubmitName(string name)
    {
        Debug.Log("username set to: " + name);
        DataManager.Instance.tempPlayerName = name;
    }
}
