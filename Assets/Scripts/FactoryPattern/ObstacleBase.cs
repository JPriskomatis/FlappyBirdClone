using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using UnityEngine;

//We create a base Obstacle class that our obstacles will inherit from;
//Which is why we make it abstract;
public abstract class ObstacleBase : MonoBehaviour 
{
    //We make this function abstract because we want each obstacle
    //to be able to ovveride it;
    public abstract void Initialize();
}
