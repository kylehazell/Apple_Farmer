using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalsToSpawn;
    public float timeBeforeSpawn = 2f;
    public float SpawnRate= 1.5f;
    public float spawningDistance = 30f;
    public GameObject instantiatedObject;
    void Start()
    {
        InvokeRepeating("SpawnAnimal", timeBeforeSpawn,SpawnRate);
    }

    // Update is called once per frame
    void SpawnAnimal()
    {
      int animalNumber;
      animalNumber = Random.Range(1,4);
      Vector3 spawningPos = new Vector3(Random.Range(-spawningDistance,spawningDistance),transform.position.y,transform.position.z);
      instantiatedObject = Instantiate(animalsToSpawn[animalNumber-1],spawningPos,Quaternion.identity);

      Vector3 rot = instantiatedObject.transform.rotation.eulerAngles;
      rot= new Vector3(rot.x, rot.y + 180, rot.z);
      instantiatedObject.transform.rotation = Quaternion.Euler(rot);
    }
}
