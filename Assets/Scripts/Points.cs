using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TMP_Text ScoreText;
    public int time;
    public TMP_Text PlusPointsText;
    public float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 1f)
        {
            time += 1;
            timer = 0f;
        }
        ScoreText.text = time.ToString("0");
        PlusPointsText.text = PlusPoint.PlusPoints.ToString("0");
    }
}
