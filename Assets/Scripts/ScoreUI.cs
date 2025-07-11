using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreUI : MonoBehaviour
{
    private TextMeshProUGUI _textUI;

    private void Awake()
    {
        _textUI = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        GateController.ScoreChangeEvent += ChangeText;
    }

    void ChangeText(int newScore)
    {
        _textUI.text = newScore.ToString();
    }

    private void OnDisable()
    {
        GateController.ScoreChangeEvent -= ChangeText;
    }
}
