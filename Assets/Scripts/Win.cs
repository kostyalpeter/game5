using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    public TMP_Text WinText;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            WinText.gameObject.SetActive(true);
        }
    }
}