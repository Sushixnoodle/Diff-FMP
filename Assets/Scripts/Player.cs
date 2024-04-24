using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public int Points;
    public int EXP;

    public Text PointsText;
    public Text ExpText;

    private void Awake()
    {
        Instance = this;
    }

    public void IncreasePoint(int value)
    {

    }
}
