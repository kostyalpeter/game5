using UnityEngine;

public class Die : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
        }
    }
}
