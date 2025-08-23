using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MenuManager : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene(EventSystem.current.currentSelectedGameObject.name);
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}
