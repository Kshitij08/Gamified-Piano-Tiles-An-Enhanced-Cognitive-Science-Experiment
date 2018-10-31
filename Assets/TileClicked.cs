using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class TileClicked : MonoBehaviour
{

    public GameObject Sprite;
    public SpriteRenderer sr;

    public Vector3 a;

    public List<Vector3> al;





    // Update is called once per frame
    void Update()
    {
         if (Input.GetButtonDown("Player1_Shoot"))
        {
            Vector3 a = Input.mousePosition;

            if (al.Contains(a))
            {
                al.Remove(a);
            }
            else
            {
                al.Add(a);
            }

            Debug.Log(Input.mousePosition);

        }        
        
    }


    public void OnEnd()
    {
        al.ToArray();
        foreach  (Vector3 x in al)
        {
            Debug.Log(x);
        } 
    }


        public void OnMouseDown()
    {
        
        sr.color = Color.black;
             
    }

  
}
