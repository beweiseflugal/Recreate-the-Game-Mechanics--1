using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public static Circle Instance;
    private void Awake(){
        Instance = this;
    }
    
   
}
