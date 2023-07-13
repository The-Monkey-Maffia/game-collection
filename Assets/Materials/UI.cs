using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public Respawn Respawn;
    public TextMeshProUGUI lives;
    void Start()
    {
        
    }

    void Update()
    {
        lives.text = Respawn.lives.ToString();
    }
}
