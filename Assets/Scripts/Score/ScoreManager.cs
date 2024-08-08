using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Scorespace
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI inputScore;
        [SerializeField] private TMP_InputField inputName;

        public UnityEvent<string, int> submitScoreEvent;


        public void SubmitScore()
        {
            if (inputName.text.Length > 8)
            {
                inputName.text = inputName.text.Substring(0, 8);
            }
            submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
        }
    }

}
