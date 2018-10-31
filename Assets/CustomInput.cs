using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CustomInput : MonoBehaviour {

    static public int[] Indexes;
    public List<int> apple;

    public InputField inputField;
    public InputField inputField1;

    public Button button;
    int y;


    private void Start()
    {

        y = SceneManager.GetActiveScene().buildIndex;
        if (y == 0)
        {
            string s = inputField.text;
        }
        InputToArray();

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
            //a++;                               
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("piano");
    }

}
