using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class clickPets : MonoBehaviour
{
    public static string nameofobj;
    public static int counterPets;

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
        counterPets = counterPets+1;
        
       // nameofobj = gameObject.name;
        Destroy(gameObject);
        if (counterPets==2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        // Destroy(objnametext);
    }
}
