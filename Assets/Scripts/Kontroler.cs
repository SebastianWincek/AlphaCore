using UnityEngine;
using System.Collections;
public class Kontroler : MonoBehaviour
{
    [SerializeField] private GameObject WrogPrefab;
    private GameObject _enemy;
    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(WrogPrefab) as GameObject;
            _enemy.transform.position = new Vector3(Random.Range(15f,21f), 1, Random.Range(19f,-19f));
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}