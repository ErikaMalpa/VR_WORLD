using UnityEngine;

namespace Assets.Scripts.Spawner
{
    /// <inheritdoc />
    /// <summary>
    /// This will spawn the AI in the game at a random location
    /// </summary>
    public class aiSpawn : MonoBehaviour {

        //When our next character will spawn
        private float _spawnTime;
        //Limit the spawn to 15
        private int _spawnLimit = 15;
        private int _spawnCount;

        //Where you put your prefab charachter 
        [SerializeField]
        private GameObject _characterPrefab;
        //public ObjectPooler objectPooler;
        //It will spawn every 10 seconds
        [SerializeField]
        private float _spawnDelay = 10;


        void OnEnable()
        {
           // EventManager.StartListening("Spawn", spawnListener);
            EventManager.StartListening("Spawn", Spawn);
        }

        void OnDisable()
        {
           // EventManager.StopListening("Spawn", spawnListener);
            EventManager.StopListening("Spawn", Spawn);
        }


        //private void Start()
        //{
        //    objectPooler = ObjectPooler2.Instance;
        //}

        /// <summary>
        /// if the spawn count is less than or equal to the limit
        /// It will spawn the object in the location that was chosen
        /// </summary>
        private void Update()
        {
            if (_spawnCount > _spawnLimit) return;
            if (!Spawning()) return;
            Spawn();
            float xp = Random.Range(0f, -100f);
            const float yp = 1f;
            float zp = Random.Range(0f, 100f);
            transform.position = new Vector3(xp, yp, zp);
        }
        /// <summary>
        /// We set the spawn time with current time plus the delay
        /// We call the instantiate and it will spawn the object with the position and rotation
        /// Spawn count incremented
        /// </summary>
        private void Spawn()
        {
            _spawnTime = Time.time + _spawnDelay;
            Instantiate(_characterPrefab, transform.position, transform.rotation);
            //objectPooler.SpawnFromPool("EnemySpawner", transform.position, transform.rotation);
            _spawnCount++;
        }

        /// <summary>
        /// Boolean for spawning
        /// </summary>
        /// <returns>if current time is greater than the next spawn time</returns>
        private bool Spawning()
        {
            return Time.time >= _spawnTime;
        }
    }
}
