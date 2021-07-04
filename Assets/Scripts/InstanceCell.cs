using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceCell : MonoBehaviour
{
    [SerializeField] private GameObject _templateCell;
    [SerializeField] private int _countCell;
    [SerializeField] private float _timeInstance;
    void Start()
    {
        StartCoroutine(InstanceTime());
    }

   private IEnumerator  InstanceTime()
    {
        for (int i = 0; i < _countCell; i++)
        {
            yield return new WaitForSeconds(_timeInstance);
            Instantiate(_templateCell, transform);
        }  
    }

    void Update()
    {

    }
}
