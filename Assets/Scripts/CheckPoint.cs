using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CheckPoint : MonoBehaviour
{
    public GameObject restart;
    public GameObject Checkpoint;
    public GameObject Menu;
    public GameObject PlayerUp;
    public GameObject PlayerDown;

    public Transform Map;
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void CheckPoints()
    {
        if (Orb.CheckPoint == 1)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-40.93f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 2)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-76.57f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 3)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-112.78f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 4)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-148.05f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 5)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-184f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 6)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-220f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 7)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-255.4f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 8)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-290.3f, -0.27957f, 0);
            PlayerUp.SetActive(false);
            PlayerDown.SetActive(true);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
        if (Orb.CheckPoint == 9)
        {
            Time.timeScale = 1f;
            Map.position = new Vector3(-322.5f, -0.27957f, 0);
            PlayerUp.SetActive(true);
            PlayerDown.SetActive(false);
            restart.SetActive(false);
            Checkpoint.SetActive(false);
            Menu.SetActive(false);
        }
    }
}
