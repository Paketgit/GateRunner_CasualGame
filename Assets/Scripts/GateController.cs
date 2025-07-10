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
        Debug.Log("True");
    }
}
