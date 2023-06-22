using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] towers = {0, 1};
    public int[] units = {0, 1};
    public int health = 100;

    public GameObject[] towerPrefabs;
    public GameObject[] unitPrefabs;

    public List<int> availableTowers = new List<int>();
    public List<int> availableUnits = new List<int>();
    
    public int nextTower = 0;
    public int nextUnit = 0;

    // Start is called before the first frame update
    void Start()
    {
        availableTowers.Add(towers[Random.Range(0, towers.Length)]);
        availableUnits.Add(units[Random.Range(0, units.Length)]);
        nextTower = towers[Random.Range(0, towers.Length)];
        nextUnit = towers[Random.Range(0, towers.Length)];


        foreach (var x in availableTowers)
        {
            Debug.Log(x.ToString());
        }

        foreach (var x in availableUnits)
        {
            Debug.Log(x.ToString());
        }

        Debug.Log(nextTower);
        Debug.Log(nextUnit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
