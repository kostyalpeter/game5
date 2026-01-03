using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject restart;
    public GameObject Checkpoint;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            restart.SetActive(true);
            Checkpoint.SetActive(true);
        }
    }
}
