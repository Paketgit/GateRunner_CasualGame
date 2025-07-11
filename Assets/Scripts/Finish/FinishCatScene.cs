using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Splines;

public class FinishCatScene : MonoBehaviour
{
    [SerializeField] private Transform _playerCatScenePosition;
    [SerializeField] private SplineAnimate _splineAnimate;
    [SerializeField] private PlayableDirector _playerDirector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.SetParent(_playerCatScenePosition);
            other.GetComponent<PlayerController>().enabled = false;
            other.transform.localPosition = Vector3.zero;
            _playerDirector.Play();
        }
    }

    public void StartCatScene()
    {
        _splineAnimate.Play();
    }
}
