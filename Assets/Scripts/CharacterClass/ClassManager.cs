using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    void Start()
    {
        var novice = new Novice(experience: 300, name: "Steven");
        novice.Name = string.Empty;
        Debug.Log(novice.GetProperties());
    }

    // Update is called once per frame
    void Update()
    {
    }

    

}
