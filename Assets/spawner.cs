using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawner : MonoBehaviour
{

    //public Transform[] spawnPoints;
    //public GameObject tilePrefab;
    //private int[] Indexes;
    //private List<int> apple;

    //public float timeBetweenSpawns = 1f;
    //public float timeToSpawn = 2f;

    //public InputField inputField;

    //int i = 0;
    //int a = 0;


    //private void Start()
    //{
    //    InputToArray();
    //}

    //// Update is called once per frame
    //void Update()
    //{



    //}

    //void TimeToSpawn()
    //{
    //    if (Time.time >= timeToSpawn)
    //    {
    //        SpawnTiles();

    //        timeToSpawn = Time.time + timeBetweenSpawns;

    //        i++;
    //        if (i >= Indexes.Length)
    //        {
    //            i = 0;
    //        }
    //    }
    //}


    //void SpawnTiles()
    //{
    //    // For Random //
    //    //int randomIndex = Random.Range(0, spawnPoints.Length);

    //    //Instantiate(tilePrefab, spawnPoints[randomIndex].position, Quaternion.identity);


    //    // For predefined //
    //    Instantiate(tilePrefab, spawnPoints[Indexes[i]].position, Quaternion.identity);
    //}

    //void InputToArray()
    //{
    //    inputField.text = "01234";
    //    string s = inputField.text;
    //    foreach (char c in s)
    //    {

    //        string n = c.ToString();
    //        int p = int.Parse(n);

    //        apple.Add(p);

    //        Indexes = apple.ToArray();
    //        a++;



    //    }
    //}

    //public void ChangeScene()
    //{
    //    SceneManager.LoadScene(1);
    //}

    public Transform[] spawnPoints;
    public GameObject tilePrefab;

    public float timeBetweenSpawns = 1f;
    public float timeToSpawn = 2f;

    int i = 0;

    

    private void Start()
    {
        
    }

    private void Update()
    {
        while (true)
        {
            TimeToSpawn();
        }
        
    }

    public void TimeToSpawn()
    {
        if (Time.time >= timeToSpawn)
        {
            Instantiate(tilePrefab, spawnPoints[CustomInput.Indexes[i]].position, Quaternion.identity);

            timeToSpawn = Time.time + timeBetweenSpawns;

            i++;

        }
    }

}
