using UnityEngine;

public abstract class GenericFactory : MonoBehaviour
{
    public abstract GameObject SpawnGameObject(Food prefab, Vector3 position);
}
