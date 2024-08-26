using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocadorEdificios : MonoBehaviour
{
    [SerializeField] private GameObject[] fondos;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float resetPosition = -10f;
    [SerializeField] private float startPosition = 10f;
    [SerializeField] private float delay = 10f;
    void Start(){
        for (int i = 0; i < fondos.Length; i++)
        {
            StartCoroutine(SpawnAfterDelay(fondos[i]));
        }
    }
    IEnumerator SpawnAfterDelay(GameObject obj)
    {
        // Espera el tiempo especificado
        yield return new WaitForSeconds(delay);

        // Activar el objeto o instanciarlo
        obj.SetActive(true);
    }
}
