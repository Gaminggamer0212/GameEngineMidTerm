using UnityEngine;

public class GenericSpawner : GenericFactory
{
    public Transform spawnPoints;
    
    public override GameObject SpawnGameObject(GameObject food, Vector3 position)
    {
        //this line was given to me by rider's code auto complete, it looks good so I did not change it
        GameObject go = Instantiate(food, position, Quaternion.identity);
        return go;
    }
}
