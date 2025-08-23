using UnityEngine;

public class SkinSwaper : MonoBehaviour
{

    [SerializeField] GameObject[] skins;
    
    static string choose = "pig_white";

    void Start()
    {
        for (int i = 0; i < skins.Length; i++)
        {
            skins[i].SetActive(false);
            if (skins[i].name == choose)
                skins[i].SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
