using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
	public int score = 0;
    private void Awake()
    {
        Instance = this;
    }

    public void IncrementScore()
    {
		score += 1;
    }
}
