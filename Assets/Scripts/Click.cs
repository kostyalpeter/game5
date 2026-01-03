using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource src;
    public AudioClip ClickSound;
    public void Start()
    {
        src.PlayOneShot(ClickSound);
        Time.timeScale = 1f;
        Orb.CheckPoint = 0;
        PlusPoint.PlusPoints = 0;
    }
    public void Clicking()
    {
        src.PlayOneShot(ClickSound);
    }

}
