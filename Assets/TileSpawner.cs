using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TileSpawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject tilePrefab;


    public int[] Indexes;
    public List<int> apple;

    public float timeBetweenSpawns = 1f;
    public float timeToSpawn = 2f;

  
    public InputField inputField;

    int i = 0;
    int a = 0;
    int y;
    string s;

    public Button button;

    public void Awake()
    {
        //DontDestroyOnLoad();
    }

    private void Start()
    {
       
        y = SceneManager.GetActiveScene().buildIndex;
        

    }



    // Update is called once per frame
    void Update () {

        //InputToArray();

        if (y != 0)
        {
            TimeToSpawn();
        }

    }

    public void TimeToSpawn()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnTiles();

            timeToSpawn = Time.time + timeBetweenSpawns;

            i++;
            if (i >= Indexes.Length)
            {
                i = 0;
            }
        }
    }


    public void SpawnTiles()
    {
        // For Random //
        //int randomIndex = Random.Range(0, spawnPoints.Length);

        //Instantiate(tilePrefab, spawnPoints[randomIndex].position, Quaternion.identity);


        // For predefined //
        Instantiate(tilePrefab, spawnPoints[Indexes[i]].position, Quaternion.identity);        
    }


    public void InputToArray()
    {
        string s = inputField.text; 

        foreach (char c in s)
        {
            
            string n = c.ToString();
            int p = int.Parse(n);
            
            apple.Add(p);            
            Indexes = apple.ToArray();
            a++;                               
        }
    }

    public void ChangeScene()
    {
        InputToArray();
        SceneManager.LoadScene(1);
    }

}
