using UnityEditor;
using UnityEngine;
using Random = System.Random;

namespace Assets.Script
{
    public class EnemySpawner : MonoBehaviour {

        [SerializeField] private Object _enemyPrefab;
        [SerializeField] private float _spawnRate;
        [SerializeField] private int _radius;

        private float _timeSinceLastSpawn;
        public Random Random { get; set; }

        public void Construct(Object enemyPrefab, float spawnRate,int radius)
        {
            _enemyPrefab = enemyPrefab;
            _spawnRate = spawnRate;
            _radius = radius;

        }
        // Update is called once per frame
        private void Update () {

            if (Random == null)
                Random = new Random();
            if(_timeSinceLastSpawn >= _spawnRate)
            {
                var enemy = PrefabUtility.InstantiatePrefab(_enemyPrefab) as GameObject;
                var degrees = Random.Next(0, 361);

                var x = _radius * Mathf.Cos(degrees * Mathf.Deg2Rad);
                if (Mathf.Abs(x) < 0.01f) x = 0;

                var y = _radius * Mathf.Cos(degrees * Mathf.Deg2Rad);
                if (Mathf.Abs(y) < 0.01f) y = 0;

                enemy.transform.position = new Vector3(x, 0, y);
                _timeSinceLastSpawn = 0;
            }
            _timeSinceLastSpawn += Time.deltaTime;
        }
    }
}
