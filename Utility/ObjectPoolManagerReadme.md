# Object Pooling in Unity

This Unity project provides a simple implementation of object pooling functionality using C#. Object pooling is a technique used to efficiently manage the instantiation and reusability of frequently used objects in a game or application, improving performance by reducing the overhead of object creation and destruction.

## Getting Started

1. Clone or download this repository to your local machine.
2. Open the project in Unity.
3. Navigate to the `./Utility` folder to add the `ObjectPoolManager.cs` script that implements the object pooling functionality.

## Usage

1. Attach the `ObjectPoolManager` script to an empty GameObject in your scene.
2. Set the `prefab` field in the `ObjectPoolManager` script to the prefab you want to pool.
3. Adjust the `poolSize` field to define the initial size of the object pool.
4. In your own scripts, access the object pool by using `ObjectPoolManager.Instance.GetPooledObject()` to retrieve an object from the pool. Set its position, rotation, and any other necessary properties.
5. When you no longer need an object, return it to the pool using `ObjectPoolManager.Instance.ReturnToPool(objectToReturn)`.

## Example Usage

```csharp
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = ObjectPoolManager.Instance.GetPooledObject();
            obj.transform.position = transform.position;
            obj.transform.rotation = transform.rotation;
        }
    }
}
```

## License

This project is licensed under the [MIT License](LICENSE).
