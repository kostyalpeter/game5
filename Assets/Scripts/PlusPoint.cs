using UnityEngine;

public class PlusPoint : MonoBehaviour
{
    public static int PlusPoints;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlusPoints += 1;
            gameObject.SetActive(false);
        }
    }
}
