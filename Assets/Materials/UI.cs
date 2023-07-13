using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] Respawn Respawn;
    public TextMeshProUGUI Lives;

    void Update()
    {
        Lives.text = Respawn.lives.ToString();
    }
}
