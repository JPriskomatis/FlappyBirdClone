using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreInput : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputScore;

    [SerializeField] private TMP_InputField inputName;

    public UnityEvent<string, int> submitScore;


    public void SubmitScore()
    {
        submitScore.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
