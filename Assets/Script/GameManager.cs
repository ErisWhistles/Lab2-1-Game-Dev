using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour    {
public static GameManager Instance { get; private set; }
public int score = 0;
public float playerHealth=100;
public float gameTime = 90;
    private void Awake(){
        Instance = this;
    }
}

