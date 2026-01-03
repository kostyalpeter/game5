using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    public AudioSource src;
    public AudioClip ClickSound;
    public TMP_Text WinText;

    public void Start()
    {
        src.PlayOneShot(ClickSound);
        Time.timeScale = 1f;
        Orb.CheckPoint = 0;
        PlusPoint.PlusPoints = 0;
        WinText.gameObject.SetActive(false);
    }
    public void Clicking()
    {
        src.PlayOneShot(ClickSound);
    }

}
