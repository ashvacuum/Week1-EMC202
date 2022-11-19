using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novice
{
   protected string _name;
   protected float _experience;
   protected float _baseHealth;
   protected int _vitality;
   protected int _agility;
   protected int _power;

   public float MaxHealth => _baseHealth + (_vitality * 3);

   public int Level => (int)(_experience / 1000);

   public string Name
   {
      get => _name;
      set => _name = string.IsNullOrEmpty(value) ? "George" : value;
   }

   public Novice()
   {
      _experience = 0.0f;
      _name = "";
      _baseHealth = 100.0f;
   }

   public Novice(string name = "Steve", float baseHealth = 200, float experience = 100)
   {
      _name = name;
      _experience = experience;
      _baseHealth = baseHealth;
   }

   public string GetProperties()
   {
      var properties = 
         $"{nameof(_name)}:{_name}, {nameof(_experience)}:{_experience}, {nameof(_baseHealth)}:{_baseHealth}";
   
      return properties;
   }
}
