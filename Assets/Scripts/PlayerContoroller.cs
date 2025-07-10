using UnityEngine;

public class PlayerContoroller : MonoBehaviour
{
    //CharacterController contorller; // <- дл€ физики, если прыжки ху€рить будем
    Transform axis;

    [SerializeField] public int value;
    void Start()
    {
        value = 0;
        axis = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        axis.position -= Vector3.forward;
    }
}
