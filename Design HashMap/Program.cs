using System;
using System.Collections.Generic;
using System.Linq;

namespace Design_HashMap
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public class MyHashMapUsingArray
    {

      int[] map;

      /** Initialize your data structure here. */
      public MyHashMapUsingArray()
      {
        map = new int[1000001];
        for (int i = 0; i < map.Length; i++)
          map[i] = -1;
      }

      /** value will always be non-negative. */
      public void Put(int key, int value)
      {
        map[key] = value;
      }

      /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
      public int Get(int key)
      {
        return map[key];
      }

      /** Removes the mapping of the specified value key if this map contains a mapping for the key */
      public void Remove(int key)
      {
        map[key] = -1;
      }
    }

    public class MyHashMap
    {
      public class HashObject
      {
        public int key { get; set; }
        public int value { get; set; }
        public HashObject(int key, int value)
        {
          this.key = key;
          this.value = value;
        }

      }
      public List<HashObject> keyValuePairs;
      public MyHashMap()
      {
        keyValuePairs = new List<HashObject>();
      }

      public void Put(int key, int value)
      {
        var existing = Contains(key);
        if (existing == null)
        {
          keyValuePairs.Add(new HashObject(key, value));
          return;
        }
        existing.value = value;
      }

      public int Get(int key)
      {
        var existing = Contains(key);
        return existing == null ? -1 : existing.value; 
      }

      public void Remove(int key)
      {
        var existing = Contains(key);
        if (existing != null)
        {
          keyValuePairs.Remove(existing);
        }
      }

      private HashObject Contains(int key)
      {
        return keyValuePairs.FirstOrDefault(kvp => kvp.key == key);
      }
    }
  }
}
