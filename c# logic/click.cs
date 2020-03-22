using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class click : MonoBehaviour
{
    public static string nameofobj;
    public static int counter;

   // public GameObject objnametext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        counter = counter+1;
        
       // nameofobj = gameObject.name;
        Destroy(gameObject);
        if (counter==2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        // Destroy(objnametext);
    }
}
