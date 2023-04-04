using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBunny : MonoBehaviour
{
    [SerializeField] private GameObject _bunnyPrefab;

    public void SpawnObject()
    {
        GameObject obj = Instantiate(_bunnyPrefab, transform.position, Quaternion.identity, transform);
        obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-1f, 1f), 1) * 25000);
    }
}
