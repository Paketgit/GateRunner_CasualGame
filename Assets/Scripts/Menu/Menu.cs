using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;



    private void Awake()
    {
        _menuPanel.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_menuPanel.activeSelf)
        {
            _menuPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ClickButton()
    {
        Time.timeScale = 1f;
        _menuPanel.SetActive(false);
    }
}
