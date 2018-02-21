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
        private Circle _circle;
        public Random Random { get; set; }

        public void Construct(Object enemyPrefab, float spawnRate,int radius)
        {
            _enemyPrefab = enemyPrefab;
            _spawnRate = spawnRate;
            _circle= new Circle(radius);
           
        }
        // Update is called once per frame
        public void Update () {

            if(_circle ==null)
                _circle = new Circle(_radius);


            if (Random == null)
                Random = new Random();

            if(_timeSinceLastSpawn >= _spawnRate)
            {
                //create enemy from prefab
                var enemy = PrefabUtility.InstantiatePrefab(_enemyPrefab) as GameObject;

                enemy.transform.position = _circle.GetPositionOnBoundaryOfCircle(Random.Next(0, 361));
                _timeSinceLastSpawn = 0;
            }
            _timeSinceLastSpawn += Time.deltaTime;
        }
    }
}
