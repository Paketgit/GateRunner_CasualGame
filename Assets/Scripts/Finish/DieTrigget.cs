using UnityEngine;

public class DieTrigget : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _particleSystem.Play();
        }
    }
}
