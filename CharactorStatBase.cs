using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharectorStatBase : ScriptableObject
{
  public float Health { get; set; }
  
  public int minDamage { get; set; }
  public int maxDamage { get; set; }

  
}