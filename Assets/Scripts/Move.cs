using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public Transform Object;

    void Update()
    {
        Object.position += Vector3.left * speed *Time.deltaTime;
    }
}
