using System.Collections;
using Assets.Script;
using NSubstitute;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Assets.Tests
{
    public class SpawningTest
    {

        [UnityTest]
        public IEnumerator _Instantiantes_GameObject_From_Prefab()
        {
            var enemyPrefab = Resources.Load("Tests/Enemy");
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();

            //construct method will setup state
            enemySpawner.Construct(enemyPrefab, 0, 1);

            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            var prefabOfTheSpawnedEnemy = PrefabUtility.GetPrefabParent(spawnedEnemy);

            Assert.AreEqual(enemyPrefab, prefabOfTheSpawnedEnemy);
        }

        [UnityTest]
        public IEnumerator _Instantiates_GameObject_At_Random_Position_On_Circle_Boundary()
        {
            var enemyPrefab = Resources.Load("Tests/enemy");
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();
            //construct method will setup state
            enemySpawner.Construct(enemyPrefab, 0, 1);
            var random = NSubstitute.Substitute.For<System.Random>();
            random.Next(Arg.Any<int>(), Arg.Any<int>()).Returns(270);
            enemySpawner.Random = random;


            yield return null;

            var spawnedEnemy = GameObject.FindWithTag("Enemy");
            //270 degrees
            var expectedPosition = new Vector3((float)-6.5, (float)1.1, (float)5.7);

            Assert.AreEqual(expectedPosition, spawnedEnemy.transform.position);



        }

        [UnityTest]
        public IEnumerator _Instantiations_Occur_On_An_Interval()
        {

            var enemyPrefab = Resources.Load("Tests/enemy");
            var enemySpawner = new GameObject().AddComponent<EnemySpawner>();

            //construct method will setup state
            enemySpawner.Construct(enemyPrefab, 1, 1);

            yield return new WaitForSeconds(0.75f);
            var spawnedEnemy = GameObject.FindWithTag("Enemy");

            Assert.IsNull(spawnedEnemy);
        }

        //will be run after test
        [TearDown]
        public void AfterEveryTest()
        {
            foreach (var gameObject in GameObject.FindGameObjectsWithTag("Enemy"))
                Object.Destroy(gameObject);

            foreach (var gameObject in Object.FindObjectsOfType<EnemySpawner>())
                Object.Destroy(gameObject);

        }
    }
}
