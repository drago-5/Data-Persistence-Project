using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNameAndScore : MonoBehaviour
{

    public TextMeshProUGUI highScoreUI;

    // Start is called before the first frame update
    void Start()
    {
        highScoreUI.text = "Best Score -- " + DataManager.Instance.playerName + " : " + DataManager.Instance.highScore;
    }
}
