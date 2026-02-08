using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    public int pointCount = 0;
    public AudioSource levelComplete;



    [SerializeField] private TMP_Text pointsText;

    void Start()
    {
        UpdateText();
    }

    public void AddPoint()
    {
        pointCount++;
        UpdateText();
        levelComplete.Play();
    }

    private void UpdateText()
    {
        if (pointsText != null)
            pointsText.text = "Points: " + pointCount;
    }
}
