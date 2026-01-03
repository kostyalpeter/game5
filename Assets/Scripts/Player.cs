using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject PlayerUp;
    public GameObject PlayerDown;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if(PlayerDown.activeSelf && Time.timeScale == 1)
            {
                PlayerDown.SetActive(false);
                PlayerUp.SetActive(true);
            }
            else if(PlayerUp.activeSelf && Time.timeScale == 1)
            {
                PlayerDown.SetActive(true);
                PlayerUp.SetActive(false);
            }
        }
    }
}
