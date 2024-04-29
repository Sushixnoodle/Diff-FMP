using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public int Points;
    public int Exp;

    public Text PointsText;
    public Text ExpText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreasePoint(int value)
    {
        Points += value;
        PointsText.text = $"Points:{PointsText}";

    }

    public void IncreaseExp(int value)
    {
        Exp += value;
        ExpText.text = $"Points:{Exp}";
    }
}
