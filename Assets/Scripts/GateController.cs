using UnityEngine;
using TMPro;
public class GateController : MonoBehaviour
{
    [SerializeField] private TextMeshPro textGateValue;

    [Space]

    [SerializeField] public int gateValue;
    void Start()
    {
        textGateValue.text = "+" + gateValue.ToString();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            PlayerController playerData = other.GetComponent<PlayerController>();
            if (playerData == null) { return; }
            playerData.value = playerData.value += gateValue;
            Debug.Log(playerData.value);
        }
    }
}
