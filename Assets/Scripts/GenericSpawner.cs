using System.Collections.Generic;
using UnityEngine;

public class GenericSpawner : GenericFactory
{
    
    public override GameObject SpawnGameObject(Food food, Vector3 position)
    {
        GameObject go = Instantiate(food.gameObject, position, Quaternion.identity);
        return go;
    }
}
