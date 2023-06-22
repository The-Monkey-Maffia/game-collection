using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] towers = {0, 1};
    public int[] units = {0, 1};
    public int health = 100;

    public List<int> availableTowers = new List<int>();
    public List<int> availableUnits = new List<int>();
    
    public int nextTower = 0;
    public int nextUnit = 0;

    // Start is called before the first frame update
    void Start()
    {
        availableTowers.Add();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
