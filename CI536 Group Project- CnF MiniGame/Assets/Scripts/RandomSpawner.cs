using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class RandomSpawner : MonoBehaviour {
        public GameObject Prefeb;
        public float Radius = 1;
        public GameObject[] OAR;

    void Start() {
        OAR = new GameObject[Random.Range(10, 20)];
        for (int i = 0; i < OAR.Length; i++) {
            Vector3 randomPos = Random.insideUnitCircle * Radius;
            Instantiate(Prefeb, randomPos, Quaternion.identity);
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}