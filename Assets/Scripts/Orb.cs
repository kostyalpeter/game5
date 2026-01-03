using UnityEditor.Build;
using UnityEngine;

public class Orb : MonoBehaviour
{
    Move move;
    public GameObject OrbObject;
    public static int CheckPoint;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OrbObject.SetActive(false);
            CheckPoint += 1;
            move.speed += 0.5f;
        }
    }
}
