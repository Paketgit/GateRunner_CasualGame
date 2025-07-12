using UnityEngine;
using TMPro;
public class GateController : MonoBehaviour
{
    [SerializeField] private TextMeshPro textGateValue;

    [Space]

    [SerializeField] public int gateValue;

    [Space]
    [Header("Operatinos")]
    [SerializeField] public bool addition;
    [SerializeField] public bool subtraction;
    [SerializeField] public bool multiplication;
    [SerializeField] public bool division;

    public delegate void ScoreChange(int newScore);
    public static ScoreChange ScoreChangeEvent;

    void Start()
    {
        if (addition) textGateValue.text = "+" + gateValue.ToString();
        else if (subtraction) textGateValue.text = "-" + gateValue.ToString();
        else if (multiplication) textGateValue.text = "*" + gateValue.ToString();
        else if (division) textGateValue.text = "÷" + gateValue.ToString(); //"÷"

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerData = other.GetComponent<PlayerController>();

            if (playerData == null) { return; }
            
            if (addition) { playerData.value = playerData.value += gateValue; }
            else if (subtraction) { playerData.value = playerData.value -= gateValue; }
            else if (multiplication) { playerData.value = playerData.value *= gateValue; }
            else if (division) { playerData.value = playerData.value /= gateValue; }

            if (playerData.value < 0) { playerData.value = 0; }

            playerData.setSize();

            ScoreChangeEvent?.Invoke(playerData.value);

            //Debug.Log(playerData.value);
        }
    }
}
